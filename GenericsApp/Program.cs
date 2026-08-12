namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> boxStr = new Box<string>("Hello World");
            boxStr.UpdateContent("Teaching c# is fun");
            Console.WriteLine(boxStr.GetContent());
        }
    }
}
