using System;

namespace GradeBook // Note: actual namespace depends on the project name.
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Book grades = new Book("MyBook");
            string input;
            do{

                input = Console.ReadLine();
                if (input == "q"){
                    continue;
                }
                else if (input != null){
                    grades.AddGrade(Double.Parse(input));                 
                }
            } while (input != "q");
            if (grades != null){
               var stats = grades.GetStatistics();
               Console.WriteLine($"lowest grade: {stats.Low}, highest grade {stats.High}, average: {stats.average:N1}");
            }
            
        }
    }


}