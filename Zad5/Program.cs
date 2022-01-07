// See https://aka.ms/new-console-template for more information
int a, b, c;

Console.WriteLine("Podaj ax^2, a = :");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Podaj bx, a = :");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Podaj c, c = :");
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Twój trójmian stopnia kwadratowego to: "+a+"x^2+"+b+"x+"+c);

oblicz(a,b,c);

static void oblicz(int a, int b, int c)
{
    int delta;
    double pierw0 = 0, pierw1 = 0, pierw2 = 0;
    delta = (int)(Math.Pow(b, 2)) + 4 * a * c;
    Console.WriteLine("Delta wynosi: " + delta);

    if (delta < 0)
    {
        Console.WriteLine("Brak pierwiastków");
    }
    else if (delta == 0)
    {
        pierw0 = (-b) / (2 * a);
        Console.WriteLine("Pierwiastek wynosi: " + pierw0);
    }
    else if (delta > 0)
    {
        pierw1 = ((-b) + Math.Sqrt(delta)) / (2 * a);
        pierw2 = (b + Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("Pierwiatek 1 wynosi: " + pierw1);
        Console.WriteLine("Pierwiatek 2 wynosi: " + pierw2);
    }
}
