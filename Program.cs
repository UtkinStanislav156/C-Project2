// Написать программу, которая принимает на вход цыфру обозначающую день недели и выявляющюю выходной
// 6->да ; 7->да;  1->нет

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
Console.Write($"понедельник нет");
}
if (a == 2)
{
Console.Write($"вторник нет");   
}
if (a == 3)
{
Console.Write($"среда нет");    
}    
if (a == 4)
{
Console.Write($"четверг нет");
}
if (a == 5)
{
Console.Write($"пятница нет");    
}
if (a == 6)
{
Console.Write($"суббота да");   
}
if (a == 7)
{
Console.Write($"воскресение да");    
}