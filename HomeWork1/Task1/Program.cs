/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Ввeдите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввeдите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst > numberSecond)
{
    Console.WriteLine($"Число {numberFirst} больше числа {numberSecond}.");
}
else if (numberFirst < numberSecond)
{
    Console.WriteLine($"Число {numberSecond} больше числа {numberFirst}.");
}
else
{
    Console.WriteLine("Числа равны.");
}