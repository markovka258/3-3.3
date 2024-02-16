using System;

public class DaysOfWeekPrinter : IPrinter
{
    public void Print()
    {
        string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        foreach (var day in daysOfWeek)
        {
            Console.WriteLine(day);
        }
    }
}