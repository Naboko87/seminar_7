// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, ex_52!");

Console.WriteLine();

int[,] array = NaityZnachenie(2,2);
PrintArray(array);
PoiskZnachenia();

Console.WriteLine();


void PoiskZnachenia()
{
    double cols1 = 0;
    int colElementCols1 = 0;
    double cols2 = 0;
    int colElementCols2 = 0;
    

    for (int i = 0;  i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0)
            {
              int znach = array[i,j];  
              cols1 = cols1 + znach;
              colElementCols1 = colElementCols1 + 1;
            }
            if (j == 1)
            {
              int znach = array[i,j];  
              cols2 = cols2 + znach;
              colElementCols2 = colElementCols2 + 1;
            }
                
        }

    cols1 = cols1/colElementCols1;  
    cols2 = cols2/colElementCols2;  
    }
    
    Console.WriteLine();
    Console.WriteLine("cols1:" + " " + Math.Round(cols1, 2));
    Console.WriteLine();
    Console.WriteLine("cols2:" + " " + Math.Round(cols2, 2));
}



int[,] NaityZnachenie(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    var random = new Random();

    for (int i = 0;  i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10);
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
              Console.Write(array[i, j] + "\t");
         }
        Console.WriteLine();
    }
}