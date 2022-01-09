// See https://aka.ms/new-console-template for more information
Random r = new Random();

int[][] jagged_arr = new int[10][];

// Initialize the elements
jagged_arr[0] = new int[r.Next(10,101)];
jagged_arr[1] = new int[r.Next(10, 101)];
jagged_arr[2] = new int[r.Next(10, 101)];
jagged_arr[3] = new int[r.Next(10, 101)];
jagged_arr[4] = new int[r.Next(10, 101)];
jagged_arr[5] = new int[r.Next(10, 101)];
jagged_arr[6] = new int[r.Next(10, 101)];
jagged_arr[7] = new int[r.Next(10, 101)];
jagged_arr[8] = new int[r.Next(10, 101)];
jagged_arr[9] = new int[r.Next(10, 101)];

for (int n = 0; n < jagged_arr.Length; n++)
{
    for(int i = 0; i < jagged_arr[n].Length; i++)
    {
        jagged_arr[n][i] = r.Next(0, 1000);
    }
    // Print the row number
    System.Console.Write("Row({0}): ", n);

    for (int k = 0; k < jagged_arr[n].Length; k++)
    {

        // Print the elements in the row
        System.Console.Write("{0} ", jagged_arr[n][k]);
    }
    System.Console.WriteLine();
    System.Console.WriteLine();
}
    
