Console.WriteLine(GetMax([1,2,3,4,5]));

static double GetMax(int[] arr)
{
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
    }

    return max;
}