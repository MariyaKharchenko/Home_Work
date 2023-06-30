/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

int GetNumber(string description){
    Console.Write($"{description}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int positionI = GetNumber("Введите позицию числа по i");
int positionJ = GetNumber("Введите позицию числа по j");

bool FindNumber (int[,] array, int positionI, int positionJ){
    if (positionI<0 | positionJ<0 | positionI>array.GetLength(0) | positionJ>array.GetLength(1)) return false;
    else return true;
}

int FindNumberInArray(int[,]array){
    return array[positionI,positionJ];

}

int[,] matrix = CreateMatrix(4, 4, 0, 10);
PrindMatrix(matrix);
var answer = FindNumber(matrix, positionI, positionJ) ? Convert.ToString(FindNumberInArray(matrix)): $"Элемента нет в списке.";
Console.WriteLine(answer);

