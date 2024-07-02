using System;
// A+B 출력
class Answer
{
    static void Main()
    {
        string read = Console.ReadLine();
        Console.WriteLine(int.Parse(read.Split(' ')[0]) + int.Parse(read.Split(' ')[1]));
    }
}