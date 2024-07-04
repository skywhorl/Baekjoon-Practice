using System;
using System.Text;
// T¹øÀÇ A+B ver.pretty
class Answer
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        StringBuilder answers = new StringBuilder();

        for (int i = 0; i < T; i++)
        {
            var read = Console.ReadLine().Split(' ');
            answers.Append($"Case #{i + 1}: {int.Parse(read[0]) + int.Parse(read[1])}\n");
        }
        Console.WriteLine(answers.ToString());

        answers.Clear();
    }
}