// See https://aka.ms/new-console-template for more information
int wg, wz;
double bmi;
Console.WriteLine("Obliczanie BMI");
Console.WriteLine("Podaj swoją wagę (kg): ");
wg = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Podaj swój wzrost (cm): ");
wz = Convert.ToInt32(Console.ReadLine());
wz = wz / 100;
bmi = wg/Math.Pow(wz, 2);

if(bmi < 18.5){
    Console.WriteLine("Niedowaga.");
}else if (bmi < 25 && bmi > 18.5){
    Console.WriteLine("Wartość prawidłowa.");
}else if(bmi > 25)
{
    Console.WriteLine("Nadwaga.");
}
