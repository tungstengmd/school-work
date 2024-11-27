namespace y9binsearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 0;
            bool myBool = true;
            decimal myDec = 0.1M;
            char myChar = '\a';
            double myDouble = 2;
            string myStr = "hey cutie :3";
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
            Console.Write("What's your name?");
            var myString = Console.ReadLine();
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
            Console.Write(myChar);
            Console.Write(myBool);
            Console.Write(myDouble);
            Console.Write(myInt);
            Console.WriteLine(myDec);
            Console.Write(myStr);
        }
    }
}