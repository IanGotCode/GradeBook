﻿using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 34.1;
            var y = 10.3;
            var result = x + y;
            
            Console.WriteLine(result);

            if(args.Length > 0) {
                Console.WriteLine($"Hello, {args[0]}!");
            } else {
                Console.WriteLine("Hello, can you tell me your name?");
            }
        }
    }
}
