// See https://aka.ms/new-console-template for more information

ArrayFunctions.BubleSort(new int[] { 15, 4, 8, 4, 1, 9 });
ArrayFunctions.SelectionSort(new int[] { 15, 4, 1188, 54, 1, 58 });
ArrayFunctions.InsertionSort(new int[] { 185, 47, 758, 475, 751, 97 });
ArrayFunctions.QuickSort(new int[] { 1555, 4457, 54458, 575, 51, 954547 }, 0, 5);
ArrayFunctions.Print((ArrayFunctions.QuickSort(new int[] { 1555, 4457, 54458, 575, 51, 954547 }, 0, 5)), "QuickSort: ");

class ArrayFunctions
{
    public static void BubleSort(int[] array)
    {
        int temp;
        for (int i = 0; i < array.Length; i++)
            for (int j = 0; j < array.Length - 1; j++)
                if (array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
        Print(array, "BuubleSort: ");
    }
    public static void SelectionSort(int[] array)
    {
       int temp, min;
        for (int i = 0; i < (array.Length - 1); i++)
        {
            min = array.Length - 1;
            for (int j = i; j < (array.Length - 1); j++)
                if (array[min] > array[j])
                    min = j;
            temp = array[min];
            array[min] = array[i];
            array[i] = temp;
        }
        Print(array, "SelectionSort: ");
    }
    public static void InsertionSort(int[] array)
    {
        int temp;
        for (int i = 0; i < array.Length - 1; i++)
            for (int j = i + 1; j > 0; j--)
                if (array[j - 1] > array[j])
                {
                    temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                }

        Print(array, "InsertionSort: ");
    }
    public static int[] QuickSort(int[] array, int leftIndex, int rightIndex)
    {
        int i = leftIndex;
        int j = rightIndex;
        int pivot = array[leftIndex];
        int temp;
        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }

            while (array[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }
        if (leftIndex < j)
            QuickSort(array, leftIndex, j);
        if (i < rightIndex)
            QuickSort(array, i, rightIndex);
        return array;
    }

        public static void Print(int[] array, string text)
    {
        Console.Write(text);
        foreach (int item in array)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}