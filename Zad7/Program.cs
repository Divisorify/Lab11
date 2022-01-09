// See https://aka.ms/new-console-template for more information

int a;
while (true)
{
    Console.WriteLine("Podaj temperaturę do zmiany: ");
    int intInput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Menu: ");
    Console.WriteLine("1. Celsjusze na Kelwiny");
    Console.WriteLine("2. Kelwiny na Celcjusze");
    Console.WriteLine("3. Celsjusz na Faherenheit");
    Console.WriteLine("4. Faherenheit na Celsjusze");
    Console.WriteLine("0. Wyjście ");
    a = Convert.ToInt32(Console.ReadLine());
    switch (a)
    {
        case 1:
            Console.WriteLine("Wynik: " + CtoK(intInput));
            break;
        case 2:
            Console.WriteLine("Wynik: " + KtoC(intInput));
            break;
        case 3:
            Console.WriteLine("Wynik: " + CtoF(intInput));
            break;
        case 4:
            Console.WriteLine("Wynik: " + FtoC(intInput));
            break;
    }
    Console.WriteLine();
    
}
string FtoC(int intInput) => ((intInput - 32) * 5 / 9).ToString();

string CtoF(int intInput) => ((intInput * 9) / 5 + 32).ToString();

string KtoC(int intInput) => (intInput - 273).ToString();

string CtoK(int intInput) => (intInput + 273).ToString();
