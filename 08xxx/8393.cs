using System;
// 1부터 n까지의 합
class Answer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        
        for(int i = 1; i <= n; i++)
            sum += i;
        Console.WriteLine(sum);
    }
}