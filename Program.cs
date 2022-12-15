/*
//Задача 1 Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
int numberB = int.Parse(Console.ReadLine()!);

int sqr = numberB * numberB;
if(sqr == numberA)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
*/

/*
//Задача 2 Напишите программу, которая будет выдавать название дня недели по заданному номеру

Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number ==1)
{Console.WriteLine ("Понедельник");}
if (number ==2)
{Console.WriteLine ("Вторник");}
if (number ==3)
{Console.WriteLine ("Среда");}
if (number ==4)
{Console.WriteLine ("Четверг");}
if (number ==5)
{Console.WriteLine ("Пятница");}
if (number ==6)
{Console.WriteLine ("Суббота");}
if (number ==7)
{Console.WriteLine ("Воскресение");}
*/

/*
//Задача 3 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Последнее число числа {num} является { num % 10}");
*/