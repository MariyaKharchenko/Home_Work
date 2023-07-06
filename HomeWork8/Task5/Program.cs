/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] CreateMatrix(int row, int col){
    int[,] array = new int[row, col];
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = 0;
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

int[,] FillsTheMatrix(int[,] array){
    int number = 1;
    int i = 0;
    int j = 0;

    while(number<=(array.GetLength(0)*array.GetLength(1))){
        array[i,j] = number;
        number++;
        if(i<=j+1 && i+j<array.GetLength(1)-1){
            j++;
        }
        else if(i<j && i+j>=array.GetLength(0)-1){
            i++;
        }
        else if(i>=j && i+j>array.GetLength(1)-1){
            j--;
        }
        else{
            i--;
        }
    }
    return array;

}

int[,] matrix = CreateMatrix(7,7);
int[,] newMatrix = FillsTheMatrix(matrix);
PrindMatrix(newMatrix);