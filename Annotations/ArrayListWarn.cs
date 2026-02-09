using System;
using System.Collections;

public class LegacyArrayList
{
    public static void Execute()
    {
        #pragma warning disable
        ArrayList list = new ArrayList { 10, "Hello" };
        #pragma warning restore

        Console.WriteLine(list[0]);
        Console.WriteLine(list[1]);
    }
}
