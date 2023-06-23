/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber(string description){
    Console.Write($"{description}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

while(true){
int numberA = GetNumber("Введите первое число");
int numberB = GetNumber("Введите втрое число");

if(numberB > 0){
    int result = (int)Math.Pow(numberA, numberB);
    Console.WriteLine(result);
    return;
}
Console.WriteLine($"Число В должно быть больше нуля. Повторите попытку. ");
}