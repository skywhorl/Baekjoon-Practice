using System;
// �� ������ ��
class Answer
{
    static void Main()
    {
        string read = Console.ReadLine();
        double answer = 0;
        for (int i = 0; i < 3; i++)
        {
            answer += double.Parse(read.Split(' ')[i]);
        }
        Console.WriteLine(answer);
    }
}