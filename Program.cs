// Напишите программу, которая выводит третью цыфру заданного числа или сообщяет, что третьей цыфры нет.
// 645-> 5
// 78-> третьей цыфры нет
// 32679-> 6

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
 Console.Write($"нет третьей цыфры {num}");
 Environment.Exit(0);   
} 
while (num > 999)
{
    num = num / 10;
}
num = num % 10;
Console.Write(num);