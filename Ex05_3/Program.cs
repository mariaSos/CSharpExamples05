// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

//Заполнение массива
double[] FillArray(int size, int leftRange, int rightRange)
{
    double[] tempArray = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        tempArray[i] = Math.Round(rand.NextDouble(), 3) + rand.Next(leftRange, rightRange);

    }
    return tempArray;
}
//Печать массива
void PrintArray(double[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}
//Разница между максимальным и минимальным элементами массива
double DiffMaxMin(double[] array, out double min, out double max)
{
    max = array[0];
    min = array[0];
    double diff = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
    }
    diff = max - min;
    return diff;
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

double[] array = FillArray(size[0], rang[0], rang[1]);
PrintArray(array);
double diff = DiffMaxMin(array, out double min, out double max);
System.Console.WriteLine($"Разница между {max} и {min} равна {diff}");