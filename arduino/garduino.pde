//include the datetime library, so our garduino can keep track of how long the lights are on
#include <DateTime.h> 

//define analog inputs to which we have connected our sensors
int moistureSensor1 = 0;
int moistureSensor2 = 1;
int moistureSensor3 = 2;
int lightSensor = 4;
int tempSensor = 5;

//define digital outputs to which we have connecte our relays (water and light) and LED (temperature)
int waterPump = 7;
int lightSwitch = 8;
int tempLed = 2;

//define variables to store moisture, light, and temperature values
int moisture_val1, moisture_val2, moisture_val3;
int light_val;
int temp_val;

//decide how many hours of light your plants should get daily
float hours_light_daily_desired = 14;

//calculate desired hours of light total and supplemental daily based on above values
float proportion_to_light = hours_light_daily_desired / 24;
float seconds_light = 0;
float proportion_lit;

//setup a variable to store seconds since arduino switched on
float start_time;
float seconds_elapsed;
float seconds_elapsed_total;
float seconds_for_this_cycle;
float mapped_temp;

void setup() {
//open serial port
Serial.begin(9600);
//set the water, light, and temperature pins as outputs that are turned off
pinMode (waterPump, OUTPUT);
pinMode (lightSwitch, OUTPUT);
pinMode (tempLed, OUTPUT);
digitalWrite (waterPump, LOW);
digitalWrite (lightSwitch, LOW);
digitalWrite (tempLed, LOW);

//establish start time
start_time = DateTime.now();
seconds_elapsed_total = 0;

}
void loop() {
// read the value from the moisture-sensing probes, print it to screen, and wait a second
moisture_val1 = analogRead(moistureSensor1);
moisture_val2 = analogRead(moistureSensor2);
moisture_val3 = analogRead(moistureSensor3);
// read the value from the photosensor, print it to screen, and wait a second
light_val = analogRead(lightSensor);
// read the value from the temperature sensor, print it to screen, and wait a second
temp_val = analogRead(tempSensor);
mapped_temp = map(temp_val, 0, 1023, 0, 5000);

//Serial.print("moisture sensor reads ");
Serial.print( moisture_val1 );
Serial.print(",");
Serial.print( moisture_val2 );
Serial.print(",");
Serial.print( moisture_val3 );
Serial.print(",");
//Serial.print("light sensor reads ");
Serial.print( light_val );
Serial.print(",");
//Serial.print("temp sensor reads ");
Serial.print( temp_val );
Serial.print(",");
//Serial.print("mapped temp = ");
Serial.print( mapped_temp/100);
Serial.print(",");
//Serial.print("seconds total = ");
Serial.print( seconds_elapsed_total );
Serial.print(",");
//Serial.print("seconds lit = ");
Serial.print( seconds_light);
Serial.print(",");
//Serial.print("proportion desired = ");
Serial.print( proportion_to_light);
Serial.print(",");
//Serial.print("proportion achieved = ");
Serial.println( proportion_lit);


//turn water on when soil is dry, and delay until soil is wet
if (moisture_val < 850)
{
digitalWrite(waterPump, HIGH);
}

//while (moisture_val < 850)
//{
//delay(1000);
//}

digitalWrite(waterPump, LOW);

//update time, and increment seconds_light if the lights are on
seconds_for_this_cycle = DateTime.now() - seconds_elapsed_total;
seconds_elapsed_total = DateTime.now() - start_time;
if (light_val > 900)
{
seconds_light = seconds_light + seconds_for_this_cycle;
}

//cloudy days that get sunny again: turn lights back off if light_val exceeds 900. this works b/c the supplemental lights aren't as bright as the sun:)
if (light_val > 900)
{
digitalWrite (lightSwitch, LOW);
}

//turn off lights if proportion_lit>proportion_to_light, and then wait 5 minutes
if (proportion_lit > proportion_to_light)
{
digitalWrite (lightSwitch, LOW);
}

//figure out what proportion of time lights have been on
proportion_lit = seconds_light/seconds_elapsed_total;

//turn lights on if light_val is less than 900 and plants have light for less than desired proportion of time, then wait 10 seconds
if (light_val < 900 and proportion_lit < proportion_to_light)
{
digitalWrite(lightSwitch, HIGH);
}

//turn on temp alarm light if temp_val is less than 850 (approximately 50 degrees Fahrenheit)
if (temp_val < 850)
{
digitalWrite(tempLed, HIGH);
}

delay(500);
}
