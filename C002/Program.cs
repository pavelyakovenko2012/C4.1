// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int[] array = {-2,-1,1,2};
for (int i = 0; i < array.Length; i++)
{
    array[i]*=(-1);
    // или array[i]=-array[i]
    System.Console.Write(array[i] + "\n");
    // System.Console.Write(array[i] + "\t"); t-Tab,
    // System.Console.WriteLine() = System.Console.Write("\n"); n-new
}
System.Console.Write("\n");
// System.Console.Write()
System.Console.WriteLine("Тест");