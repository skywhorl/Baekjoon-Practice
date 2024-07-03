using System;
// A시 B분에서 C분 경과했을 때
class Answer
{
    static void Main()
    {
        string read1 = Console.ReadLine();
        string read2 = Console.ReadLine();
        int A = int.Parse(read1.Split(' ')[0]);
        int B = int.Parse(read1.Split(' ')[1]);
        int C = int.Parse(read2);

        int countTime = C + B;

        A += countTime / 60;
        B = countTime % 60;

        if (A >= 24)
            A -= 24;

        Console.WriteLine($"{A} {B}");
    }
}