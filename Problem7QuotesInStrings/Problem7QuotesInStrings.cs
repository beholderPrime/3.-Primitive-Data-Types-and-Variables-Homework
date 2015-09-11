using System;

class Problem7QuotesInStrings
{
    /*Declare two string variables and assign them with following value:
    The "use" of quotations causes difficulties.
    Do the above in two different ways: with and without using quoted strings. 
    Print the variables to ensure that their value was correctly defined.
    */

    static void Main(string[] args)
    {
        string q1 = "The \"use\" of quotations causes difficulties.";
        string q2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(q1 + Environment.NewLine + q2);
    }
}
