abstract class Book
{   
    protected String title;
    protected String author;
    
    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();
}
class MyBook : Book
{
    int price;

    public MyBook(string t, string a, int p) : base(t,a)
    {    
        price = p; 
    }
    public override void display (){
        Console.WriteLine("Title: {0}", title);
        Console.WriteLine("Author: {0}", author);
        Console.WriteLine("Price: {0}", price);
    }
}
