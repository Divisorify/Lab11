unsafe
{
    const int size = 10;
    int* arr = stackalloc int[size] { 1000, 34, 12, 562, 253, 90, 310, 70, 893, 10 };

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                swap(&arr[j], &arr[j + 1]);
            }
        }
    }

    for (int* i = arr; i < arr + size; i++)
        Console.Write(*i + " ");
}

unsafe void swap(int* xp, int* yp)
{
    int temp = *xp;
    *xp = *yp;
    *yp = temp;
}