using System;

sealed class Array3 : ArrayBase
{
    private Random random;
    private int[][] array;

    public Array3()
    {
        Console.Write("Enter the number of rows for the array3: ");
        string rowsInput = Console.ReadLine();

        if (int.TryParse(rowsInput, out int rows))
        {
            array = new int[rows][];
        }
        else
        {
            throw new ArgumentException("Invalid input for rows");
        }

        InitializeArray();
    }

    public override void InitializeArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Enter the number of columns for row {i + 1}: ");
            string columnsInput = Console.ReadLine();

            if (int.TryParse(columnsInput, out int columns))
            {
                array[i] = new int[columns];
            }
            else
            {
                throw new ArgumentException($"Invalid input for columns in row {i + 1}");
            }
        }

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
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write($"Enter value for element [{i + 1},{j + 1}]: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int value))
                {
                    array[i][j] = value;
                }
                else
                {
                    throw new ArgumentException($"Invalid user input for element [{i + 1},{j + 1}]");
                }
            }
        }
    }

    public override void ArrRand()
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = random.Next(1, 101);
            }
        }
    }

    public double[] GetAverages()
    {
        int[][] array3 = array;
        double[] averages = new double[array3.Length];

        for (int i = 0; i < array3.Length; i++)
        {
            int sum = 0;

            for (int j = 0; j < array3[i].Length; j++)
            {
                sum += array3[i][j];
            }

            averages[i] = (double)sum / (double)array3[i].Length;
        }

        return averages;
    }

    public override double GetAverage()
    {
        double sum = 0;
        double count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                sum += array[i][j];
                count++;
            }
        }

        return sum / count;
    }

    public override void Print()
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}

