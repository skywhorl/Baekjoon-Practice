using System;
// �� �� ��
class Answer
{
    static void Main()
    {
        string read = Console.ReadLine();
        int a = int.Parse(read.Split(' ')[0]);
        int b = int.Parse(read.Split(' ')[1]);

        if (a < b)
            Console.WriteLine("<");
        else if (a > b)
            Console.WriteLine(">");
        else if (a == b)
            Console.WriteLine("=");
    }
}