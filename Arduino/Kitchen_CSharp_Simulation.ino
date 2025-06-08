#include <DHT.h>
#include <Wire.h> 
#include <Servo.h>   
   
int pos = 0;
int num_dayphoi = 1; //biến kiểm soát số lần mở/kéo rèm cửa sổ phòng ngủ

char rcv_data ;
char data;
char send_data;
char send_data_1;
bool crl = false;
bool crl1 = false;
int k = 1;

int button_servo_kit = 9;
//int servo_kit = 5;

//gán chân Led
int button_led = 10;
int led = 13;

//Đật tên cho biến Servo
Servo my_dayphoi;

// gán chân cho còi báo động
int speaker = 8;

// gán chân cho cảm biến PIR
int pir = 3;

// gán chân cho cảm biến phát hiện lửa
int fire = 7;

// gán chân cho cảm biến mưa
int rain = 4;

// gán chân cho cảm biến phát hiện khí gas
int gas = 2;

//setup cho 2 cam bien DHt11
const int DHTPIN = 12;
const int DHTTYPE = DHT11;
DHT dht(DHTPIN, DHTTYPE);

const int DHTPIN_1 = 11;
const int DHTTYPE_1 = DHT11;
DHT dht_1(DHTPIN_1, DHTTYPE_1);


void setup (){
dht.begin();  
dht_1.begin();  

// setup cảm biến PIR
pinMode(pir, INPUT);

// setup cảm biến phát hiện lửa
pinMode(fire, INPUT);

// setup cảm biến phát hiện khí gas
pinMode(gas, INPUT);

// setup cảm biến mưa
pinMode(rain, INPUT);

//setup động cơ cho dây phơi quần áo
  //pinMode(servo_kit, OUTPUT);

 // setup cho loa báo động
pinMode(speaker, OUTPUT);
 
  pinMode(button_led, INPUT);//khai báo chân button có thể đọc dữ liệu
  pinMode(button_servo_kit, INPUT);//khai báo chân button có thể đọc dữ liệu điều khiển thủ công dây phơi quần áo
  
  pinMode(led,OUTPUT);//khai báo chân led là ngõ ra

  my_dayphoi.attach(5);

  //tốc độ Baud
Serial.begin(9600);
}

void loop() { 
// đọc giá trị 2 cảm biến DHT11
  float h = dht.readHumidity();
  float t = dht.readTemperature();

  float h_1 = dht_1.readHumidity();
  float t_1 = dht_1.readTemperature();

 // int buttonStatus_servo_kit = digitalRead(button_servo_kit);//đọc trạng button điều khiển dây phơi quần áo

if ( t >= 45 || t_1 >= 45 ){
   digitalWrite(speaker, HIGH);
   Serial.write('t');
}

if ( t < 45 && t_1 < 45 ){
   digitalWrite(speaker, LOW);
   Serial.write('n');
}

  if (digitalRead(pir) == HIGH){
  digitalWrite(speaker, HIGH);
  Serial.write('p');
 }else {
  delay(3000);
  digitalWrite(speaker, LOW);
  Serial.write('n');
 }

 if (digitalRead(fire) == HIGH){
  digitalWrite(speaker, HIGH);
  Serial.write('f');
 }else {
  digitalWrite(speaker, LOW);
  Serial.write('n');
 }

 if (digitalRead(gas) == HIGH){
  digitalWrite(speaker, HIGH);
  Serial.write('g');
 }else {
  digitalWrite(speaker, LOW);
  Serial.write('n');
 }

  if (digitalRead(rain) == HIGH){
  Serial.write('r');
 }else {
  Serial.write('n');
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

  // Điều khiển dây phơi quần áo theo C#

  // Diều khiển kéo dây phơi vào nhà
  if ( rcv_data == 'd' && num_dayphoi == 0 ){
     for(pos = 120; pos >=1; pos -= 1) {    
      my_dayphoi.write(pos);
        delay(10);
    }
      Serial.write('D');
    num_dayphoi ++;
  }
  
  // điều khiển kéo dây ra phơi
  if ( rcv_data == 'c' && num_dayphoi == 1  ){
    
     for(pos = 0; pos <= 120; pos += 1) {                           
        my_dayphoi.write(pos);
        delay(10);
    } 
      Serial.write('C');
    num_dayphoi --;
  }

}

// Điều khiển đèn thủ công bằng công tắc ở trong nhà
// bật thủ công 
  if ( digitalRead(button_led) == HIGH && crl == false && rcv_data != 'b' && rcv_data != 'c' && rcv_data != 'd' )
   {
     digitalWrite(led,HIGH); //bật led
    Serial.write('A');
     crl = true;
  }

  // tắt thủ công
 if ( digitalRead(button_led) == LOW && crl == true  && rcv_data != 'a' && rcv_data != 'c' && rcv_data != 'd')
   {
    digitalWrite(led,LOW); //TẮT led
   Serial.write('B');
     crl = false;
  }

// điều khiển dây phơi quần áo kéo vào tự động
if (digitalRead(rain) == HIGH && num_dayphoi == 0 && rcv_data != 'c' && rcv_data != 'd' && rcv_data != 'a' && rcv_data != 'b'){
 // kéo dây phơi quần áo vào 
 for(pos = 120; pos >=1; pos -= 1) {    
      my_dayphoi.write(pos);
        delay(10);
    }
      Serial.write('D');
    num_dayphoi ++;
 }

 // điều khiển dây phơi quần áo kéo vào thủ công
if (digitalRead(rain) == LOW && num_dayphoi == 0  &&  digitalRead(button_servo_kit) == LOW  && rcv_data != 'c' && rcv_data != 'd' && rcv_data != 'a' && rcv_data != 'b'){
 // kéo dây phơi quần áo vào 
 for(pos = 120; pos >=1; pos -= 1) {    
      my_dayphoi.write(pos);
        delay(10);
    }
      Serial.write('D');
    num_dayphoi ++;
 }


// Điều khiển thủ công kéo dây phơi quần áo ra phơi
 if ( digitalRead(rain) == LOW && num_dayphoi == 1  &&  digitalRead(button_servo_kit) == HIGH  && rcv_data != 'c' && rcv_data != 'd' && rcv_data != 'a' && rcv_data != 'b'){
   for(pos = 0; pos <= 120; pos += 1) {                           
        my_dayphoi.write(pos);
        delay(10);
    } 
      Serial.write('C');
    num_dayphoi --;
 }
}
