using System;
// 영수증 확인
// X : 총 가격, N : 종류의 수량
class Answer
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int price = 0;

        for (int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().Split(' ');

            price += (int.Parse(read[0]) * int.Parse(read[1]));
        }
        Console.WriteLine(X == price ? "Yes" : "No");
    }
}