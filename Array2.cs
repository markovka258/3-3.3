using System;

sealed class Array2 : ArrayBase
{
    private Random random;
    private int[,] array;

    public Array2()
    {
        Console.Write("Enter the number of rows for the array2: ");
        string rowsInput = Console.ReadLine();

        Console.Write("Enter the number of columns for the array2: ");
        string columnsInput = Console.ReadLine();

        if (int.TryParse(rowsInput, out int rows) && int.TryParse(columnsInput, out int columns))
        {
            array = new int[rows, columns];
        }
        else
        {
            throw new ArgumentException("Invalid input for rows or columns");
        }

        InitializeArray();
    }

    public override void InitializeArray()
    {
        Console.Write("Enter 'true' for user input or 'false' for random input: ");
        string userInput = Console.ReadLine();

        if (bool.TryParse(userInput, out bool isUserInput))
        {
            random = new Random();

            if (isUserInput)
            {
                ArrUsInp();
            }
            else
            {
                ArrRand();
            }
        }
        else
        {
            throw new ArgumentException("Invalid input choice");
        }
    }

    public override void ArrUsInp()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"Enter value for element [{i+1},{j+1}]: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int value))
                {
                    array[i, j] = value;
                }
                else
                {
                    throw new ArgumentException("Invalid user input");
                }
            }
        }
    }

    public override void ArrRand()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(1, 101);
            }
        }
    }

    public override void RemoveDuplicates()
{
    int[,] a = array;
    int rows = a.GetLength(0);
    int columns = a.GetLength(1);

    int[,] result = new int[rows, columns];
    int count = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            bool isDuplicate = false;

            for (int k = 0; k < count; k++)
            {
                if (a[i, j] == result[k / columns, k % columns])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                result[count / columns, count % columns] = a[i, j];
                count++;
            }
        }
    }

    array = result;
}

    public override double GetAverage()
    {
        int sum = 0;
        int count = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
                count++;
            }
        }

        return (double)sum / count;
    }

    public override void Print()
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
