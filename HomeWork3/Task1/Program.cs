/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

int number = 0;
void Print (string text){
    Console.WriteLine (text);
}

int GetIntNumber (){
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void ShowResult(int number){

    int num1 = number / 10000;
    int num2 = number / 1000 % 10;
    int num4 = number / 10 % 10;
    int num5 = number %10;

    if (num1 == num5 && num2 == num4){
        Print("Введенное число яаляется палиндромом");
        return;
    }
    else{
        Print($"Введенное число не яаляется палиндромом");
        return;
    }
}

bool ChecksTheCondition(int number){
    int lengthNumber = 0;
    int num = number;
    while (num>0){
        num /= 10;
        lengthNumber++;
    }
    if (lengthNumber == 5){
        ShowResult(number);
        return true;
    }
    else{
        Print($"Надо было ввести пятизначное число.");
        return false;
    }
}   

Print("Введите пятизначное число: ");
number = GetIntNumber();
ChecksTheCondition(number);
