// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console. WriteLine("Введите число");
int N1 = Convert.ToInt32(Console.ReadLine());
Console. WriteLine("Введите число");
int N2 = Convert.ToInt32(Console.ReadLine());
Console. WriteLine("Введите число");
int N3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Max(N1, Math.Max(N2, N3)));