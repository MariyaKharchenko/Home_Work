/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает 
все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.WriteLine("Ввeдите число больше 2: ");
int number = Convert.ToInt32(Console.ReadLine());

int average = 2;

if (number > 2)
{
while (average <= number)
{
    Console.Write($"{average} ");
    average += 2;
}
Console.WriteLine("");
}
else
{
   Console.WriteLine("Необходими ввести число больше 2."); 
}
