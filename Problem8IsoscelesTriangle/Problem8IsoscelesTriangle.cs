﻿using System;
/* 
Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©
  © ©
 ©   ©
© © © ©
Note that the © symbol may be displayed incorrectly at the console 
so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console. 
Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, 
regardless of how much effort you put to fix it.
*/

class Problem8IsoscelesTriangle
    {
    static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            char b = '\u00A9';
            Console.WriteLine("{0,5}\n{0,4}{0,3}\n{0,3}{0,5}\n{0,2}{0,2}{0,3}{0,2}", b);

        }
    }

