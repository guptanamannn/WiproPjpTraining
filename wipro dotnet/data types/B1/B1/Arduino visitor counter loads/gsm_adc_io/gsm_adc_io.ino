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
 unsigned char rcv,count,gchr,gchr1,robos='s';
 //char pastnumber[11]="";
 
int cntl1=0;

String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete


int ir1      = 10;
int ir2      = 11;
int relay1   = 8;
int relay2   = 9;


int val1 = 0,val2 = 0;

int sts1=0,sts2=0;

float tempc=0;
float vout=0;

void okcheck()
{
  unsigned char rcr;
  do{
      rcr = Serial.read();
    }while(rcr != 'K');
}
void setup() 
{
  // initialize serial:
  Serial.begin(9600);serialEvent();
//    serialEvent();

  pinMode(ir1, INPUT);pinMode(ir2, INPUT);
  pinMode(relay1, OUTPUT);pinMode(relay2, OUTPUT);

  digitalWrite(relay1, LOW);digitalWrite(relay2, LOW);
  
  //cli();
  //serialEvent();
  
   
   // set up the LCD's number of columns and rows:
  lcd.begin(16, 2);
  // Print a message to the LCD.
  lcd.print(" Welcome ");

  delay(1500);

  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("Count:"); //7,0
  
  //serialEvent();
}

void loop() 
{     

  if(digitalRead(ir1) == LOW)
    {while(digitalRead(ir1) == LOW);
      cntl1++;
        lcd.setCursor(7,0);convertl(cntl1);     

         
  if(cntl1 <= 0){digitalWrite(relay1, LOW);digitalWrite(relay2, LOW);}  
  if(cntl1 >= 1 && cntl1 <= 3){digitalWrite(relay1, LOW);digitalWrite(relay2, HIGH);}
  if(cntl1 >= 4){digitalWrite(relay1, HIGH);digitalWrite(relay2, HIGH);}

    }
  if(digitalRead(ir2) == LOW)
    {while(digitalRead(ir2) == LOW);
      cntl1--;if(cntl1 <= 0){cntl1 = 0;}
        lcd.setCursor(7,0);convertl(cntl1);      
    
         
  if(cntl1 <= 0){digitalWrite(relay1, LOW);digitalWrite(relay2, LOW);}  
  if(cntl1 >= 1 && cntl1 <= 3){digitalWrite(relay1, LOW);digitalWrite(relay2, HIGH);}
  if(cntl1 >= 4){digitalWrite(relay1, HIGH);digitalWrite(relay2, HIGH);}


    }

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
           if(inChar == '#')
             {
              gchr1 = Serial.read();
             }  
       
        }
}

void convertl(unsigned int value)
{
  unsigned int a,b,c,d,e,f,g,h;

      a=value/10000;
      b=value%10000;
      c=b/1000;
      d=b%1000;
      e=d/100;
      f=d%100;
      g=f/10;
      h=f%10;


      a=a|0x30;               
      c=c|0x30;
      e=e|0x30; 
      g=g|0x30;              
      h=h|0x30;
    
     
   //Serial.write(a);
   //Serial.write(c);
   lcd.write(e); 
   lcd.write(g);
   lcd.write(h);
}

void converts(unsigned int value)
{
  unsigned int a,b,c,d,e,f,g,h;

      a=value/10000;
      b=value%10000;
      c=b/1000;
      d=b%1000;
      e=d/100;
      f=d%100;
      g=f/10;
      h=f%10;


      a=a|0x30;               
      c=c|0x30;
      e=e|0x30; 
      g=g|0x30;              
      h=h|0x30;
    
     
   Serial.write(a);
   Serial.write(c);
   Serial.write(e); 
   Serial.write(g);
   Serial.write(h);
}


/*
   sensorValue = analogRead(analogInPin);
   sensorValue = (sensorValue/9.31);
   lcd.setCursor(1,1); //rc
   lcd.print(sensorValue);
   Serial.print(sensorValue);
 */
