using System;
// 주어진 수들의 합
class Answer
{
    static void Main()
    {
        int calCount = int.Parse(Console.ReadLine());
        int[] results = new int[calCount];

        for (int i = 0; i < calCount; i++)
        {
            int cal = 0;
            var read = Console.ReadLine().Split(' ');

            for (int j = 0; j < read.Length; j++)
                cal += int.Parse(read[j]);

            results[i] = cal;
        }

        for (int i = 0; i < calCount; i++)
        {
            Console.WriteLine(results[i]);
        }
    }
}