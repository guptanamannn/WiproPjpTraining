/*
  Serial Event example

 When new serial data arrives, this sketch adds it to a String.
 When a newline is received, the loop prints the string and
 clears it.

 A good test for this is to try it with a GPS receiver
 that sends out NMEA 0183 sentences.

 Created 9 May 2011
 by Tom Igoe

 This example code is in the public domain.

 http://www.arduino.cc/en/Tutorial/SerialEvent

 */


#include <LiquidCrystal.h>
#include <stdio.h>

LiquidCrystal lcd(6, 7, 5, 4, 3, 2);
// defines pins numbers

int IR     =8;
int Fir    =9;
int Voice1= 10;
int Voice2 =11;




 char pastnumber[10];
 




 
char k;

String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete


void okcheck()
{
  unsigned char rcr;
  do{
      rcr = Serial.read();
    }while(rcr != 'K');
}


void setup() 
{
  
  pinMode(IR, INPUT); 
  pinMode(Fir, INPUT); 


  pinMode(Voice1,OUTPUT); 
  pinMode(Voice2,OUTPUT);
  
  
  digitalWrite(Voice1,HIGH);
  digitalWrite(Voice2,HIGH);
 

    
  // initialize serial:
  Serial.begin(115200);serialEvent();
  //serialEvent();

  
   // set up the LCD's number of columns and rows:
  lcd.begin(16, 2);lcd.cursor();
  // Print a message to the LCD.
  lcd.print("BANK SECURITY SYSTEM");

  delay(1000);delay(1000);
 

}

void loop() 
{
  void gsminit()
{
  Serial.write("AT\r\n");                   okcheck();
  Serial.write("ATE0\r\n");                 okcheck();
  Serial.write("AT+CMGF=1\r\n");            okcheck();
  Serial.write("AT+CNMI=1,2,0,0\r\n");      okcheck();
  Serial.write("AT+CSMP=17,167,0,0\r\n");   okcheck();
    
  lcd.clear();
  lcd.print("SEND MSG STORE");
  lcd.setCursor(0,1);
  lcd.print("MOBILE NUMBER");  
  do{
     rcv = Serial.read();
    }while(rcv != '*');
     readSerial(pastnumber);
     
  lcd.clear();
  lcd.print(pastnumber);

    Serial.write("AT+CMGS=\"");
    Serial.write(pastnumber);
    Serial.write("\"\r\n"); delay(3000);
    Serial.write("Mobile no. registered\r\n");
    Serial.write(0x1A);    
    //pastnumber[10]='\0';
    delay(4000);  
    
  //delay(1000);
}
   

     if (IR=1) 
   {  
   digitalWrite (Voice1, HIGH);
   digitalWrite (Voice2, LOW);  
      Serial.println("IR ON");
      Serial.write("AT+CMGS=\"");
    Serial.write(pastnumber);
    Serial.write("\"\r\n"); delay(3000);
    Serial.write("WALL BREACK ACCIDENT\r\n");
    
}
  
   if  (IR=0) {  
    Serial.println("IR OFF");
      digitalWrite (Voice1, LOW);
      digitalWrite (Voice2, LOW);  

  }
   if (Fir=1) 
   {  
   digitalWrite (Voice1, LOW);
   digitalWrite (Voice2, HIGH);  
      Serial.println("FIRE ON");
      Serial.write("AT+CMGS=\"");
    Serial.write(pastnumber);
    Serial.write("\"\r\n"); delay(3000);
    Serial.write("FIRE ACCIDENT OCCURED\r\n");
}
  
   if  (Fir=0) {  
    Serial.println("Fir OFF");
      digitalWrite (Voice1, LOW);
      digitalWrite (Voice2, LOW);  

  }
  



void serialEvent() 
{
  while (Serial.available()) 
        {         
         char inChar = (char)Serial.read();
           if(inChar == '*')
             {
              gchr = Serial.read();
             }       
        }
}



