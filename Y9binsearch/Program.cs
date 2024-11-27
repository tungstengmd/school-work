namespace y9binsearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 0;
            Boolean myBool = true;
            Decimal myDec = 0.1M;
            char myChar = '\a';
            if (myDec == 0.1M)
            {
                Console.WriteLine("true");
            }
            if (myBool)
            {
                Console.WriteLine("true");
            }
            if(myInt == 0)
            {
                Console.WriteLine("true");
            }
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
            Console.WriteLine(myChar);
        }
    }
}