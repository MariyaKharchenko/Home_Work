/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

decimal[,] CreateArray(int row, int col, int min, int max){
    decimal[,] array = new decimal[row, col];
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = (decimal)Math.Round((new Random().Next(min, max+1)+new Random().NextDouble()), new Random().Next(0, 2));
        }
    }
    return array;
}

void PrindMatrix(decimal[,] array){
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for(int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine("");
    }

}

decimal[,] array = CreateArray(5, 5, -10, 10);
PrindMatrix(array);

