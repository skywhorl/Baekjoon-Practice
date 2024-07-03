using System;
// 주사위의 같은 눈이 나올수록 상금을 더 받는다, 다 다르면 가장 높은 수로 정산한다
class Answer
{
    static void Main()
    {
        string dice = Console.ReadLine();
        int num1 = int.Parse(dice.Split(' ')[0]);
        int num2 = int.Parse(dice.Split(' ')[1]);
        int num3 = int.Parse(dice.Split(' ')[2]);

        // 다 같을 때
        if (num1 == num2 && num2 == num3)
            Console.WriteLine(10_000 + (num1 * 1_000));
        // 다 다를 때
        else if (num1 != num2 && num2 != num3 && num3 != num1)
        {
            num1 = Math.Max(num1, num2);
            num1 = Math.Max(num1, num3);

            Console.WriteLine(num1 * 100);
        }

        // 일부만 같을 때
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