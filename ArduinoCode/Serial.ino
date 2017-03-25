#include <Arduino.h>

/*
Serial port communication on Computer Controller Arduino with C#
Author: Kazım Bayram <kazim1001@gmail.com>
*/

byte status;



void setup()
{

	Serial.begin(9600);
	// Serial Veri kodları kodlar buraya gelecek;


}


void loop()
{
    if(Serial.available()){
        status = Serial.read();
        Serial.println(status);
	delay(1000);
        /// işlem kodları buraya gelecek kodu buraya gelcek;
    }

}
