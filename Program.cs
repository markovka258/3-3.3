﻿using System;
internal class Program
    {

        static void Main()
        {
            Array1 one = new Array1();

            Array2 two = new Array2();

            Array3 three = new Array3();
  
            IArray[] arrays = new IArray[3]
            {
                one, two, three
            };

            foreach(IArray item in arrays)
            {
                Console.WriteLine($"Элементы массива {item.GetType()}");
                item.Print();
                Console.WriteLine($"Среднее значение {item.GetType()} массива {item.GetAverage()}");
            }

            Console.WriteLine($"Массив {one.GetType()} с удаленными дубликатами");
            one.Print();

            Console.WriteLine("Массив 2 змейкой:");
            two.InReverse();

            foreach (double i in three.GetAverages())
            {
                Console.WriteLine($"Среднее для вложенного в array3 массива: {i}");
            }

            IPrinter daysOfWeekPrinter = new DaysOfWeekPrinter();
            daysOfWeekPrinter.Print();

        }
    }