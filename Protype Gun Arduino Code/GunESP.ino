     #include <Wire.h>
    #include <Adafruit_Sensor.h>
    #include <Adafruit_BNO055.h>
#include <utility/imumaths.h>
#include "SoftwareSerial.h"

 int buttonpin=7;
 int buttonstate=0;

    Adafruit_BNO055 bno = Adafruit_BNO055(55);
    SoftwareSerial esp8266(10,11);  //RX  //TX
    int x=0;
    void setup(void) 
    {
      Serial.begin(115200);
      //Serial.println("Orientation Sensor Test"); Serial.println("");
      x=0;
      pinMode(buttonpin,INPUT);
      esp8266.begin(9600);
      /* Initialise the sensor */
      if(!bno.begin())
      {
        /* There was a problem detecting the BNO055 ... check your connections */
        //Serial.print("Ooops, no BNO055 detected ... Check your wiring or I2C ADDR!");
        //while(1);
      }
      
     // delay(1000);
      bno.setExtCrystalUse(true);
      delay(2000);
  Connecting();    
  
    }
     
    void loop(void) 
    {
         
      
      buttonstate=digitalRead(buttonpin);
      /* Get a new sensor event */ 
      sensors_event_t event; 
      bno.getEvent(&event);
      /* Display the floating point data */
      String gun="";
      gun=event.orientation.x;
      gun+=",";
      gun+=event.orientation.y;
      gun+=",";
      gun+=event.orientation.z;
      gun+=",";
      gun+=buttonstate;
      gun+=",";
  
delay(5);
esp8266.println(gun);
Serial.println(gun);
    }

 void Connecting(){
       String cmd="";
      char c='"';
      cmd="AT+CIPSTART=";
      cmd+=c;
      cmd+="TCP";
      cmd+=c;
      cmd+=",";
      cmd+=c;
      
      //mobile ip address
      cmd+="192.168.1.1";

     //laptop IP aadreess
   //  cmd+="192.168.173.1";
      cmd+=c;
      cmd+=",";
      cmd+="1234";
      esp8266.println(cmd);
      delay(3000);
 
      String dmd="AT+CIPMODE=1";
      esp8266.println(dmd);
      delay(500);
      dmd="AT+CIPSEND";
      esp8266.println(dmd);
      delay(500);
      
    }

