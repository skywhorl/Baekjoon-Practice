using System;
// 1���� n������ ��
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