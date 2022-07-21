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
void ChangingArray(int[,] array, int l, int k)
{
    int[,] unarray = new int[k,l];
    if (l == k)
    {
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < l; j++)
            {
                unarray[j,i] = array[i,j];
            }
        }
        ShowArray(unarray);
    }
    else Console.WriteLine("Данный массив не возможно перевернуть, число строк и столбцов должно совпадать");
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);
Console.WriteLine();
ChangingArray(myarray, m, n);
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

// Домашнее задание
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
void FromMaxToMin(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                    {
                        if (array[i, k] < array[i, k + 1])
                            {
                                int max = array[i, k + 1];
                                array[i, k + 1] = array[i, k];
                                array[i, k] = max;
                            }
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
FromMaxToMin(myarray);
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
            min = i+1;
        }
   }
   Console.WriteLine();
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
void ArraySum(int[,] firstArray, int[,] secondArray)
{
    if (firstArray.GetLength(0) == secondArray.GetLength(1))
    {
    int[,] sumArray = new int[firstArray.GetLength(0),secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                for (int k = 0; k < secondArray.GetLength(0); k++)
                {
                    sumArray[i,j] += firstArray[i,k] * secondArray[k,j];
                }
            }
        }
        ShowArray(sumArray);
    }
    else Console.WriteLine("Произведение найти не возможно");
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
Console.WriteLine();
ShowArray(newarray);
Console.WriteLine();
ArraySum(myarray, newarray);
*/
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] GenerateRandomArray(int l, int k, int n)
{
    int[,,] array = new int[l, k, n];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            for (int m = 0; m < n; m++)
            {
                array[i, j, m] = new Random().Next(9, 100);
            }
        }
    }
    return array;
}
void ShowArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(2); m++)
            {
                Console.Write($"{array[i, j, m]}{(i, j, m)} ");
            }
        }
        Console.WriteLine();
    }
}
Console.Write("Введите ширину массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину массива: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту массива: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] myarray = GenerateRandomArray(x, y, z);
ShowArray(myarray);
*/
// Заполните спирально массив 4 на 4.
/*
int[,] GenerateRandomArray()
{
    int[,] array = new int[4, 4];
    int i = 0;
    int j = 0;
    int num = 1;
    for (j = 0; j < 4; j++)
    {
        array[i, j] = num;
        num++;
    }
    j = 3;
    for (i = 1; i < 4; i++)
    {
        array[i, j] = num;
        num++;
    }
    i = 3;
    for (j = 2; j > -1; j = j - 1)
    {
        array[i, j] = num;
        num++;
    }
    j = 0;
    for (i = 2; i > 0; i = i - 1)
    {
        array[i, j] = num;
        num++;
    }
    i = 1;
    for (j = 1; j < 3; j++)
    {
        array[i, j] = num;
        num++;
    }
    i = 2;
    for (j = 2; j > 0; j = j - 1)
    {
        array[i, j] = num;
        num++;
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

int[,] myarray = GenerateRandomArray();
ShowArray(myarray);
*/