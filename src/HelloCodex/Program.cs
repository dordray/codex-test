using System;
using System.Collections.Generic;

namespace HelloCodex;

internal static class Program
{
    public static void Main(string[] args)
    {
        var upper = false;
        var outputs = new List<string>();

        foreach (var arg in args)
        {
            if (arg == "--upper")
            {
                upper = true;
                continue;
            }

            outputs.Add(arg);
        }

        foreach (var output in outputs)
        {
            Console.WriteLine(upper ? output.ToUpperInvariant() : output);
        }
    }
}
