// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console. WriteLine("Введите число");
int N1 = Convert.ToInt32(Console.ReadLine());
Console. WriteLine("Введите число");
int N2 = Convert.ToInt32(Console.ReadLine());
if(N1 > N2) {
    Console.WriteLine("N1 больче чем N2");
}
else if (N1 == N2) {
    Console.WriteLine("N1 равен N2");
}
else {
    Console.WriteLine("N2 больче чем N1");
}