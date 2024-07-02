using System;
// A/B 출력
class Answer
{
    static void Main()
    {
        string read = Console.ReadLine();
        // 소숫점 단위 출력으로 인해 double 자료형 사용
        Console.WriteLine(double.Parse(read.Split(' ')[0]) / double.Parse(read.Split(' ')[1]));
    }
}