//Написать программу, которая обменивает элементы первой строки и последней строки

internal class Program
{
    private static void Main()
    {
        int[,] array = { { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 }, { 4, 4, 4, 4 } };

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < array.GetLength(1); i++)
        {
            var tmp = array[array.GetLength(1) - 1, i];
            array[array.GetLength(1) - 1, i] = array[0, i];
            array[0, i] = tmp;
        }

        Console.WriteLine("\nИзмененный массив: ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
