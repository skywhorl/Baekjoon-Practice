using System;
// A/B ���
class Answer
{
    static void Main()
    {
        string read = Console.ReadLine();
        // �Ҽ��� ���� ������� ���� double �ڷ��� ���
        Console.WriteLine(double.Parse(read.Split(' ')[0]) / double.Parse(read.Split(' ')[1]));
    }
}