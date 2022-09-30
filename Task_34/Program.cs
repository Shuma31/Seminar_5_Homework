//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
int count = 0;
int i = 0;
ThreeDigitArray(number);
PrintArray(number);

for(i = 0; i < number.Length; i++)
if (number[i] % 2 == 0)
count++;
Console.WriteLine($"Колличество чётных чисел в массиве = {count}");

void ThreeDigitArray(int [] number)
{
    
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] arrayCreat)
{
    Console.Write("Массив: [");
    for (int i = 0; i < arrayCreat.Length - 1; i++)
    {
        Console.Write(arrayCreat[i] + ", ");
    }
    Console.Write(arrayCreat[arrayCreat.Length - 1] + "]");
    Console.WriteLine();
}