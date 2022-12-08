// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, ex_50");

Console.WriteLine("Write number");
int znachenie = Convert.ToInt32(Console.ReadLine());

int[,] array = NaityZnachenie(3,4);
PrintArray(array);
PoiskZnachenia();

Console.WriteLine();


void PoiskZnachenia()
{
    bool found = false;
    for (int i = 0;  i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
                if (array[i,j] != znachenie)
                {
                    found = false;
                } else {
                    found = true;
                }
        }
    }
    if(!found) {
        Console.WriteLine("ne naideno znachenie");
    }
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