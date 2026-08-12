namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productOne = new Product();
            var productTwo = new Product();

            var result = Comparer.AreEqual(productOne, productTwo);
            Console.WriteLine(result);
            
            Console.ReadKey();
        }
    }

    public class Product() 
    {
        
    }


}
