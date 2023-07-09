/*
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int GetNumber(string description){
    Console.Write($"{description}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int FindSum(int m, int n){
    if (m==n) return n;
    return m + FindSum(m+1, n);
}

int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
Console.WriteLine(FindSum(m, n));
