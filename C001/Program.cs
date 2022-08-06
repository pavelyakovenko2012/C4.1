// Задайте массив
// min-Random,max-Random
// 12-size, [-9;9].
// Sum(-,+)
int[] GetArray (int size, int minRandom, int maxRandom)
{
    int[] result = new int [size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minRandom, maxRandom+1);
    }
    return result;
}
int[] array = GetArray(12,-9,9);
System.Console.WriteLine($"Результат: [{String.Join(";", array)}]");
int resultPozitive = 0;
int resultNegative = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0)  resultPozitive+=array[i];
    else resultNegative+=array[i];
}
System.Console.WriteLine($"Сумма положительных чисел: {resultPozitive} ");
System.Console.WriteLine($"Сумма отрицательных чисел: {resultNegative} ");