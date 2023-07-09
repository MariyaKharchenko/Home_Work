/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber(string description){
    Console.Write($"{description}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ChecksANumbers(int m, int n){
    if(m >=0 && n >=0) return true;
    else return false;
}

int CalculatesTheAckermanFuntion(int m, int n){
    if(m==0) return n+1;
    if(m>0 && n==0) return CalculatesTheAckermanFuntion(m-1, 1);
    if(m>0 && n>0) return CalculatesTheAckermanFuntion(m-1, CalculatesTheAckermanFuntion(m, n-1));
    return 0;
}

int m = GetNumber("Введите положительное число m");
int n = GetNumber("Введите положительное число n");
if (ChecksANumbers(m,n)){
    Console.WriteLine(CalculatesTheAckermanFuntion(m, n));
}
else Console.WriteLine("Вы ввели отрицательное число.");