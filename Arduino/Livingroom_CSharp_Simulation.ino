#include <DHT.h>
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>
   
LiquidCrystal_I2C lcd(0x27,16,2);

int button_motor_liv =7;
int motor_liv = 6;
int motor_bath = 5;

char rcv_data ;
bool crl = false;
bool crl1 = false;
int k = 1;

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

//gán chân Led
int button_led = 12;
int led = 13;

void setup() {
// set up LCD
  lcd.init();  
  lcd.backlight();
  lcd.print("Nhiet do: ");
  lcd.setCursor(0,1);
  lcd.print("Do am: ");
  lcd.createChar(1, degree);
  dht.begin();  

//setup các motor
  pinMode(motor_liv, OUTPUT);
  pinMode(motor_bath, OUTPUT);
 
// setup led 
  pinMode(button_led, INPUT);//khai báo chân button có thể đọc dữ liệu
  pinMode(led,OUTPUT);//khai báo chân led là ngõ ra

  //tốc độ Baud
Serial.begin(9600);
}

void loop() { 
  
 if (k == 1 ){
 analogWrite(motor_liv, 255);//khi mới khởi động ta cho quạt không quay
 k--;
 }
 
  // đọc DHT11
  float h = dht.readHumidity();
  float t = dht.readTemperature();

// hiển thị DHT11 lên LCD
  if (isnan(t) || isnan(h)) {  } 
  else {
    lcd.setCursor(10,0);
    lcd.print(round(t));
    lcd.write(1);
    lcd.print("C");

    lcd.setCursor(10,1);
    lcd.print(round(h));
    lcd.print(" %");    
  }

  
  // nhận dữ liệu từ serialport C# đối với đèn phòng khách
if(Serial.available()){ 
 rcv_data = Serial.read();

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


  // xử lý bật quạt phòng khách khi có lệnh từ winform C#
 if ( rcv_data == 'c' && digitalRead(button_motor_liv) == LOW && crl1 == false){
     if ( t < 20 || t > 45 ) {
      analogWrite(motor_liv, 255);//nếu nhiệt độ quá ngưỡng nóng và lạnh thì cho quạt ngùng quay
    } else {
      int motor_liv_speed = map(t,20,45,0,255);//chuyển thang đo của value từ 20 đến 45 độ C sang thang 255 đến 0
      analogWrite(motor_liv, 255-motor_liv_speed);//Gán tốc độ quay của motor 
  } 
    Serial.write('C');
     crl1 = true;
  }

  if ( rcv_data == 'c' && digitalRead(button_motor_liv) == HIGH && crl1 == false){
      if ( t < 20 || t > 45 ) {
      analogWrite(motor_liv, 255);//nếu nhiệt độ quá ngưỡng nóng và lạnh thì cho quạt ngùng quay
    } else {
      int motor_liv_speed = map(t,20,45,0,255);//chuyển thang đo của value từ 20 đến 45 độ C sang thang 255 đến 0
      analogWrite(motor_liv, 255-motor_liv_speed);//Gán tốc độ quay của motor 
  } 
     Serial.write('C');
     crl1 = true;
  }

  // xử lý TẮT QUẠT cửa khi có lệnh TẮT ĐÈN từ winform C#
 if ( rcv_data == 'd' && digitalRead(button_motor_liv) == LOW && crl1 == true){
    analogWrite(motor_liv, 255);
    Serial.write('D');
     crl1 = false;
  }

  if ( rcv_data == 'd' && digitalRead(button_motor_liv) == HIGH && crl1 == true){
   analogWrite(motor_liv, 255);
   Serial.write('D');
     crl1 = false;
  }
}

// Điều khiển đèn thủ công bằng công tắc ở trong nhà
// bật thủ công
  if ( digitalRead(button_led) == HIGH && crl == false && rcv_data != 'b' && rcv_data != 'c' && rcv_data != 'd'){
     digitalWrite(led,HIGH); //bật led
    Serial.write('A');
     crl = true;
  }

  // tắt thủ công
 if ( digitalRead(button_led) == LOW && crl == true  && rcv_data != 'a' && rcv_data != 'c' && rcv_data != 'd'){
    digitalWrite(led,LOW); //TẮT led
   Serial.write('B');
     crl = false;
  }

// Điều khiển QUẠT phòng khách thủ công bằng công tắc ở trong nhà
// bật thủ công
  if ( digitalRead(button_motor_liv) == HIGH && crl1 == false && rcv_data != 'd' && rcv_data != 'a' && rcv_data != 'b'){
     if ( t < 20 || t > 45 ) {
      analogWrite(motor_liv, 255);//nếu nhiệt độ quá ngưỡng nóng và lạnh thì cho quạt ngùng quay
    } else {
      int motor_liv_speed = map(t,20,45,0,255);//chuyển thang đo của value từ 20 đến 45 độ C sang thang 255 đến 0
      analogWrite(motor_liv, 255-motor_liv_speed);//Gán tốc độ quay của motor 
  } 
    Serial.write('C');
     crl1 = true;
  }

  // tắt thủ công
 if ( digitalRead(button_motor_liv) == LOW && crl1 == true  && rcv_data != 'c' && rcv_data != 'a' && rcv_data != 'b'){
    analogWrite(motor_liv, 255);
   Serial.write('D');
     crl1 = false;
  }
  
//xử lý tốc độ quay của Quạt theo nhiệt độ phòng khách
if ( crl1 == true){
     if ( t < 20 || t > 45 ) {
      analogWrite(motor_liv, 255);//nếu nhiệt độ quá ngưỡng nóng và lạnh thì cho quạt ngùng quay
    } else {
      int motor_liv_speed = map(t,20,45,0,255);//chuyển thang đo của value từ 20 đến 45 độ C sang thang 255 đến 0
      analogWrite(motor_liv, 255-motor_liv_speed);//Gán tốc độ quay của motor 
  } 
 }


  // Điều khiển quạt ở nhà tắm toilet
   analogWrite(motor_bath, 0);

  
}
