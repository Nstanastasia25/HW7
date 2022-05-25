﻿// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[][] jagged = new int[3][];
jagged[0] = new int[4];
jagged[1] = new int[3];
jagged[2] = new int[5];

// Заполняем массив случайными числами
Random random = new Random();
for (int i = 0; i < jagged.Length; i++)
{
    for (int j = 0; j < jagged[i].Length; j++)
        jagged[i][j] = random.Next(-10, 10);
}

// Исходное содержимое массива
Console.WriteLine("Исходное содержимое массива");
foreach (int[] item in jagged)
{
    foreach (int element in item)
        Console.Write(element + " ");
    Console.WriteLine();
}

// Сортировка массива
foreach (int[] item in jagged)
{
    foreach (int element in item)
        Array.Sort(item);
}

// Отсортированное содержимое массива
Console.WriteLine("\nОтсортированное содержимое массива");
foreach (int[] item in jagged)
{
    foreach (int element in item)
        Console.Write(element + " ");
    Console.WriteLine();
}

Console.ReadKey();
