/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)
{
    if (number < 6)
    {
        Console.WriteLine("Это будний день");
    }
    else
    {
        Console.WriteLine("Это выходной!");
    }
}
else
{
    Console.WriteLine("Введите число от 1 до 7");
}