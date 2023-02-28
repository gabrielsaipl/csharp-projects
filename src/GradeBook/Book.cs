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
        public Statistics GetStatistics(){

            var result = new Statistics();
            result.average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            foreach(var grade in grades){
                if (result.Low > grade){
                    result.Low = grade;
                }
                if (result.High < grade){
                    result.High = grade;
                }
                result.average += grade;
            }
            result.average /= grades.Count;

            return result;
        }
        List<double> grades = new List<double>();
    }
}

// Path: src/GradeBook/Program.cs