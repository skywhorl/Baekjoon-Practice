using System;
// A*B ���
class Answer
{
    static void Main()
    {
        string read = Console.ReadLine();
        Console.WriteLine(int.Parse(read.Split(' ')[0]) * int.Parse(read.Split(' ')[1]));
    }
}