/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


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

int[] CreateArray(int[,] array, int col){
    int[] newArray = new int[col];
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            newArray[i] += array[j,i]; 
        }
    }
    return newArray;
}
decimal[] FindMean(int[] array, int row, int col){
    decimal[] theArithmeticMeanOfColumns = new decimal[col];
    for(int i = 0; i < array.Length; i++){
        theArithmeticMeanOfColumns[i] = (decimal)array[i]/row;
    }
    return theArithmeticMeanOfColumns;
}

int GetNumber(string description){
    Console.Write($"{description}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int row = GetNumber("Введите количество строк в матрице");
int col = GetNumber("Введите количество столбцов в матрице");
int min = GetNumber("Введите минимальное число необходимого диапазона");
int max = GetNumber("Введите максимальное число необходимого диапазона");

int[,] matrix = CreateMatrix(row, col, min, max);
PrindMatrix(matrix);

int[] array = CreateArray(matrix, col);
decimal[] arrayMeanOfColumns = FindMean(array, row, col);
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", arrayMeanOfColumns)}");

