using System;

public class ArrayUni
{
    static char[] myArray = { 'a', 'b', 'c', 'd', 'e' };
    public static void PrintABC()
    {
        for (int x = 0; x < 5; x++)
        {
            myArray[1] = 'z';
        }
        Console.WriteLine(myArray[1]);

    }
}
