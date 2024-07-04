using System;
using System.Text;
// 입력된 내용들의 두 수의 합 출력하기
class Answer
{
    static void Main()
    {
        StringBuilder sums = new StringBuilder();
        while (true)
        {
            var read = Console.ReadLine();

            // 더는 입력을 안 받을 땐
            if (read == null)
                break;

            sums.Append($"{short.Parse(read.Split(' ')[0]) + short.Parse(read.Split(' ')[1])}\n");
        }
        Console.WriteLine(sums.ToString());
        sums.Clear();
    }
}