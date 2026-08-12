namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Box<int> boxInt = new Box<int>();
            Box<Book> bookBox = new Box<Book>();
            
            Console.ReadKey();
        }
    }

    public class Book
    {

    }
}
