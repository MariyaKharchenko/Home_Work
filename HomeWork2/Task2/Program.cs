/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

List<int> ourList = new List<int>() {};

int result = 0;

while (number > 0)
{
    ourList.Insert(0, number%10);
    number = number/10;
    result ++;

}


if (result > 2)
{
    Console.WriteLine(ourList[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}