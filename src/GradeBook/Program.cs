using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            var book = new InMemoryBook("Salman's Grade Book");

            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The catergory is: {InMemoryBook.CATEGORY}");
            Console.WriteLine($"Average grade: {stats.Average:N1}");
            Console.WriteLine($"Highest Grade: {stats.High}");
            Console.WriteLine($"Lowest Grade: {stats.Low}");
            Console.WriteLine($"Average letter Grade: {stats.Letter}");
        }

        private static void EnterGrades(Book book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    Console.WriteLine("Thank you for inputting your grades.");
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                // Todo: implement finally logic
                finally
                {
                    Console.WriteLine("**");
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("a grade was added");
        }
    }
}
