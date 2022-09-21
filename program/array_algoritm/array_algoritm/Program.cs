using System;

namespace array_algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var array1 = new int[5];
            string input;
            int search, x, y;
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rand.Next(20);
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
            do
            {
                Console.WriteLine("1-Buble Sort\n2-Search\n3-Exit");
                input = Console.ReadLine();
                if (input == "1")
                    ArrayFunctions.BubleSort(array1);
                else if (input == "2")
                {
                    Console.Write("prvek k vyhledání: ");
                    while (!int.TryParse(Console.ReadLine(), out search))
                        Console.WriteLine("Neplatné číslo, zadejte znovu:");
                    Console.WriteLine("prvek se nachází na této pozici:" + ArrayFunctions.LinearSearch(array1, search) + "\n");
                }
                else if (input == "3")
                    break;
                else
                    Console.WriteLine("Neplatná volba\n");
            } while (true);
            ///2D POLE
            do
            {
                Console.Write("Zadejte rozměr x pole: ");
                x = Extensions.IntInput();
                Console.Write("Zadejte rozměr y pole: ");
                y = Extensions.IntInput();
                var array2 = new int[x, y];
                ArrayFunctions.Print2D(array2);
                Console.Write("Zadejte požadavanou sořadnici x pro vložení čísla: ");
                x = Extensions.IntInput(); ;
                Console.Write("Zadejte požadavanou sořadnici y pro vložení čísla: ");
                y = Extensions.IntInput();
                Console.Write("Zadejte požadavanou požadavanou hodnotu: ");
                array2[x, y] = Extensions.IntInput();
                ArrayFunctions.Print2D(array2);
                Console.WriteLine("Pro ukončení programu zadejte konec");
                if (Console.ReadLine().ToLower() == "konec")
                    break;
            } while (true);

        }
        class ArrayFunctions
        {
            public static int[] BubleSort(int[] array)
            {
                int temp = 0;
                for (int i = 0; i < array.Length; i++)
                    for (int j = 0; j < array.Length - 1; j++)
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                Print(array);
                return array;
            }
            public static int LinearSearch(int[] array, int searching)
            {
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == searching)
                    {
                        return i;
                    }
                return -1;
            }
            private static void Print(int[] array)
            {
                foreach (int item in array)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
            public static void Print2D(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                        Console.Write(array[i, j] + " ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
        class Extensions
        {
            public static int IntInput()
            {
                int input;
                while (!int.TryParse(Console.ReadLine(), out input))
                    Console.WriteLine("Error");
                return input;
            }
        }
    }
}

