#include <DHT.h>
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>
#include <Servo.h>   
   
LiquidCrystal_I2C lcd(0x27,16,2);

int num_speed_fan = 0; // nhận dữ liệu từ giao diện điều khiển để điều khiển tốc độ quạt
int pos = 0;
int num_light = 1; //biến kiểm soát số lần mở/kéo rèm cửa sổ phòng ngủ

char rcv_data ;
char data;
char send_data;
char send_data_1;
bool crl = false;
bool crl1 = false;
int k = 1;

int button_motor_manual = 10;
int button_motor_bed = 9;

int motor_bed = 6;

//gán chân Led
int button_led = 12;
int led = 13;

// gán chân cảm biến ánh sáng LM393
int light_sensor = A0;

//Đật tên cho biến Servo
Servo my_curtain;

const int DHTPIN = 2;
const int DHTTYPE = DHT11;
DHT dht(DHTPIN, DHTTYPE);

// hiển thị kí tự đặc biệt độ
byte degree[8] = {
  0B01110,
  0B01010,
  0B01110,
  0B00000,
  0B00000,
  0B00000,
  0B00000,
  0B00000
};

void setup() {
// set up LCD
  lcd.init();  
  lcd.backlight();
  lcd.print("ND:");
  lcd.setCursor(8,0);
  lcd.print(" DA:");
  lcd.setCursor(3,1);
  lcd.print("QUAT: ");
  lcd.createChar(1, degree);
  dht.begin();  

//setup các motor
  pinMode(motor_bed, OUTPUT);
 
// setup led 
  pinMode(button_led, INPUT);//khai báo chân button có thể đọc dữ liệu
  pinMode(button_motor_bed, INPUT);//khai báo chân button có thể đọc dữ liệu điều khiển thủ công quạt

// setup các nút điều kiển manual/ auto
  pinMode(button_motor_manual, INPUT);//khai báo chân button điều khiển chế độ Auto/Manual của quạt
  
  pinMode(led,OUTPUT);//khai báo chân led là ngõ ra

// setup chân nhận dữ liệu từ cảm biến ánh sáng LM393
  pinMode(light_sensor,INPUT);//khai báo chân led là ngõ ra

  my_curtain.attach(11);

//tốc độ Baud
Serial.begin(9600);
}

void loop() { 
//khi mới khởi động ta cho quạt phòng ngủ không quay
 if (k == 1 ){
 analogWrite(motor_bed, 255);
  lcd.setCursor(9,1);
    lcd.print("0");
    lcd.print("     ");
 k--;
 }
 
// đọc DHT11
  float h = dht.readHumidity();
  float t = dht.readTemperature();

// hiển thị DHT11 lên LCD
  if (isnan(t) || isnan(h)) {  } 
  else {
    lcd.setCursor(3,0);
    lcd.print(round(t));
    lcd.write(1);
    lcd.print("C");

    lcd.setCursor(12,0);
    lcd.print(round(h));
    lcd.print("%");    
  }

  int buttonStatus_motor_manual = digitalRead(button_motor_manual);//đọc trạng thái button điều khiển chế độ auto/manual của quạt phòng ngủ
// điều khiển quạt phòng ngủ
  int buttonStatus_motor_bed = digitalRead(button_motor_bed);//đọc trạng thái button motor phòng khách

if (buttonStatus_motor_manual == LOW ) { // LOW nghĩa là chế độ tự động
  if (buttonStatus_motor_bed == HIGH) { // nhấn nút bật quạt thủ công
    if ( t < 17 || t > 45 ) {
      analogWrite(motor_bed, 255);//nếu nhiệt độ quá ngưỡng nóng và lạnh thì cho quạt ngùng quay
      lcd.setCursor(9,1);
      lcd.print("0");
      lcd.print("     ");
      
      // truyền dữ liệu lên giao diện điều khiển C#
      send_data = '0';
      
    } else {
      int motor_bed_speed = map(t,17,45,0,255);//chuyển thang đo của value từ 20 đến 45 độ C sang thang 255 đến 0
      analogWrite(motor_bed, 255- motor_bed_speed);//Gán tốc độ quay của motor 
      lcd.setCursor(9,1);
      lcd.print(round(motor_bed_speed/25));
      lcd.print("     ");

       // truyền dữ liệu lên giao diện điều khiển C#
       if (round(motor_bed_speed/25) != 10) {
       send_data_1 = round(motor_bed_speed/25);
       send_data = send_data_1 + 48 ;
       }
      else send_data = 'z';// đáng lẽ ra phải là số 10 nhưng tạm thời để là 9 sẽ sửa sau
  } 
  }
  else {//nếu chưa bật chế độ điều khiển quạt thủ công
    analogWrite(motor_bed, 255);
    lcd.setCursor(9,1);
    lcd.print("0");
    lcd.print("     ");

     // truyền dữ liệu lên giao diện điều khiển C#
      send_data = '0';
  }
}

 // nhận dữ liệu từ serialport C# đối với đèn phòng ngủ
if(Serial.available()){ 
 rcv_data = Serial.read();
 data = rcv_data;

// xử lý bật đèn khi có lệnh từ winform C#
 if ( rcv_data == 'a' && digitalRead(button_led) == LOW && crl == false){
    digitalWrite(led,HIGH); //bật led
    Serial.write('A');
     crl = true;
  }

  if ( rcv_data == 'a' && digitalRead(button_led) == HIGH && crl == false){
     digitalWrite(led,HIGH); //BẬT led
     Serial.write('A');
     crl = true;
  }

  // xử lý TẮT ĐÈN cửa khi có lệnh TẮT ĐÈN từ winform C#
 if ( rcv_data == 'b' && digitalRead(button_led) == LOW && crl == true){
    digitalWrite(led,LOW); //TẮT led
    Serial.write('B');
     crl = false;
  }

  if ( rcv_data == 'b' && digitalRead(button_led) == HIGH && crl == true){
   digitalWrite(led,LOW); //TẮT led
   Serial.write('B');
     crl = false;
  }

  // xử lý bật quạt và điều chỉnh tốc độ quạt khi ở chế độ điều khiển thủ công qua giao diện điều khiển
  if (buttonStatus_motor_manual == HIGH){
    if (data == 'c'){
      if ( t >= 17 && t <= 45 ) {
      int motor_bed_speed = map(t,17,45,0,255);//chuyển thang đo của value từ 20 đến 45 độ C sang thang 255 đến 0
      analogWrite(motor_bed, 255- motor_bed_speed);//Gán tốc độ quay của motor 
      lcd.setCursor(9,1);
      lcd.print(round(motor_bed_speed/25));
      lcd.print("     ");
      data = 0;
      }else {
      analogWrite(motor_bed, 255);//Gán tốc độ quay của motor 
      lcd.setCursor(9,1);
      lcd.print("0");
      lcd.print("     ");
      data = 0;
      }
    }

      if (data == 'z'){
      analogWrite(motor_bed, 0);//Gán tốc độ quay của motor 
      lcd.setCursor(9,1);
      lcd.print(10);
      lcd.print("     ");
      send_data = 'z';
      data = 0;
      
    }

    if (data >= '1' && data <= '9'){
      int motor_bed_speed = (int)rcv_data - 48 ;
      analogWrite(motor_bed, 255- 25* motor_bed_speed);//Gán tốc độ quay của motor 
      lcd.setCursor(9,1);
      lcd.print(motor_bed_speed);
      lcd.print("     ");
      send_data = motor_bed_speed + 48;
      data = 0;
      }
    
  };
  if (data == 'd'){
     analogWrite(motor_bed, 255);
    lcd.setCursor(9,1);
    lcd.print("0");
    lcd.print("     ");
    send_data = '0';
    data = 0;
  }

  
}

// Điều khiển đèn thủ công bằng công tắc ở trong nhà
// bật thủ công 
  if ( digitalRead(button_led) == HIGH && crl == false && rcv_data != 'b' && rcv_data != 'c' && rcv_data != 'd' )
  if (rcv_data != '0'&& rcv_data != '1'&& rcv_data != '2'&& rcv_data != '3'&& rcv_data != '4'&& rcv_data != '5'&& rcv_data != '6'&& rcv_data != '7'&& rcv_data != '8'&&  rcv_data != '9') {
     digitalWrite(led,HIGH); //bật led
    Serial.write('A');
     crl = true;
  }

  // tắt thủ công
 if ( digitalRead(button_led) == LOW && crl == true  && rcv_data != 'a' && rcv_data != 'c' && rcv_data != 'd')
  if (rcv_data != '0'&& rcv_data != '1'&& rcv_data != '2'&& rcv_data != '3'&& rcv_data != '4'&& rcv_data != '5'&& rcv_data != '6'&& rcv_data != '7'&& rcv_data != '8'&&  rcv_data != '9') {
    digitalWrite(led,LOW); //TẮT led
   Serial.write('B');
     crl = false;
  }

// xử lý cập nhật tốc độ QUẠT lên giao diện điều khiển
if (data == 's'){
  Serial.println(send_data);
  data = 0;
}
  // Thu nhận giữ liệu cảm biến ánh sáng
  int light_sensor_analog = analogRead(light_sensor);

// trời sáng giá trị analog giảm nên sẽ mở rèm cửa cho ánh sáng vào
  if (light_sensor_analog  < 500 && num_light == 1){
    for(pos = 0; pos < 120; pos += 1){ 
      my_curtain.write(pos);
        delay(10);
  }
  num_light -- ;
  }

  // trời tối giá trị analog tăng nên sẽ đóng rèm cửa để đi ngủ vì trời tối
   if (light_sensor_analog  > 500  && num_light == 0){
    for(pos = 120; pos >=1; pos -= 1) {                          
        my_curtain.write(pos);
        delay(10);
    }
   num_light ++ ;
   }
}
