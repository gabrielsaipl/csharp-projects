namespace GradeBook.tests;

public delegate string WriteLogDelegate(string logMessage);

public class TypeTests 
{
    int count = 0;
    [Fact]
    public void WriteLogDelegateCanPointToAnotherMethod(){
        WriteLogDelegate log = ReturnMessage;
        log += ReturnMessage;
        log += IncrementCount;
        var result = log("Hello!");
        Assert.Equal(3,count);
    }

string IncrementCount(string message){
        count++;
        return message.ToLower();
    }

    string ReturnMessage(string message){
        count++;
        return message;
    }
        
/* [Fact]
    public void CsharpCanPassByReference()
    {  
        var book1 = GetBook("Book 1");
        GetBookSetName(out book1,"New Name");

        Assert.Equal("New Name",book1.Name);
    }

    private void GetBookSetName(out Book book, string name){
        book = new Book(name);
    }

    [Fact]
    public void CsharpCanPassByValue()
    {  
        var book1 = GetBook("Book 1");
        GetBookSetName(book1,"New Name");

        Assert.Equal("Book 1",book1.Name);
    }


[Fact]
    public void CanSetNameFromReference()
    {  
        var book1 = GetBook("Book 1");
        SetName(book1,"New Name");

        Assert.Equal("New Name",book1.Name);
    }

    private void SetName(Book book, string name){
            book.Name = name;
    }
    

    [Fact]
    public void GetBookReturnsDifferentObjects()
    {  
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        Assert.Equal("Book 2",book2.Name);
        Assert.Equal("Book 1",book1.Name);
        Assert.NotSame(book1,book2);
    }

    [Fact]
    public void TwoVariablesCanReferenceSameObject()
    {  
        var book1 = GetBook("Book 1");
        var book2 = book1;

        Assert.Same(book1, book2);
        Assert.True(Object.ReferenceEquals(book1,book2));
    }
    Book GetBook(string name){
        return new Book(name);
    } */
}