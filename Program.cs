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

// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z1: ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z2: ");
int Z2 = Convert.ToInt32(Console.ReadLine());
double distanceAB;
Console.WriteLine(distanceAB = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2)));

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;
while (count <= num)
{
    Console.Write($"|{Math.Pow(count++, 3)}|");
}