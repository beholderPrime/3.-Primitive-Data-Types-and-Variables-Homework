﻿using System;

/*Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the '\u00XX' syntax, and then print it. 
 * Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. 
 * */

class Problem3VariableHexadecimal
{
    static void Main()
    {
        int a = 42;
        Console.WriteLine("Hexadecimal value is: {0:X}", a);
        char b  = '\u002A';
        Console.WriteLine("       The symbol is: {0}", b);
      
    }
}
