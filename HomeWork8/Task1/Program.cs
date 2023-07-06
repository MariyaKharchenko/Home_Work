/*
Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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


int[,] Sorts(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1)-1; j++){
            if(matrix[i,j]<matrix[i, j+1]){
                int temp = matrix[i,j];
                matrix[i,j] = matrix[i,j+1];
                matrix[i,j+1] = temp;
                Sorts(matrix);
            }
        }
    }
    return matrix;
}


int[,] matrix = CreateMatrix(4,4,0,10);
PrindMatrix(matrix);
Console.WriteLine("");
int[,] sortedMatrix = Sorts(matrix);
PrindMatrix(sortedMatrix);