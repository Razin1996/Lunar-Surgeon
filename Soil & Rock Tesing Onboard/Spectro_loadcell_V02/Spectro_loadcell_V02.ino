    /*
    NITROGEN(N) RED
    Phosphorus(P) BLUE
    Potassium(K) PURPLE
    */
    //NITROGEN(N) RED,sensor01
    #define aS0 22
    #define aS1 24
    #define aS2 26
    #define aS3 28
    #define oneSensorOut 30
    int led01=2;
    int br01=50;
    
    //Phosphorus(P) BLUE,sensor 2
    #define bS0 23
    #define bS1 25
    #define bS2 27
    #define bS3 29
    #define twoSensorOut 31
    int led02=3;
    int br02=70;
    
    //Potassium(K) PURPLE,sensor 3
    #define cS0 43
    #define cS1 45
    #define cS2 47
    #define cS3 49
    #define threeSensorOut 51
    int led03=4;
    int br03=70;
    
    //sensor04,amino (A) blue
    #define dS0 42
    #define dS1 44
    #define dS2 46
    #define dS3 48
    #define fourSensorOut 50
    int led04=5;
    int br04=70;
    
    int frequency = 0;
     float R;
     float G;
     float B;
  signed int P ;



  //load cell
  #include "HX711.h"

#define DOUT  6
#define CLK  7
HX711 scale; //HX711 scale(7, 6);

float calibration_factor = -761;
float units;
float ounces;




  //load cell02
//  #include "HX711.h"

#define DOUT  8
#define CLK  9
HX711 scale02; //HX711 scale(7, 6);

float calibration_factor02 = -76000;
float units02;
float ounces02;

    void setup() {
      pinMode(aS0, OUTPUT);
      pinMode(aS1, OUTPUT);
      pinMode(aS2, OUTPUT);
      pinMode(aS3, OUTPUT);
      pinMode(oneSensorOut, INPUT);
      pinMode(led01,OUTPUT);
      analogWrite(led01,br01);
      
      // Setting frequency-scaling to 20%
      digitalWrite(aS0,HIGH);
      digitalWrite(aS1,LOW);

      
      pinMode(bS0, OUTPUT);
      pinMode(bS1, OUTPUT);
      pinMode(bS2, OUTPUT);
      pinMode(bS3, OUTPUT);
      pinMode(twoSensorOut, INPUT);
      pinMode(led02,OUTPUT);
      analogWrite(led02,br02);
      
      // Setting frequency-scaling to 20%
      digitalWrite(bS0,HIGH);
      digitalWrite(bS1,LOW);
      
      pinMode(cS0, OUTPUT);
      pinMode(cS1, OUTPUT);
      pinMode(cS2, OUTPUT);
      pinMode(cS3, OUTPUT);
      pinMode(threeSensorOut, INPUT);
      pinMode(led03,OUTPUT);
      analogWrite(led03,br03);
      
      // Setting frequency-scaling to 20%
      digitalWrite(cS0,HIGH);
      digitalWrite(cS1,LOW);

       pinMode(dS0, OUTPUT);
      pinMode(dS1, OUTPUT);
      pinMode(dS2, OUTPUT);
      pinMode(dS3, OUTPUT);
      pinMode(fourSensorOut, INPUT);
      pinMode(led04,OUTPUT);
      analogWrite(led04,br04);
       digitalWrite(dS0,HIGH);
      digitalWrite(dS1,LOW);


      //load cell
   //Serial.println("HX711 weighing");
  //scale.set_scale(calibration_factor);
  
   scale.begin(DOUT, CLK);
  scale.set_scale();
  scale.tare();
  //Serial.println("Readings:");

//loadcell02
  scale02.begin(DOUT, CLK);
  scale02.set_scale();
  scale02.tare();
      Serial.begin(9600);
    }
    void loop() {
      Serial.print("spectro one");//For  NITROGEN(N) RED
      Serial.println();
      // Setting red filtered photodiodes to be read
      digitalWrite(aS2,LOW);
      digitalWrite(aS3,LOW);
      // Reading the output frequency
      frequency = pulseIn(oneSensorOut, LOW);
      // Printing the value on the serial monitor
      Serial.print("R= ");//printing name
      Serial.print(frequency);//printing RED color frequency
      R=frequency;
      Serial.print("  ");
      delay(100);
      // Setting Green filtered photodiodes to be read
      digitalWrite(aS2,HIGH);
      digitalWrite(aS3,HIGH);
      // Reading the output frequency
      frequency = pulseIn(oneSensorOut, LOW);
      // Printing the value on the serial monitor
      Serial.print("G= ");//printing name
      Serial.print(frequency);//printing RED color frequency
      G=frequency;
      Serial.print("  ");
      delay(100);
      // Setting Blue filtered photodiodes to be read
      digitalWrite(aS2,LOW);
      digitalWrite(aS3,HIGH);
      // Reading the output frequency
      frequency = pulseIn(oneSensorOut, LOW);
      // Printing the value on the serial monitor
      Serial.print("B= ");//printing name
      Serial.print(frequency);//printing RED color frequency
      B=frequency;
      Serial.println("  ");
      delay(100);
      P=R-B;
      if(B<G&&B<R){
        
         if (-1<P&&P<1){
         Serial.println("Processing");
//         Serial.println("Purple Opacity");
//         Serial.print( abs((B+R)/P));
       Serial.println();
            
         }else{  
        Serial.println("Processing");
//         Serial.println("Blue Opacity");
//  Serial.print(abs((B)/P));
  Serial.println();
         }  
      }else if(G<B&&G<R){
        
        Serial.println("Processing");
//         Serial.println("Green Opacity ");
//    Serial.print((abs(G-R)+abs(G-B))/2.0);
     Serial.println();
        }else if(R<B&&R<G){
           if (-1<P && P<1){
            Serial.println("Processing");
//             Serial.println("Purple Opacity");
//      Serial.print( abs((B+R)/P));
       Serial.println();
           } else{
          Serial.println("NITROGEN DETECTED");
           Serial.print("NITROGEN Opacity : ");
    Serial.print(abs(R*100/75));
     Serial.println();
          } 
          
        }else{
          Serial.println("Processing");
          }
          delay(1000);

Serial.println("  ");
Serial.println("  ");



      Serial.print("spectro two");//For Phosphorus(P) BLUE
      Serial.println();
           // Setting red filtered photodiodes to be read
      digitalWrite(bS2,LOW);
      digitalWrite(bS3,LOW);
      // Reading the output frequency
      frequency = pulseIn(twoSensorOut, LOW);
      // Printing the value on the serial monitor
      Serial.print("R= ");//printing name
      Serial.print(frequency);//printing RED color frequency
      R=frequency;
      Serial.print("  ");
      delay(100);
      // Setting Green filtered photodiodes to be read
      digitalWrite(bS2,HIGH);
      digitalWrite(bS3,HIGH);
      // Reading the output frequency
      frequency = pulseIn(twoSensorOut, LOW);
      // Printing the value on the serial monitor
      Serial.print("G= ");//printing name
      Serial.print(frequency);//printing RED color frequency
      G=frequency;
      Serial.print("  ");
      delay(100);
      // Setting Blue filtered photodiodes to be read
      digitalWrite(bS2,LOW);
      digitalWrite(bS3,HIGH);
      // Reading the output frequency
      frequency = pulseIn(twoSensorOut, LOW);
      // Printing the value on the serial monitor
      Serial.print("B= ");//printing name
      Serial.print(frequency);//printing RED color frequency
      B=frequency;
      Serial.println("  ");
      delay(100);
      P=R-B;
      if(B<G&&B<R){
        
         if (-3<P&&P<3){
         Serial.println("Processing");
//         Serial.println("Purple Opacity");
//         Serial.print( abs((B+R)/P));
       Serial.println();
            
         }else{  
        Serial.println("PHOSPHORUS DETECTED");
         Serial.print("PHOSPHORUS Opacity : ");
 Serial.print(abs(B*100/75));
  Serial.println();
        }
      }else if(G<B&&G<R){
        
        Serial.println("Processing");
//         Serial.println("Green Opacity ");
//    Serial.print((abs(G-R)+abs(G-B))/2.0);
     Serial.println();
        }else if(R<B&&R<G){
           if (-3<P && P<3){
            Serial.println("Processing");
//             Serial.println("Purple Opacity");
//      Serial.print( abs((B+R)/P));
       Serial.println();
           } else{
          Serial.println("Processing");
//           Serial.println("RED Opacity");
//    Serial.print(abs(R/P));
     Serial.println();
          } 
          
        }else{
          Serial.println("Processing");
          }
          delay(1000);


Serial.println("  ");
Serial.println("  ");



      Serial.print("spectro three"); //  For  Potassium(K) PURPLE
      Serial.println();
           // Setting red filtered photodiodes to be read
      digitalWrite(cS2,LOW);
      digitalWrite(cS3,LOW);
      // Reading the output frequency
      frequency = pulseIn(threeSensorOut, LOW);
      // Printing the value on the serial monitor
      Serial.print("R= ");//printing name
      Serial.print(frequency);//printing RED color frequency
      R=frequency;
      Serial.print("  ");
      delay(100);
      // Setting Green filtered photodiodes to be read
      digitalWrite(cS2,HIGH);
      digitalWrite(cS3,HIGH);
      // Reading the output frequency
      frequency = pulseIn(threeSensorOut, LOW);
      // Printing the value on the serial monitor
      Serial.print("G= ");//printing name
      Serial.print(frequency);//printing RED color frequency
      G=frequency;
      Serial.print("  ");
      delay(100);
      // Setting Blue filtered photodiodes to be read
      digitalWrite(cS2,LOW);
      digitalWrite(cS3,HIGH);
      // Reading the output frequency
      frequency = pulseIn(threeSensorOut, LOW);
      // Printing the value on the serial monitor
      Serial.print("B= ");//printing name
      Serial.print(frequency);//printing RED color frequency
      B=frequency;
      Serial.println("  ");
      delay(100);
      P=R-B;
      if(B<G&&B<R){
        
         if (-7<P&&P<7){
         Serial.println("Pottasium DETECTED");
         Serial.print("Pottasium Opacity : ");
         Serial.print((((R+B)/2)*100)/3000);
       Serial.println();
            
         }else{  
        Serial.println("Processing");
//         Serial.println("Blue Opacity");
// Serial.print(abs((B)/P));
  Serial.println();
        }
      }else if(G<B&&G<R){
        
        Serial.println("Processing");
//         Serial.println("Green Opacity ");
//    Serial.print((abs(G-R)+abs(G-B))/2.0);
     Serial.println();
        }else if(R<B&&R<G){
           if (-20<P && P<20){
            Serial.println("Pottasium DETECTED");
             Serial.print("Pottasium Opacity : ");
      Serial.print((((R+B)/2)*100)/3000);
       Serial.println();
           } else{
          Serial.println("Processing");
//           Serial.println("RED Opacity");
//    Serial.print(abs(R/P));
     Serial.println();
          } 
          
        }else{
          Serial.println("Processing");
          }
          delay(1000);
          Serial.println("  ");
          Serial.println("  ");

          Serial.print("spectro four");//For Amonia(P) BLUE
      Serial.println();
           // Setting red filtered photodiodes to be read
      digitalWrite(dS2,LOW);
      digitalWrite(dS3,LOW);
      // Reading the output frequency
      frequency = pulseIn(fourSensorOut, LOW);
      // Printing the value on the serial monitor
      Serial.print("R= ");//printing name
      Serial.print(frequency);//printing RED color frequency
      R=frequency;
      Serial.print("  ");
      delay(100);
      // Setting Green filtered photodiodes to be read
      digitalWrite(dS2,HIGH);
      digitalWrite(dS3,HIGH);
      // Reading the output frequency
      frequency = pulseIn(fourSensorOut, LOW);
      // Printing the value on the serial monitor
      Serial.print("G= ");//printing name
      Serial.print(frequency);//printing RED color frequency
      G=frequency;
      Serial.print("  ");
      delay(100);
      // Setting Blue filtered photodiodes to be read
      digitalWrite(dS2,LOW);
      digitalWrite(dS3,HIGH);
      // Reading the output frequency
      frequency = pulseIn(fourSensorOut, LOW);
      // Printing the value on the serial monitor
      Serial.print("B= ");//printing name
      Serial.print(frequency);//printing RED color frequency
      B=frequency;
      Serial.println("  ");
      delay(100);
      P=R-B;
      if(B<G&&B<R){
        
         if (-3<P&&P<3){
         Serial.println("Processing");
//         Serial.println("Purple Opacity");
//         Serial.print( abs((B+R)/P));
       Serial.println();
            
         }else{  
        Serial.println("Amonia DETECTED");
         Serial.print("Amonia Opacity : ");
 Serial.print(abs(B*100/75));
  Serial.println();
        }
      }else if(G<B&&G<R){
        
        Serial.println("Processing");
//         Serial.println("Green Opacity ");
//    Serial.print((abs(G-R)+abs(G-B))/2.0);
     Serial.println();
        }else if(R<B&&R<G){
           if (-3<P && P<3){
            Serial.println("Processing");
//             Serial.println("Purple Opacity");
//      Serial.print( abs((B+R)/P));
       Serial.println();
           } else{
          Serial.println("Processing");
//           Serial.println("RED Opacity");
//    Serial.print(abs(R/P));
     Serial.println();
          } 
          
        }else{
          Serial.println("Processing");
          }


Serial.println();
   //load cell       
  Serial.print("weight:");
  units = scale.get_units(),10;
  
  ounces = units * 0.035274;
  Serial.print(units/1000);
  Serial.println(" grams");
  delay(1000);


  //load cell 02      
  Serial.print("weight load 02:");
  units02 = scale02.get_units(),10;
  
  ounces02 = units02 * 0.035274;
  Serial.print(units02/1000);
  Serial.println(" grams");

Serial.println();

    }
