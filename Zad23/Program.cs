// See https://aka.ms/new-console-template for more information
private static void manageCode()
{
    int[] tab1 = new int[1500];
    int[] tab2 = new int[1500];
    int[] tab3 = new int[1500];

    for (int k = 0; k < tab1.Length; k++)
        tab1[k] = 10 + 10;
    for (int k = 0; k < tab2.Length; k++)
        tab2[k] = 10 + 10;
    for (int k = 0; k < tab3.Length; k++)
        for(int z =0;z<tab1.Length;z++)
            tab3[k] += tab1[k]+tab2[z];
}

private static unsafe void unmanageCode()
{
    int* tab1 = stackalloc int[1500];
    int* tab2 = stackalloc int[1500];
    int* tab3 = stackalloc int[1500];

    for (int* k = tab1; k < (tab1 + 1500); k++)
        *k = 10 + 10;
    for(int * k = tab2; k < (tab2 + 1500); k++)
        *k = 10 + 10;
    for (int* k = tab3; k < (tab3 + 1500); k++)
        for(int z =0;z<1500;z++)
            *k += *(tab1+z)+*(tab2+z);
}

unsafe static void Main(string[] args)
{
    int iter = 1000;
    System.Diagnostics.Stopwatch clock = new System.Diagnostics.Stopwatch();

    clock.Start();
    for(int i=0; i<iter;i++)
    {
        manageCode();
    }
    clock.Stop();
    Console.WriteLine("Dla kody zarządzanego: "+clock.ElapsedMilliseconds.ToString());
    clock.Reset();

    clock.Start();
    for (int i =0; i< iter;i++)
    {
        unmanageCode();
    }
    clock.Stop();
    Console.WriteLine("Dla kodu niezarządzanego: "+clock.ElapsedMilliseconds.ToString());

}