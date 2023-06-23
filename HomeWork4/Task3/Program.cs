/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void FillArray(int[]array){
    int length = array.Length;
    for (int i = 0; i < length; i++){
        array[i] = new Random().Next(1, 100);
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int[] arr = new int[8];
FillArray(arr);
FillArray(arr);
FillArray(arr);