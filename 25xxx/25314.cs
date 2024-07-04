using System;
// N 바이트 자료형 이름 출력
class Answer
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string print = "";

        for (int i = 0; i < N / 4; i++)
        {
            print += "long ";
        }
        Console.WriteLine(print + "int");
    }
}