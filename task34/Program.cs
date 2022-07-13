/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
int[] ArrRand(int[] arr, int a, int b)//заполняет созданный массив псевдослучайными числами в интервале от a,b
{
    int[] newArr = new int[arr.Length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        int value = rnd.Next(a, b + 1);
        newArr[i] = value;
    }
    return newArr;
}

int[] array = new int[4];
array = ArrRand(array, 100, 999);
int output=0;
for(int i=0;i<array.Length;i++)
{
    if (array[i]%2==0) output++;
}
Console.WriteLine("[{0}] -> {1}", string.Join(", ", array), output);