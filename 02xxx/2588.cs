using System;
// °ö¼À ¿¬»ê ¿ø¸®
class Answer
{
    static void Main()
    {
        int mulNum1 = int.Parse(Console.ReadLine());
        int mulNum2 = int.Parse(Console.ReadLine());

        Console.WriteLine(mulNum1 * (mulNum2 % 10));
        Console.WriteLine(mulNum1 * (mulNum2 % 100 / 10));
        Console.WriteLine(mulNum1 * (mulNum2 / 100));
        Console.WriteLine(mulNum1 * mulNum2);
    }
}