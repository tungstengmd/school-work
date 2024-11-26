namespace y9binsearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string myString = Console.ReadLine();
            if (myString == "World")
            {
                Console.WriteLine("Hello, world!");
            }
            else if (myString == "Hello")
            {
                Console.WriteLine("Hey!");
            }
            else
            {
                Console.WriteLine("Hello, " + myString + "! Have a nice day!");
            }
        }
    }
}