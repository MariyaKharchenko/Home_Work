/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/


int[] CreateArray(int size, int min, int max){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

int[] array = CreateArray(10, 100, 999);
Console.WriteLine($"[{string.Join(", " , array)}]");

int FindCount(int[]array){
    int count = 0;
    foreach(int i in array){
        if (i%2 == 0){
            count++;
        }
    }
    return count;
}

int result = FindCount(array);
Console.WriteLine($"Количество четных чисел в массиве: {result}");