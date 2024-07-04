using System;
// ºóÄ­ Æ÷ÇÔ º° ±×¸®±â
class Answer
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N; j++)
                Console.Write(N - i >= j ? " " : "*");

            Console.WriteLine("");
        }
    }
}