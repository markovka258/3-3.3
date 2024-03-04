using System;

sealed class Array1 : ArrayBase
{
    private Random random;
    private int[] _array;

    public Array1()
    {        
        random = new Random();
        
        InitializeArray();
    }

    protected override void InitializeArray()
    {
       
    }
    

    protected override void ArrUsInp()
    {
        Console.Write("Enter the length of the array1: ");
        string lengthInput = Console.ReadLine();

        int.TryParse(lengthInput, out int length);
        
        _array = new int[length];

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

    protected override void ArrRand()
    {
        Console.Write("Enter the length of the array1: ");
        string lengthInput = Console.ReadLine();

        int.TryParse(lengthInput, out int length);
        
        _array = new int[length];
        
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