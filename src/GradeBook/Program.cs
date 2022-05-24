using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Salman's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(101);
            var stats = book.GetStatistics();

            Console.WriteLine($"this is avg grade: {stats.Average:N1}");
            Console.WriteLine($"this is the highestGrade: {stats.High}");
            Console.WriteLine($"this is the lowestGrade: {stats.Low}");
        }
    }
}
