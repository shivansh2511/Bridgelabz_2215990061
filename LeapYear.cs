using System;
class Leapyear{
static void Main(string[] args){
Console.WriteLine("Enter the Year greater than 1582:");
int year;
if(!int.TryParse(Console.ReadLine(), out year) ){
Console.WriteLine("Enter the Valid Year");
return;
}
if(year<1582){
Console.WriteLine("Enter the Year Greater Than 1582");
}
else{
if(year%4 ==0 && year % 100 ==0 && year % 400 ==0)
{
	Console.WriteLine(string.Format("Entered Year {0} is a LeapYear ",year));
}

else{
	Console.WriteLine("Not a Leapyear");
}
}
}
}


