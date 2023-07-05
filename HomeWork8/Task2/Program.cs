/*
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/

int GetNumber(string description){
    Console.Write($"{description}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] CreateMatrix(int row, int col, int min, int max){
    int[,] array = new int[row, col];
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void PrindMatrix(int[,] array){
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for(int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine("");
    }

}

int[] FindSomOfRows(int[,] array, int row){
    int[] newArray = new int[row];
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            newArray[i] += array[i,j]; 
        }
    }
    return newArray;
}



int row = GetNumber("Введите количество строк в матрице");
int col = GetNumber("Введите количество столбцов в матрице");
int min = GetNumber("Введите минимальное число необходимого диапазона");
int max = GetNumber("Введите максимальное число необходимого диапазона");

int[,] matrix = CreateMatrix(row, col, min, max);
PrindMatrix(matrix);
Console.WriteLine("");

int[] array = FindSomOfRows(matrix, row);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine("");

int minSum = 1000;
int index = -1;
for (int i = 0; i < array.Length; i++){
    if (array[i]<minSum){
        minSum = array[i];
        index = i;
    }
}

Console.WriteLine($"номер строки с наименьшей суммой элементов: {index+1} строка");