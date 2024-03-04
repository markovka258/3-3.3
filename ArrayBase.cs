using System;
public abstract class ArrayBase : IArray, IPrinter
{
    protected virtual void InitializeArray()
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

    protected abstract void ArrUsInp();

    protected abstract void ArrRand();

    public abstract double GetAverage();

    public abstract void Print();
}
