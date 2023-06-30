// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//Проверка заданных границ массива
bool RangValidation(int leftRange, int rightRange)
{
    if (leftRange < 100 || leftRange > 999 || leftRange < 0
         || rightRange < 100 || rightRange > 999 || rightRange < 0
         || leftRange > rightRange)
    {
        return false;
    }
    return true;
}

//Заполнение массива
int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }
    return tempArray;
}
//Печать массива
void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}
//Количество четных элементов
int Counter(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

//Ввод чисел
int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}

/////////////////
int[] size = ReadInt("Укажите размер массива: ");
int[] rang = ReadInt("Укажите левую и правую границы массива через пробел: ");

if (RangValidation(rang[0], rang[1]))
{
    int[] array = FillArray(size[0], rang[0], rang[1]);
    PrintArray(array);
    System.Console.WriteLine($"Количество четных элементов массива = {Counter(array)}");
}
else
{
    System.Console.WriteLine("Массив задан не верно!");
}


