/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Ввeдите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввeдите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ввeдите третье число: ");
int numberThird = Convert.ToInt32(Console.ReadLine());

List<int> ourList = new List<int>() {numberFirst, numberSecond, numberThird};

int max = 0;

for (int i = 0; i < ourList.Count; i++)
{
    if (ourList[i] > max)
    {
        max = ourList[i];
    }
}

Console.WriteLine($"Максимальное число {max}.");
