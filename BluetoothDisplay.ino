// Include application, user and local libraries
#include "LCD_5110.h"
#include <Wire.h>

// Variables
LCD_5110 myScreen;
boolean  backlight = true;
uint8_t k = 0;


// Add setup code
void setup() {
    myScreen.begin();
    
    myScreen.setBacklight(backlight);

    myScreen.setContrast(60);
    myScreen.setFont(0);
Serial.begin(9600);
  Serial.println("Begin Program!");
    
}


// Add loop code
void loop() {
 
  char incomingByte = 0;
  

  if (Serial.available() > 0) 
  {
    char buffer[32];
    int count = Serial.readBytes(buffer,32); 
    char dest[count+1];
    memcpy(dest,buffer,count);
    dest[count] = '\0';
    myScreen.text(0, 0, dest);
  }

}
