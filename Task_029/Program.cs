﻿// 1. Напишите программу, которая задаёт массив из 8 элементов 
// 2. и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 
// -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] FillArray(int num)
{
    int[] array = new int [num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 33);
    }
    return array;
    }

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("[{0}]", string.Join(", ", arr));
        break;
    }
}
int[] myArr = FillArray(8);
PrintArray(myArr);