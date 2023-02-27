namespace GradeBook.tests;

public class BookTests 
{
    [Fact]
    public void Test1()
    {  
        //arrange
        Book grades = new Book();
        grades.AddGrade(35.3);
        grades.AddGrade(85.4);
        grades.AddGrade(35.31);
        //act
        if (grades != null){
            grades.ShowStatistics();
        }
        //assert
    }
}