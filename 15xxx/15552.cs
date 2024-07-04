using System;
using System.Text;
// N번의 A+B
class Answer
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        // List<int> 사용 시 시간초과
        StringBuilder answer = new StringBuilder();

        for (int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().Split(' ');
            var A = int.Parse(read[0]);
            var B = int.Parse(read[1]);

            answer.Append($"{A + B}\n");
        }
        Console.WriteLine(answer.ToString());
    }
}