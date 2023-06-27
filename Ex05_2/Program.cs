// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
//Сумма элементов, стоящих на нечетных позициях
int SumOdd(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result = result + array[i];
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

int[] array = FillArray(size[0], rang[0], rang[1]);
PrintArray(array);
System.Console.WriteLine($"Сумма элементов с нечетными индексами = {SumOdd(array)}");