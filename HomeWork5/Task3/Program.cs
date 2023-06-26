/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальной и минимальной вещественой частью элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 0.22 - 0.15 = 0.07
*/
/*В цикле for данного метода я взяла рандомное чило, прибавила к нему рандомную
вещественную часть, сократила полученную сумму до рандомного количества цифр после 
запятой (от 1 до 3) и привела это всё к типу decimal, так как double для последующих
вычислений не подходит.
*/
decimal[] CreateArray(int size, int min, int max){
    decimal[] array = new decimal[size];
    for(int i = 0; i < size; i++){
        array[i] = (decimal)Math.Round((new Random().Next(min, max+1)+new Random().NextDouble()), new Random().Next(1, 4));
    }
    return array; 
}

decimal[] array = CreateArray(4, 1, 10);
Console.WriteLine($"[{string.Join(", " , array)}]");

decimal[] FindFactorial (decimal[] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = array[i] - Math.Floor(array[i]);
    }
    return array;
}

decimal FindDifference(decimal[] array){
    decimal min = 1.00m;
    decimal max = -1.00m;
    foreach(decimal i in array){
        min = Math.Min(i, min);
        max = Math.Max(i, max);
    }
    decimal difference = max - min;
    return difference;
}
FindFactorial(array);
Console.WriteLine($"[{string.Join(", " , array)}]");

decimal result = FindDifference(array);
Console.WriteLine(result);
