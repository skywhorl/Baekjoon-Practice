using System;
// 연산 비교
class Answer
{
    static void Main()
    {
        int[] nums = new int[3];
        string read = Console.ReadLine();

        int A = int.Parse(read.Split(' ')[0]);
        int B = int.Parse(read.Split(' ')[1]);
        int C = int.Parse(read.Split(' ')[2]);

        Console.WriteLine((A + B) % C);
        Console.WriteLine(((A % C) + (B % C)) % C);
        Console.WriteLine((A * B) % C);
        Console.WriteLine(((A % C) * (B % C)) % C);
    }
}
