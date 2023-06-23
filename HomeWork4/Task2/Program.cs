/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


int GetNumber(string description){
    Console.Write($"{description}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = GetNumber("Введите число");

List<int> ourList = new List<int>() {};
while (number > 0)
{
    ourList.Insert(0, number%10);
    number = number/10;
}

int[] array = ourList.ToArray();

int GetSum(int[] array){
    int sum = 0;
    int lengthOfNumbers = array.Length;
    for (int i = 0; i < lengthOfNumbers; i++){
        sum += array[i];
    }
    return sum;
}

int result = GetSum(array);
Console.WriteLine(result);










