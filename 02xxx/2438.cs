using System;
// N���� �õ��� N��° �ٿ� N�� �� ���
class Answer
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 1; i <= T; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}