// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Решение---1:
// int[] GetArray (int size, int minRandom, int maxRandom)
// {
//     int[] result = new int [size];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(minRandom, maxRandom+1);
//     }
//     return result;
// }
// int[] array = GetArray(123,0,99);
// System.Console.WriteLine($"Результат: [{String.Join(";", array)}]");
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i]>10 && array[i]<99) count++;
// }
// System.Console.WriteLine($"Результат: {count}");

// Решение---2:
int[] array = new int[123];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(0,999);
    System.Console.Write(array[i]+"\t");
    if (array[i]>=10&&array[i]<=99)
    {
        count++;
    }
}
System.Console.WriteLine();
System.Console.WriteLine($"Колличество чисел в диапозоне [10,99] = {count}");