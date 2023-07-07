/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int CreateNumber(int min, int max){
    int rand = new Random().Next(min, max+1);
    return rand;
}

bool Array2dContains(int[,] array, int rand){
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if(array[i,j] == rand){
                return true;
            }
        }
    }
    return false;
}
int[,] CreateMatrix(int row, int col){
    int[,] array = new int[row, col];
    int rand = 0;
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            rand = CreateNumber(10, 100);
            while(Array2dContains(array, rand)){
                rand = CreateNumber(10, 100);
            }
            array[i, j] = rand;
        }
    }
    return array;
}

void PrindMatrix(int[,] array){
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for(int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            Console.Write($"{array[i, j]}({i}, {j})\t");
        }
        Console.WriteLine("");
    }

}

int[,] matrix = CreateMatrix(4,4);
PrindMatrix(matrix);
