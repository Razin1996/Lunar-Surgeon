#include <Servo.h> 
#define cm3 3
#define cm4 4
#define PWM 5
#define m1 6
#define m2 7
#define servoPin01 9
#define servoPin02  10
Servo Servo1; 
Servo Servo2;  
 

byte byteRead;
void setup() {

  pinMode(cm3, OUTPUT);
      pinMode(cm4, OUTPUT);
      pinMode(PWM, OUTPUT);
       pinMode(m1, OUTPUT);
        pinMode(m2, OUTPUT);
      Serial.begin(9600);
  // put your setup code here, to run once:

}

void loop() {
   if (Serial.available()) {
    byteRead = Serial.read();
    if(byteRead== 'c' ){
    Serial.write(byteRead);
  digitalWrite(cm3,LOW);
   digitalWrite(cm4,HIGH);
   analogWrite(PWM,100);
delay(1000);
   digitalWrite(cm3,LOW);
   digitalWrite(cm4,LOW);
   analogWrite(PWM,200); 
    }else if(byteRead== 'C'){
         Serial.write(byteRead);
  digitalWrite(cm3,HIGH);
   digitalWrite(cm4,LOW);
   analogWrite(PWM,100);
delay(2000);
   digitalWrite(cm3,LOW);
   digitalWrite(cm4,LOW);
   analogWrite(PWM,100);
      }else if(byteRead=='M'){
        digitalWrite(m1,HIGH);
   digitalWrite(m2,LOW);
   analogWrite(PWM,200);
   delay(4700);
   digitalWrite(m1,LOW);
   digitalWrite(m2,LOW);
        }else if (byteRead=='m'){
          digitalWrite(m1,LOW);
   digitalWrite(m2,HIGH);
   analogWrite(PWM,200);
   delay(4700);
   digitalWrite(m1,LOW);
   digitalWrite(m2,LOW);
          
          
          }else if(byteRead=='S'){
         Servo1.attach(servoPin01); 
    Servo1.write(90);
    Servo2.attach(servoPin02); 
    Servo2.write(90);
          }else if(byteRead=='s'){
              Servo1.attach(servoPin01); 
    Servo1.write(-90);
    Servo2.attach(servoPin02); 
    Servo2.write(-90);
            }
  }
}
  // put your main code here, to run repeatedly:

