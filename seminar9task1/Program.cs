//В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// выделить память под матрицу NxN
// заполнить матрицу соответствующими числами
// найти строку и столбец i чей диагональный элемент максимальный
// выделить память под матрицу MxM, где M = N - 1
// пройтись по матрице NxN и перенести все элементы в матрицу MxM за исключением элементов на строке и столбцу i, т.е. m[k][l] = n[x][y]
// освободить память из под матрицы NxN 6.1) присвоить указатель новой матрице старой матрице
// int[,] matrix = new int[3, 4];


int[,] matrix = new int[5, 5];
int i = 0, j = 0, i1, j1, mini = 0, minj = 0;
Random rnd = new Random();
Console.WriteLine("Случайная матрица:");
for (i = 0; i < 5; i++)
{
    for (j = 0; j < 5; j++)
    {
        matrix[i, j] = rnd.Next(-20, 60);
        Console.Write("{0} ", matrix[i, j]);
    }
    Console.Write("\n");
}
for (i = 0; i < 5; i++)
{
    for (j = 0; j < 5; j++)
    {
        if (matrix[i, j] < matrix[mini, minj])
        {
            mini = i;
            minj = j;
        }
    }
}
Console.WriteLine("\nМинимальный элемент матрицы: {0}", matrix[mini, minj]);
Console.WriteLine("Преобразованная матрица:");
int[,] matrix2 = new int[4, 4];
for (i = 0; i < 4; i++)
{
    if (i >= mini)
    {
        i1 = i + 1;
    }
    else
    {
        i1 = i;
    }
    for (j = 0; j < 4; j++)
    {
        if (j >= minj)
        {
            j1 = j + 1;
        }
        else
        {
            j1 = j;
        }
        matrix2[i, j] = matrix[i1, j1];
        Console.Write("{0} ", matrix2[i, j]);
    }
    Console.Write("\n");
}
Console.Read();
