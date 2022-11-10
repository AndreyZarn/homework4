// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



System.Console.WriteLine("Введите искомое число: ");
int f = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 0;
int count = 0;

void Rand ()
{
    a = new Random().Next(5,10);
    b = new Random().Next(5,10);
}


void RandFillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,101);
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

void FindNum (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] == f)
                {
                    count ++;
                    System.Console.WriteLine($"адрес числа {i},{j}");
                }             
            }
            
        }       
}

Rand();
int[,] array = new int[a,b];
RandFillArray(array);
PrintArray2(array);
FindNum(array);
if (count ==0 )
System.Console.WriteLine("Такого числа нет");