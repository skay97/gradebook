using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }


        public void AddGrade(double grade)
        {
            grades.Add(grade);
            Console.WriteLine();
        }
        public void ShowStatistics()
        {
            double result = 0.00;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                if (highGrade < grade)
                {
                    highGrade = grade;
                }

                if (lowGrade > grade)
                {
                    lowGrade = grade;
                }
                result += grade;
            };

            Console.WriteLine($"this is avg grade: {result / grades.Count:N1}");
            Console.WriteLine($"this is the highestGrade: {highGrade}");
            Console.WriteLine($"this is the lowestGrade: {lowGrade}");
        }
    }
}
