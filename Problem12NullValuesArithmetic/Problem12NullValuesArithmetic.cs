using System;
/*Create a program that assigns null values to an integer and to a double variable. 
Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.
 */
    class Problem12NullValuesArithmetic
    {
        static void Main()
        {
            int? NI = null;
            double? NF = null;
            Console.WriteLine("Integer: " + NI);
            Console.WriteLine("Double: " + NF);
            NI += 3;
            NF += 4;
            Console.WriteLine("Integer: " + NI);
            Console.WriteLine("Double: " + NF);
            NI = 6;
            NF = 8;
            Console.WriteLine("Integer: " + NI);
            Console.WriteLine("Double: " + NF);
            NI = NI + 6;
            NF = NF + 8;
            Console.WriteLine("Integer: " + NI);
            Console.WriteLine("Double: " + NF);
            NI +=6;
            NF +=8;
            Console.WriteLine("Integer: " + NI);
            Console.WriteLine("Double: " + NF);

        }
    }

