// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] number = new double[size];
double minElement = Int32.MaxValue;
double maxElement = Int32.MinValue;
int i = 0;
CreatArray(number);
PrintArray(number);


for (i = 0; i < number.Length; i++)
{
    if (number[i] < minElement) minElement = number[i];
    else if (number[i] > maxElement) maxElement = number[i];
}
Console.WriteLine($"Минимальное значение = {minElement}");
Console.WriteLine($"Максимальное значение = {maxElement}");
Console.WriteLine($"Разница = {maxElement - minElement}");


void CreatArray(double [] number)
{
    
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}

void PrintArray(double[] arrayCreat)
{
    Console.Write("Массив: [");
    for (int i = 0; i < arrayCreat.Length - 1; i++)
    {
        Console.Write(arrayCreat[i] + "; ");
    }
    Console.Write(arrayCreat[arrayCreat.Length - 1] + "]");
    Console.WriteLine();
}