namespace y9binsearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 3, 6, 8, 9, 11, 12, 16 };
            var hpp = ints.Length;
            var lpp = 0;
            int mp = (hpp + lpp) / 2;
            Console.Write("Enter search key: ");
            int key = Convert.ToInt32(value: Console.ReadLine());
            if (key > ints[mp])
            {
                lpp = mp + 1;
                mp = (int)Decimal.Round((hpp + lpp) / 2);
            }
            else if (key < ints[mp])
            {
                hpp = mp - 1;
                mp = (hpp + lpp) / 2;
            }
            else if (key == ints[mp])
            {
                Console.WriteLine("Found!");
            }
            else {
                Console.WriteLine("Not found. :(");
            }
        }
    }
}