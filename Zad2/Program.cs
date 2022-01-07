// See https://aka.ms/new-console-template for more information
Console.Write("Podaj wartość pierwszej przyprostokątnej: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Podaj wartość drugiej przyprostokątnej: ");
int b = Convert.ToInt32(Console.ReadLine());

int c;
c = (int)Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2));
Console.Write("Wartość przeciwprostokątnej wynosi: "+c);