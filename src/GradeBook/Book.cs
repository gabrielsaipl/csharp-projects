namespace GradeBook
{
   public class Book
    {
        public Book(){
            grades = new List<double>();
        }
        public void AddGrade(double grade){
            grades.Add(grade);
        }
        public void ShowStatistics(){

            var lowGrade = double.MaxValue;
            var highGrade = double.MinValue;
            var average = 0.0;
            foreach(var grade in grades){
                if (lowGrade > grade){
                    lowGrade = grade;
                }
                if (highGrade < grade){
                    highGrade = grade;
                }
                average += grade;
            }
            average /= grades.Count;

            Console.WriteLine($"lowest grade: {lowGrade}, highest grade ${highGrade}, average: ${average:N1}");


        }
        List<double> grades = new List<double>();
    }
}

// Path: src/GradeBook/Program.cs