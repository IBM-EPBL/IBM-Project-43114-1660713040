'''Build a python code, assume u get temp and humidity values
 (generated with random function to a variable) and write a
conditon to continuously detect alarm in
 case of high temperature'''
#import the necessary package!
import requests
import random
from time import *
gate=True
#input the city name
def run_city():
  city = input('input the city name')
  print(city)

# or you can also hard-code the value


#Display the message!
  print('Displaying Weater report for: ' + city)

#fetch the weater details
  url = 'https://wttr.in/{}'.format(city)
  res = requests.get(url)

#display the result!
  print(res.text)

#temprature searching
while(gate):
    temperature = random.randint(0,50)
    humidity = random.randint(10,50)
    if temperature>45 and humidity<50:
        print("Temperature =",temperature,"Humidity =",humidity)
        print("Alert message in Activate")
        gate=False
    else:
        print("Temperature =",temperature,"Humidity",humidity)
    sleep(1);

#enter temprature value
x= int(input("Please enter the Humidity value :"))
y= int(input("Please enter the temperature value  :"))
z=print(x,y)
print(z)
if x == 36.5:
    print("Due to Temperature report you are in normal days")
if x < 36:
        print("your Temperature is low compare to normal days")
if x > 36:
            print("your Temperature is high compare to normal days")
if y == 45:
    print("Due to Humidity report you are in normal place")
if y < 45:
        print("your Humidity is low compare to normal days")
if y > 45:
            print("your Humidity is high compare to normal days")





while True:
    run_city()
