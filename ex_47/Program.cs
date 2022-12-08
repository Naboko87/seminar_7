// See https://aka.ms/new-console-template for more information
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Hello, ex_47!");

double[,] array = GetArrayRandom(3,4);
PrintArray(array);

double[,] GetArrayRandom(int rows, int cols)
{
    double [,] array = new double[rows, cols];
    Random random = new Random();
    double minRandom = -10;
    double maxRandom = 10;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //array[i, j] = random.Next(10);
            array[i, j] = random.NextDouble() * (maxRandom - minRandom) + minRandom; 
        }
    }
    return array;
}

void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
              Console.Write(Math.Round( array[i, j], 1) + "\t");
         }
        Console.WriteLine();
    }
}
