﻿// Задача 36: Задайте одномерный массив,
//  заполненный случайными числами.
//   Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] array = new int [10];

for (int i = 0; i < 10; i++)
{
      array[i] = new Random().Next(10);
}
for(int i =0; i < 10; i++)
{
    Console.Write(array[i]+ ", ");
}


int sum=0;
for (int i = 0; i < 10; i++)
{
    if(i%2>0)
    {
sum=sum+array[i];
    }
}
Console.WriteLine("-> "+sum);