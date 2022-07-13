/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2*/

double[] ArrRand(double[] arr, int a, int b, int c)//заполняет созданный массив псевдослучайными вещественными числами числами в интервале от 'a' до 'b' c количеством знаков после запятой 'c'
{
    double[] newArr = new double[arr.Length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double value = Math.Round(rnd.NextDouble(),c)+rnd.Next(a, b);
        newArr[i] = value;
    }
    return newArr;
}

double[] array = new double[5];
array = ArrRand(array, -100, 100, 1);
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>max) max = array[i];
    if (array[i]<min) min = array[i];
}
double rezult =max-min;
Console.WriteLine("[{0}] -> {1:f1}", string.Join("; ", array), rezult);