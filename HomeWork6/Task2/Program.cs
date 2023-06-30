/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


double GetNumber(string description){
    Console.Write($"{description}: ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double b1 = GetNumber("Введите число b1");
double k1 = GetNumber("Введите число k1");
double b2 = GetNumber("Введите число b2");
double k2 = GetNumber("Введите число k2");

double x = 0;
double y = 0;
if (b1 == b2 && k1 == k2) Console.WriteLine("Прямые совпадают. Точек пересечения бесконечное множество.");
else if (b1 == b2) Console.WriteLine("Прямые параллельны. Точки пересечения отсутствуют.");
else {
    x = (b2-b1) / (k1-k2);
    y = (k2*(b2-b1) / (k1-k2)) + b2;
    Console.WriteLine($"{x}, {y}");
}

