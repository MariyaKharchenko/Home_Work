/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


void Print (string text){
    Console.WriteLine (text);
}

int GetIntNumber (){
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void GetCube (int number){
    for (int i = 1; i<number; i++){
        Console.Write($"{Math.Pow(i, 3)}, ");
    }
    Console.WriteLine($"{Math.Pow(number, 3)}");
}

Print("Введите число: ");
int number = GetIntNumber();
GetCube(number);
