using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GradeBook
{
    public class DiskBook : Book, IBook
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);

                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
             }
        }

        public override Statistics GetStatistics()
        {

        }
    }
}
