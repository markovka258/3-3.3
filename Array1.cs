using System;

sealed class Array1 : ArrayBase
{
    private Random random;
    private int[] array;

    public Array1() : base()
    {        

    }

    protected void InitializeArray()
    {
       
    }
    

    protected override void ArrUsInp()
    {
        Console.Write("Enter the length of the array1: ");
        string lengthInput = Console.ReadLine();

        int.TryParse(lengthInput, out int length);
        
        array = new int[length];

        Console.WriteLine($"Введите {array.Length} чисел:");

        for (int i = 0; i < array.Length; i++)
        {
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int value))
            {
                array[i] = value;
            }
            else
            {
                throw new ArgumentException("Invalid user input");
            }
        }
    }

    protected override void ArrRand()
    {
        random = new Random();
        
        Console.Write("Enter the length of the array1: ");
        string lengthInput = Console.ReadLine();

        int.TryParse(lengthInput, out int length);
        
        array = new int[length];
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }
    }

    public void RemoveDuplicates()
    {
        int[] a = array;
        int count = 0;

        for (int i = 0; i < a.Length; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < i; j++)
            {
                if (a[i] == a[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                count++;
            }
        }

        int[] result = new int[count];
        count = 0;

        for (int i = 0; i < a.Length; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < i; j++)
            {
                if (a[i] == a[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                result[count] = a[i];
                count++;
            }
        }

        array = result;
    }

    public override double GetAverage()
    {
        int sum = 0;

        foreach (int value in array)
        {
            sum += value;
        }

        return (double)sum / array.Length;
    }

    public override void Print()
    {
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }

}