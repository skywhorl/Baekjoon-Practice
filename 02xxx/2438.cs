using System;
// N번의 시도로 N번째 줄에 N번 별 찍기
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