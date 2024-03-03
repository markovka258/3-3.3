using System;

sealed class Array3 : ArrayBase
{
    private Random random;
    private int[][] array;

    public Array3()
    {
        random = new Random();

        InitializeArray();
    }

    protected override void InitializeArray()
    {
        Console.Write("Enter 'true' for user input or 'false' for random input: ");
        string userInput = Console.ReadLine();

        bool.TryParse(userInput, out bool isUserInput);
        
        if (isUserInput)
        {
            ArrUsInp();
        }
        else
        {
            ArrRand();
        }
    }

    protected override void ArrUsInp()
    {
        Console.Write("Enter the number of rows for the array3: ");
        string rowsInput = Console.ReadLine();

        int.TryParse(rowsInput, out int rows);
        
        array = new int[rows][];

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

    protected override void ArrRand()
    {
        Console.Write("Enter the number of rows for the array3: ");
        string rowsInput = Console.ReadLine();

        int.TryParse(rowsInput, out int rows);
        
        array = new int[rows][];
        
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

