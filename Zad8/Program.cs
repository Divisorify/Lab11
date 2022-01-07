// See https://aka.ms/new-console-template for more information
int a, b,i;
Console.WriteLine("Podaj dół przedziału: ");
a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Podaj górę przedziału: ");
b= Convert.ToInt32(Console.ReadLine());
i = a + 1;
while (i > a && i < b){
    if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    i++;
}