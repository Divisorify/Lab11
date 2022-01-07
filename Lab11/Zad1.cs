// See https://aka.ms/new-console-template for more information
Console.WriteLine("Podaj temperaturę w stopniach Celsjusza: ");
int TCelsjusz;
int TFahrenheit;
TCelsjusz = Convert.ToInt32(Console.ReadLine());

//TCelsjusz = (TFahrenheit − 32)/ 2;
TFahrenheit = (TCelsjusz * 2) + 32;
Console.WriteLine("Wynik to " + TFahrenheit + " stopni Fahrenheita.");