using System;
// �ֻ����� ���� ���� ���ü��� ����� �� �޴´�, �� �ٸ��� ���� ���� ���� �����Ѵ�
class Answer
{
    static void Main()
    {
        string dice = Console.ReadLine();
        int num1 = int.Parse(dice.Split(' ')[0]);
        int num2 = int.Parse(dice.Split(' ')[1]);
        int num3 = int.Parse(dice.Split(' ')[2]);

        // �� ���� ��
        if (num1 == num2 && num2 == num3)
            Console.WriteLine(10_000 + (num1 * 1_000));
        // �� �ٸ� ��
        else if (num1 != num2 && num2 != num3 && num3 != num1)
        {
            num1 = Math.Max(num1, num2);
            num1 = Math.Max(num1, num3);

            Console.WriteLine(num1 * 100);
        }

        // �Ϻθ� ���� ��
        else
        {
            if (num1 == num2)
                Console.WriteLine(1000 + (num1 * 100));
            else if (num1 == num3)
                Console.WriteLine(1000 + (num1 * 100));
            else
                Console.WriteLine(1000 + (num2 * 100));
        }
    }
}