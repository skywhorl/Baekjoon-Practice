using System;
// 윤년은 연도가 4의 배수이면서, 100의 배수가 아닐 때 또는 400의 배수일 때이다.
class Answer
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine((year % 4 == 0) && (year % 100 != 0 || year % 400 == 0) ? 1 : 0);
    }
}