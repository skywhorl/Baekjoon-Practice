using System;
using System.Text;
// �Էµ� ������� �� ���� �� ����ϱ�
class Answer
{
    static void Main()
    {
        StringBuilder sums = new StringBuilder();
        while (true)
        {
            var read = Console.ReadLine();

            // ���� �Է��� �� ���� ��
            if (read == null)
                break;

            sums.Append($"{short.Parse(read.Split(' ')[0]) + short.Parse(read.Split(' ')[1])}\n");
        }
        Console.WriteLine(sums.ToString());
        sums.Clear();
    }
}