namespace GradeBook
{

    public delegate void GradeAddedDelegate(object sender, EventArgs args);


   public class Book
    {
        public Book(string name){
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade){
            double r = 2.2;
            if (grade <= 100 && grade >= 0){
                grades.Add(grade);
                if (GradeAdded != null){
                    GradeAdded(this, new EventArgs());
                }
            }
            else throw new ArgumentException("Invalid number");
        }

        public event GradeAddedDelegate GradeAdded;
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
        public string Name;
    }
    
}

// Path: src/GradeBook/Program.cs