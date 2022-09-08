// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
System.Console.Write("Введите число > ");
string number = Console.ReadLine() ?? "0";
int count = int.Parse(number);
for (int i = 1; i <= count; i++)
{
    System.Console.WriteLine($"Куб числа {i} = {i*i*i}");
}