// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
int[,] GenerateRandomArray(int l, int k)
{
    int[,] array = new int[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
 for (int row = 0; row < array.GetLength(0); row++)
 {
    for (int column = 0; column < array.GetLength(1); column++)
    {
        Console.Write(array[row,column] +" ");
    }
    Console.WriteLine();
 }
}
void ReverseArray(int[,] array, int l, int k)
{
    int[] unarray = new int[k];
    for (int j = 0; j < k; j++) //сохранила первую строку массива в отдельный массив
    {
        unarray[j] = array[0,j];
    }
    for (int count = 0; count < k; count++) // заменила первую строку массива последней
        {
            array[0,count] = array[l-1,count];
        }
    for (int i = 0; i < k; i++) // заменила последнюю строку ранее созданным массивом
    {
        array[l-1,i] = unarray[i];
    }
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);
Console.WriteLine();
ReverseArray(myarray, m, n);
ShowArray(myarray);
*/

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
int[,] GenerateRandomArray(int l, int k)
{
    int[,] array = new int[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
 for (int row = 0; row < array.GetLength(0); row++)
 {
    for (int column = 0; column < array.GetLength(1); column++)
    {
        Console.Write(array[row,column] +" ");
    }
    Console.WriteLine();
 }
}
int[,] ChangingArray(int[,] array, int l, int k)
{
    int[,] unarray = new int[k,l];
    if (l != k)
    {
        Console.WriteLine("Данный массив не возможно перевернуть, число строк и столбцов должно совпадать");
    }
    else
    {
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < l; j++)
            {
                unarray[j,i] = array[i,j];
            }
        }
    }
    return unarray;
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);
Console.WriteLine();
int[,] unmyarray = ChangingArray(myarray, m, n);
ShowArray(unmyarray);
*/

// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
/*
int[,] GenerateRandomArray(int l, int k)
{
    int[,] array = new int[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
 for (int row = 0; row < array.GetLength(0); row++)
 {
    for (int column = 0; column < array.GetLength(1); column++)
    {
        Console.Write(array[row,column] +" ");
    }
    Console.WriteLine();
 }
}
void Dictionary(int[,] array, int l, int k)
{
int count = 0;
for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            for (int index = 0; index < l; index++)
            {
                for (int number = 0; number < k; number++)
                {
                    if (array[i, j] == array [index,number])
                        {
                            count++;
                        }
                }
            }
             Console.WriteLine($"{array[i,j]} встречается {count} раза");
             count = 0;
        }
    }
}
Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);
Console.WriteLine();
Dictionary(myarray, m, n);
*/

// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
/*
int[,] GenerateRandomArray(int l, int k)
{
    int[,] array = new int[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}
void FindMin(int[,] array, int l, int k)
{
    int minx = 0;
    int miny = 0;
    int min = array[0,0];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            if (array[i, j] < min)
            {
                minx = i;
                miny = j;
                min = array[i,j];
            }
        }
    }
    Console.WriteLine($"Наименьший элемент {min}, на выходе получим следующий массив:");
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
            {
                if (row != minx && column != miny)
                    Console.Write(array[row, column] + " ");
            }
            Console.WriteLine();
    }
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);
Console.WriteLine();
FindMin(myarray, m, n);
*/

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] GenerateRandomArray(int l, int k)
{
    int[,] array = new int[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}
void FromMaxToMin(int[,] array, int l, int k)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
        int max = array[i,0];
        for (int j = 0; j > array.GetLength(1); j++)
        {
            if (max < array[i,j])
            {
                array[i,j-1] = array[i,j];
                array[i,j] = max;
                max = array[i,j];
               
            }
        }
   }
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);
Console.WriteLine();
FromMaxToMin(myarray, m, n);
ShowArray(myarray);
*/

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] GenerateRandomArray(int l, int k)
{
    int[,] array = new int[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}
void FindMinSum(int[,] array)
{
   int[] sum = new int[array.GetLength(0)];
   for (int i = 0; i < array.GetLength(0); i++)
   {
       for (int j = 0; j < array.GetLength(1); j++)
       {
            sum[i] = sum[i] + array[i,j];
       }
       Console.WriteLine(sum[i]);
   }
    int min = 0;
   for (int i = 0; i < sum.Length; i++)
   {
        if (sum[i] < sum[min])
        {
            min = i;
        }
   }
   Console.WriteLine(min);
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);
Console.WriteLine();
FindMinSum(myarray);
*/

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GenerateRandomArray(int l, int k)
{
    int[,] array = new int[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}
void ArraySum(int[,] firstArray, int[,] secondArray)
{
   if (firstArray.GetLength(0) != secondArray.GetLength(0) || firstArray.GetLength(1) != secondArray.GetLength(1))
   {
    Console.WriteLine("Произведение найти не возможно");
   }
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
Console.Write("Введите кол-во сток таблицы: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int k = Convert.ToInt32(Console.ReadLine());
int[,] newarray = GenerateRandomArray(l, k);
ShowArray(myarray);
ShowArray(newarray);
Console.WriteLine();
ArraySum(myarray, newarray);