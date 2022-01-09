// See https://aka.ms/new-console-template for more information

//unsafe
//{
//    int length = 10;
//    double* numbers = stackalloc double[length];

//        for (var i = 0; i < length; i++)
//    {   
//        Console.Write("Podaj wartość dla tabeli: ");
//        numbers[i] = double.Parse(Console.ReadLine());
//    }


//    fixed (double* ptr = numbers)
//        for (var i = 0; i < length; i++)
//    {
//        int z = i + 1;
//        Console.WriteLine("Wartość komórki " + z + " = "+numbers[i]+ ", adres = " + &(numbers[i]));
//    }
//}

unsafe
{
    float* numbers = stackalloc float[10] { 7, 8, 3, 2, 110, 118, 106, 33, 28, 21 };
    for (var i = 0; i < 10; i++)
    {
        Console.WriteLine("Address: {0} Value: {1}", new IntPtr(numbers + i), *(numbers + i));
    }
}