// See https://aka.ms/new-console-template for more information
Random r = new Random();
int a=0,min=101,max=0;
long b = 1;
int[] tab = new int[100];
for (int i = 0; i < tab.Length; i++)
{
    tab[i] = r.Next(100);
}


for (int i = 0; i < tab.Length; i++)
{
    a = a + tab[i];
    b = b * tab[i];
    if (tab[i] < min)
    {
        min = tab[i];
    }
    if(tab[i] > max)
    {
        max = tab[i];
    }
}

Console.WriteLine("Suma = "+a);
Console.WriteLine("Iloczyn = " + b);
Console.WriteLine("Średnia = " + a/100);
Console.WriteLine("Minimum = " + min);
Console.WriteLine("Maximum = " + max);