// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки 
System.Console.Write("Введите пятизначное число > ");
string number = Console.ReadLine() ?? "0";
int count = int.Parse(number);
if (count > 9999 && count < 100000)
{
    int temp1 = count / 1000;
    int temp2 = count % 100;
    int one = temp1 / 10;
    int tenths = temp1 % 10;
    int penult = temp2 / 10;
    int last = temp2 % 10;
    if (one == last && tenths == penult)
    {
        System.Console.WriteLine($"Число {count} является полиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {count} не является полиндромом");
    }
}
else System.Console.WriteLine("Вы ввели не пятизначное число");