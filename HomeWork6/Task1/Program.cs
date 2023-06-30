/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


int GetNumber(string description){
    Console.Write($"{description}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int size = GetNumber("Введите число, сколько чисел Вы планируете ввести");

int[] CreateArray(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        Console.WriteLine("Введите число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] array = CreateArray(size);
Console.WriteLine($"[{string.Join(", " , array)}]");


int CoutingNumbers (int[] array){
    int count = 0;
    foreach (int number in array){
        if(number > 0){
            count++;
        }
    }
    return count;
}

int result = CoutingNumbers(array);
Console.WriteLine($"Количество цифр больше нуля: {result}");