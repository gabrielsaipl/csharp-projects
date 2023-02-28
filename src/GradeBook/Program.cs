using System;

namespace GradeBook // Note: actual namespace depends on the project name.
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Book grades = new Book();
            grades.AddGrade(35.3);
            grades.AddGrade(85.4);
            grades.AddGrade(35.31);
            if (grades != null){
               var stats = grades.GetStatistics();
               Console.WriteLine($"lowest grade: {stats.Low}, highest grade ${stats.High}, average: ${stats.average:N1}");
            }
            
        }
    }


}