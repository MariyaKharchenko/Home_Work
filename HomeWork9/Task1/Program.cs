/*
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string description){
    Console.Write($"{description}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void ShowsNumbers(int n, int min=1){
    Console.WriteLine(n);
    if (n>min) ShowsNumbers(n-1);
}

int n = GetNumber("Введите число n");
ShowsNumbers(n);