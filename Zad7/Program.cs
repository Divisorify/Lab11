// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
while (true)
{
    Console.WriteLine("Menu: ");
    Console.WriteLine("1. Celsjusze na Kelwiny");
    Console.WriteLine("2. Kelwiny na Celcjusze");
    Console.WriteLine("3. Celscjusz na Faherenheit");
    Console.WriteLine("4. Faherenheit na Celscjusz");
    Console.WriteLine("0. Wyjście ");
    a = Convert.ToInt32(Console.ReadLine());
    switch (a)
    {
        case 0: return;
        //case 1: return 
    }
}