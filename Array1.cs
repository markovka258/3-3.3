using System;

sealed class Array1 : ArrayBase
{
    private Random random;
    private int[] _array;

    public Array1()
    {
        Console.Write("Enter the length of the array1: ");
        string lengthInput = Console.ReadLine();

        if (int.TryParse(lengthInput, out int length))
        {
            _array = new int[length];
        }
        else
        {
            throw new ArgumentException("Invalid length input");
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
        Console.WriteLine($"Введите {_array.Length} чисел:");

        for (int i = 0; i < _array.Length; i++)
        {
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int value))
            {
                _array[i] = value;
            }
            else
            {
                throw new ArgumentException("Invalid user input");
            }
        }
    }

    public override void ArrRand()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            _array[i] = random.Next(1, 101);
        }
    }

    public void RemoveDuplicates()
    {
        int[] a = _array;
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

        _array = result;
    }

    public override double GetAverage()
    {
        int sum = 0;

        foreach (int value in _array)
        {
            sum += value;
        }

        return (double)sum / _array.Length;
    }

    public override void Print()
    {
        Console.WriteLine(string.Join(" ", _array));
    }

}