//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 10000)
{
     Console.WriteLine("Введено некорректное число");
}
if (number / 10000 != number % 10)
{
    Console.WriteLine("Введенное число не является палиндромом!");
}
else if ((number / 1000) % 10 != (number % 100) / 10)
{
    Console.WriteLine("Введенное число не является палиндромом!");
}

else
{
    Console.WriteLine($"введенное число {number} является палиндромом!");
}
