using System;
public abstract class ArrayBase : IArray, IPrinter
{
    public abstract void InitializeArray();

    public abstract void ArrUsInp();

    public abstract void ArrRand();

    public abstract double GetAverage();

    public abstract void Print();
}
