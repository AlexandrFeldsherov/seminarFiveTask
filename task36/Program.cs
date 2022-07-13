/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/
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
array = ArrRand(array, -100, 100);
int output=0;
for(int i=0;i<array.Length;i++)
{
    if (i%2!=0) output=output+array[i];
}
Console.WriteLine("[{0}] -> {1}", string.Join(", ", array), output);