using System;
// ������ ������ 4�� ����̸鼭, 100�� ����� �ƴ� �� �Ǵ� 400�� ����� ���̴�.
class Answer
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine((year % 4 == 0) && (year % 100 != 0 || year % 400 == 0) ? 1 : 0);
    }
}