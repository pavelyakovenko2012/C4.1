// Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
int[] array = {-2,-1,1,2};
int searchNumber = new Random().Next(-5,6);
System.Console.WriteLine($"Рандомное число для поиска {searchNumber}");
bool flagResult = false;
for (int i = 0; i < array.Length; i++)
{
    if(searchNumber == array[i])
    {
        flagResult = true;
        break;
    }
}
if (flagResult) Console.WriteLine($"Элемент {searchNumber} присутствует в массиве");
else Console.WriteLine($"Элемент {searchNumber} Не присутствует в массиве");

// Еще одно решение ---
// int[] array = { -3, -2, -1, 0, 1, 2, 3 };

// // int searchNumber = new Random().Next(-5, 6); //[-5;5]

// // Console.WriteLine($"Рандомное число для поиска: {searchNumber}");

// // string flagResult = "отсутствует"; // false - элемента нет, true - элемент есть

// for (int i = 0; i < array.Length; i++)
// {
// if (searchNumber == array[i])
// {
// flagResult = "присутсвует";
// break;
// }
// }
// Console.WriteLine($"{searchNumber} в массиве: {flagResult}");