// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
int i = 0;
int summa = 0;
CreatArray(number);
PrintArray(number);

for(i = 1; i < number.Length; i+=2)
{
    summa = summa + number[i];
    Console.Write(number[i] + " ");
}
Console.WriteLine();
Console.WriteLine($"Сумма равна: {summa}");


void CreatArray(int [] number)
{
    
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(1, 10);
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