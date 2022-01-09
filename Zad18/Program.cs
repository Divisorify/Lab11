// See https://aka.ms/new-console-template for more information
const int rows = 3;
const int columns = 3;

double[,] m = new double[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write("Podaj [" + i + "][" + j + "] macierzy: ");
        m[i, j] = double.Parse(Console.ReadLine());
    }
}

double wyznacznik = m[0, 0]*m[1,1]*m[2,2]+m[0,1]*m[1,2]*m[2,0]+m[0,2]*m[1,0]*m[2,1]-(m[0,2]*m[1,1]*m[2,0]+m[0,0]*m[1,2]*m[2,1]+m[0,1]*m[1,0]*m[2,2]);

Console.WriteLine("Wyznacznik = " + wyznacznik);