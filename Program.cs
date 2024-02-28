using System;

int[] selection_sort_numbers = {5,72,3,14,7,1};
Console.WriteLine("Array before Selection Sort: ");
for (int i = 0; i < selection_sort_numbers.Length; i++)
{
    Console.Write("  " + selection_sort_numbers[i]);
}
Console.WriteLine("");
Console.WriteLine("Array after running Selection Sort: ");
Selection_Sort(selection_sort_numbers);
Console.WriteLine("");

static void Selection_Sort(int[] ss_arr)
{
    int min_position;
    int temp;

    for (int i = 0; i < ss_arr.Length; i++)
    {
        min_position = i;
        for (int x = i + 1; x < ss_arr.Length; x++)
        {
            if (ss_arr[x] < ss_arr[min_position])
            {
                min_position = x;
            }
        } 
        if (min_position != i)
        {
            temp = ss_arr[i];
            ss_arr[i] = ss_arr[min_position];
            ss_arr[min_position] = temp;
        }
        Console.Write("  " + ss_arr[i]);
    }
}