using System;
using System.Text;
// ������ 0 0 �� �Էµ� ������ �� ���� �� ����ϱ�
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