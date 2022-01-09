// See https://aka.ms/new-console-template for more information
//Random r = new Random();
//Console.Write("Podaj rozmiar tablicy: ");
//int N = Convert.ToInt32(Console.ReadLine());
//int a = 0;
//int[] tab = new int[N];
//for(int i=0; i<tab.Length; i++)
//{
//    int z = i + 1;
//    Console.Write("Podaj "+z+" wartość tablicy: ");
//    tab[i] = Convert.ToInt32(Console.ReadLine());
//    a = a + tab[i];
//}
//Console.WriteLine("Suma tablicy: "+a);

unsafe
{
    string? input;
    int size;
    do
    {
        Console.Write("Podaj wielkość tablicy: ");
        input = Console.ReadLine();
    } while (!int.TryParse(input, out size) || size <= 0);

    int* tab = stackalloc int[size];

    for (int i = 0; i < size; i++)
    {
        *(tab + i) = Random.Shared.Next(10);
    }

    int sum = 0;

    for (var i = 0; i < size; i++)
    {
        sum += *(tab + i);
        Console.WriteLine("Address: {0} Value: {1}", new IntPtr(tab + i), *(tab + i));
    }
    Console.WriteLine("Suma: "+sum);
}
