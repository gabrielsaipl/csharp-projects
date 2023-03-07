using System;

namespace GradeBook // Note: actual namespace depends on the project name.
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Book grades = new Book("MyBook");
            grades.GradeAdded += OnGradeAdded;
            grades.GradeAdded += OnGradeAdded;
            grades.GradeAdded -= OnGradeAdded;
            grades.GradeAdded += OnGradeAdded;

            string input;
            do{

                input = Console.ReadLine();
                if (input == "q"){
                    continue;
                }
                else if (input != null){
                    try{
                    grades.AddGrade(Double.Parse(input));
                    }catch (Exception e){
                        Console.WriteLine(e.Message);
                    }               
                }
                
            } while (input != "q");
            if (grades != null){
               var stats = grades.GetStatistics();
               Console.WriteLine($"lowest grade: {stats.Low}, highest grade {stats.High}, average: {stats.average:N1}");
            }

            static void OnGradeAdded(object sender, EventArgs e){
                Console.WriteLine("Grade Added");
            }
            
        }
    }


}