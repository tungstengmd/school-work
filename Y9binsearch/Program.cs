using System.Numerics;
int[] ints = [1, 3, 6, 8, 9, 11, 12, 16];
int hpp = ints.Length;
int lpp = 0;
int mp = (hpp + lpp) / 2;
Console.Write("Enter search key: ");
int key = Convert.ToInt32(value: Console.ReadLine());
while (key != ints[mp])
{
    if (key > ints[mp])
    {
        lpp = mp + 1;
        mp = (hpp + lpp) / 2;
    }
    else if (key < ints[mp])
    {
        hpp = mp - 1;
        mp = (hpp + lpp) / 2;
    }
    else if (lpp > hpp)
    {
        Console.WriteLine("Not found. :(");
    }
}
if (key == ints[mp])
{
    Console.WriteLine("Found!");
}
