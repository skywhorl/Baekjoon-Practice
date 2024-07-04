using System;
using System.Text;
// T¹øÀÇ A+B ver.better_pretty
class Answer
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        StringBuilder answers = new StringBuilder();

        for (int i = 0; i < T; i++)
        {
            var read = Console.ReadLine().Split(' ');
            int A = int.Parse(read[0]);
            int B = int.Parse(read[1]);

            answers.Append($"Case #{i + 1}: {A} + {B} = {A + B}\n");
        }
        Console.WriteLine(answers.ToString());

        answers.Clear();
    }
}