#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <Keypad.h>
#include <Servo.h>   

const byte ROWS = 4;
const byte COLS = 4;
const long password = 784512;
long sign_in = 0;
int i = 3 ; 
char rcv_data ;
bool crl = false;

char hexaKeys[ROWS][COLS] = {
{'7', '8', '9', 'A'},
{'4', '5', '6', 'B'},
{'1', '2', '3', 'C'},
{'E', '0', 'N', 'D'}
};

byte rowPins[ROWS] = {2,3,4,5};
byte colPins[COLS] = {6,7,8,9};

int speaker = 11;
int led = 12;
int pir = 13;
int door_btn = A3;

Keypad customKeypad = Keypad(makeKeymap(hexaKeys), rowPins, colPins, ROWS, COLS);

LiquidCrystal_I2C lcd(0x27, 16, 2);

Servo my_door; 

int pos = 0;
int pir_count = 0 ;

void setup(){
// setup LCD
lcd.init();
lcd.backlight();
lcd.clear();

// setup buzzer, led, pir. servo
pinMode(speaker, OUTPUT);
pinMode(led, OUTPUT);

pinMode(pir, INPUT);
pinMode(door_btn, INPUT);

my_door.attach(10);

//tốc độ Baud
Serial.begin(9600);
}

void loop(){
  
// nhận dữ liệu từ serialport C#
if(Serial.available()){ 
  rcv_data = Serial.read();

 // xử lý mở cửa khi có lệnh mở cửa từ winform C#
 if ( rcv_data == 'a' && digitalRead(door_btn) == LOW && crl == false){
     for(pos = 0; pos < 180; pos += 1){ 
      my_door.write(pos);
        delay(10);
     }
   //  Serial.write('A');
     crl = true;
  }

  if ( rcv_data == 'a' && digitalRead(door_btn) == HIGH && crl == false){
     for(pos = 0; pos < 180; pos += 1){ 
      my_door.write(pos);
        delay(10);
     }
   //  Serial.write('A');
     crl = true;
  }

  // xử lý ĐÓNG cửa khi có lệnh ĐÓNG cửa từ winform C#
 if ( rcv_data == 'b' && digitalRead(door_btn) == LOW && crl == true){
     for(pos = 180; pos > 0; pos -= 1){ 
      my_door.write(pos);
        delay(10);
     }
    // Serial.write('B');
     crl = false;
  }

  if ( rcv_data == 'b' && digitalRead(door_btn) == HIGH && crl == true){
     for(pos = 180; pos > 0; pos -= 1){ 
      my_door.write(pos);
        delay(10);
     }
   //  Serial.write('B');
     crl = false;
  }

}

//điều khiển led theo cảm biến pir
if (digitalRead(pir) == HIGH ){
 digitalWrite(led,HIGH);
  pir_count ++ ;
  delay(300);
 if(pir_count == 30 ){
   digitalWrite(speaker, HIGH);
   pir_count = 0 ;
 }
}
 else {
  delay(3000);
  digitalWrite(led,LOW);
  digitalWrite(speaker, LOW);
  }

// Điều khiển mở cửa ra vào thử công bằng công tắc ở trong nhà
// Mở cửa thủ công
  if ( digitalRead(door_btn) == HIGH && crl == false && rcv_data != 'b'){
     for(pos = 0; pos < 180; pos += 1){ 
      my_door.write(pos);
        delay(10);   
     }
    // Serial.write('A');
     crl = true;
  }

  // xử lý đóng cửa thủ công bằng công tắc ở trong nhà
 if ( digitalRead(door_btn) == LOW && crl == true  && rcv_data != 'a'){
     for(pos = 180; pos > 0; pos -= 1){ 
      my_door.write(pos);
        delay(10);
     }
   //  Serial.write('B');
     crl = false;
  }

 
// xử lý đăng nhập vào nhà qua của door
char customKey = customKeypad.getKey();
if (customKey){
 if (customKey != 'E'){
  lcd.clear();
 lcd.setCursor(0,0);

customKey -= 48;
 sign_in = sign_in*10 + customKey;
 lcd.print(sign_in);
 
 } 

 else { if (sign_in == password){
  // xử lý mở của khi nhập đúng mật khẩu
     for(pos = 0; pos < 120; pos += 1){ 
      my_door.write(pos);
        delay(10);
    }
    delay(5000);
    // xủ lý đóng cửa sau khi mở của
    for(pos = 120; pos >=1; pos -= 1) {                           
        my_door.write(pos);
        delay(40);
    } 
    
    lcd.clear();
    sign_in = 0;
  } else {
    lcd.clear();
    sign_in = 0;
    i--;
  }
}
}

// loa báo động khi nhập sai mật khẩu 3 lần
if (i == 0){
  i = 3;
  digitalWrite(speaker, HIGH);
}
}
