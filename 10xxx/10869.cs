using System;
// 사칙연산
class Answer
{
    static void Main()
    {
        string read = Console.ReadLine();
        int a = int.Parse(read.Split(' ')[0]);
        int b = int.Parse(read.Split(' ')[1]);
        Console.WriteLine($"{a + b}\n{a - b}\n{a * b}\n{a / b}\n{a % b}");
    }
}