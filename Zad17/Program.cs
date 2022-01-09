// See https://aka.ms/new-console-template for more information
const int rows = 2;
const int columns = 2;

double[,] matrix = new double[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write("Podaj [" + i + "][" + j + "] macierzy: ");
        matrix[i, j] = double.Parse(Console.ReadLine());
    }
}

double wyznacznik = matrix[0, 0]*matrix[1,1]-matrix[0,1]*matrix[1,0];

Console.WriteLine("Wyznacznik = "+wyznacznik);