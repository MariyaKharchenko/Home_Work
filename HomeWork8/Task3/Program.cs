/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] FindsTheProductsOfMatrix(int[,] matrix, int[,] array){
    int[,] newMatrix = new int[matrix.GetLength(0), array.GetLength(1)];
    for(int i = 0; i < newMatrix.GetLength(0); i++){
        for (int j = 0; j < newMatrix.GetLength(1); j++){
            for(int k = 0; k < newMatrix.GetLength(1); k++){
                newMatrix[i,j] += matrix[i,k]*array[k,j];
            }
        }
    }
    return newMatrix;
}

int[,] matrix = CreateMatrix(2,2,1,5);
PrindMatrix(matrix);
Console.WriteLine("");
int[,] array = CreateMatrix(2,2,1,5);
PrindMatrix(array);
Console.WriteLine("");
int[,] matrix2 = FindsTheProductsOfMatrix(matrix, array);
PrindMatrix(matrix2);