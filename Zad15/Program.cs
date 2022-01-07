// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
const int rows = 3;
const int columns = 3;

double[,] matrix1 = new double[rows, columns];
double[,] matrix2 = new double[rows, columns];
double[,] matrix3 = new double[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write("Podaj [" + i + "][" + j + "] 1 macierzy: ");
        matrix1[i, j] = double.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write("Podaj [" + i + "][" + j + "] 2 macierzy: ");
        matrix2[i, j] = double.Parse(Console.ReadLine());
    }
}

różnica();

void różnica()
{
    //for (int i = 0; i < rows; i++)
    //{
    //    for (int j = 0; j < columns; j++)
    //    {
    //        Console.WriteLine("[" + i + "][" + j + "] 1 macierzy: " + matrix1[i, j]);
    //    }
    //}

    //for (int i = 0; i < rows; i++)
    //{
    //    for (int j = 0; j < columns; j++)
    //    {
    //        Console.WriteLine("[" + i + "][" + j + "] 2 macierzy: "+matrix2[i,j]);
    //    }
    //}
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix3[i, j] = matrix1[i, j] - matrix2[i, j];
            Console.WriteLine("[" + i + "][" + j + "] odjętych macierzy: " + matrix3[i, j]);
        }
    }
    //Console.WriteLine("suma dwóch podanych macierzy wynosi: " + a);



    //double a = 0;
    //for (int i = 0; i < rows; i++)
    //{
    //    for (int j = 0; j < columns; j++)
    //    {
    //        a = a+matrix2[i, j]+matrix1[i,j];

    //    }
    //}
    //Console.WriteLine("Suma dwóch podanych macierzy wynosi: "+a);
}
