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
                item.RemoveDuplicates();
                Console.WriteLine($"Массив {item.GetType()} с удаленными дубликатами");
                item.Print();
            }

        
                IPrinter daysOfWeekPrinter = new DaysOfWeekPrinter();
                daysOfWeekPrinter.Print();

        }
    }