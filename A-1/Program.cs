/*Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.*/

Console.Write("Введите число N: "); 
int n = Convert.ToInt32(Console.ReadLine()); 

for (int i = n; i >= 1; i--) 
{ 
Console.Write(i + ","); 
} 
Console.Write($"\b ");