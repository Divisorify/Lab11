// See https://aka.ms/new-console-template for more information
Console.WriteLine("Podaj rozmiar tablicy: ");
int i = Convert.ToInt32(Console.ReadLine());

float[] tab = new float[i];

for (int j = 0; j < tab.Length; j++)
{
    int x = j + 1;
    Console.WriteLine("Podaj "+x+" wartość tablicy.");
    tab[j] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ------------------ ");

for (int j = 0;j < tab.Length; j++)
{
    int x = j + 1;
    Console.WriteLine(x+". Wartość tablicy: "+tab[j]);
}