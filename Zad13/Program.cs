// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//int[,,] tab = new int[2,2,2];


//int a = 0;
//for (int i = 0; a < 3; i++)
//{
//    int b = Convert.ToInt32(Console.ReadLine());
//    tab[i,i,i] = b;
//}

//Console.WriteLine(tab);
const int MATRIX_ROWS = 3;
const int MATRIX_COLUMNS = 3;

double[,] matrix = new double[MATRIX_ROWS, MATRIX_COLUMNS];

for (int i = 0; i < MATRIX_ROWS; i++)
{
    for (int j = 0; j < MATRIX_COLUMNS; j++)
    {
        Console.Write("Enter value for ({0},{1}): ", i, j);
        matrix[i, j] = double.Parse(Console.ReadLine());
    }
}

//for(int i = 0;i < MATRIX_COLUMNS; i++)
//{
//    for(int j = 0;j < MATRIX_ROWS; j++)
//    {
//        Console.WriteLine(matrix[i, j]);
//    }
//}