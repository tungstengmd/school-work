namespace y9binsearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string myString = Console.ReadLine();
            Console.WriteLine("Hello, " + myString + "! Have a nice day!");
            if (myString == "World")
            {
                Console.WriteLine("Hello, world!");
            }
        }
    }
}