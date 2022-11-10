// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int a = 0;
int b = 0;
double sum = 0;

void Rand ()
{
    a = new Random().Next(4,5);
    b = new Random().Next(3,4);
}


void RandFillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,5);
        }
    }
}
void PrintArray2 (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void srarf (int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = array[j,i]+sum;
        
        }
        
        System.Console.WriteLine();
        System.Console.WriteLine($"среднее арифметическое = {sum/array.GetLength(0)}");
        sum = 0;
    }

}
Rand();
int[,] array = new int[a,b];
RandFillArray(array);
PrintArray2(array);
srarf(array);