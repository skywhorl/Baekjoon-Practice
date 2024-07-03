using System;
// Quadrant(»çºÐ¸é)
class Answer
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (x == (UInt32)x && y == (UInt32)y)
            Console.WriteLine("1");
        else if (x != (UInt32)x && y == (UInt32)y)
            Console.WriteLine("2");
        else if (x != (UInt32)x && y != (UInt32)y)
            Console.WriteLine("3");
        else Console.WriteLine("4");
    }
}