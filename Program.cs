﻿using System;
internal class Program
{
    static void Main()
    {
        Array1 one = new Array1();
        Array2 two = new Array2();
        Array3 three = new Array3();
        DaysOfWeekPrinter daysOfWeekPrinter = new DaysOfWeekPrinter();

        IPrinter[] printers = new IPrinter[]
        {
            one, two, three, daysOfWeekPrinter
        };

        foreach (IPrinter printer in printers)
        {
            Console.WriteLine($"Элементы массива {printer.GetType()}:");
            printer.Print();

            if (printer is IArray array)
            {
                Console.WriteLine($"Среднее значение {array.GetType()} массива {array.GetAverage()}");
                
                if (array is Array1 array1)
                {
                    Console.WriteLine($"Массив {array1.GetType()} с удаленными дубликатами");
                    array.Print();
                }

                if (array is Array2 array2)
                {
                    Console.WriteLine("Массив 2 змейкой:");
                    array2.InReverse();
                }

                if (array is Array3 array3)
                {              
                    foreach (double i in three.GetAverages())
                    {
                        Console.WriteLine($"Среднее для вложенного в array3 массива: {i}");
                    }
                }
            }
        }
    }
}