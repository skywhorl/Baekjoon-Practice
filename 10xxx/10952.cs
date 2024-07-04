using System;
using System.Text;
// 마지막 0 0 이 입력될 때까지 두 수의 합 출력하기
class Answer
{
    static void Main()
    {
        StringBuilder nums = new StringBuilder();

        while (true)
        {
            var read = Console.ReadLine().Split(' ');
            int A = int.Parse(read[0]);
            int B = int.Parse(read[1]);

            if (A == 0 && B == 0)
                break;

            nums.Append($"{A + B}\n");
        }
        Console.WriteLine(nums.ToString());
        nums.Clear();
    }
}