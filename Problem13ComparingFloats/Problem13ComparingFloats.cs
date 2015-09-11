using System;
/*
Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. 
Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. Examples:
Number a	Number b	Equal (with precision eps=0.000001)	Explanation
5.3	6.01	false	The difference of 0.71 is too big (> eps)
5.00000001	5.00000003	true	The difference 0.00000002 < eps
5.00000005	5.00000001	true	The difference 0.00000004 < eps
-0.0000007	0.00000007	true	The difference 0.00000077 < eps
-4.999999	-4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different.
4.999999	4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different.
*/
    class Problem13ComparingFloats
    {
        static void Main(string[] args)
        {
            {
                //This is the input.
                float F1 = 5.3f;
                float F2 = 6.01f;
                double S1 = 5.00000001;
                double S2 = 5.00000003;
                double T1 = 0.0000007;
                double T2 = 0.00000007;
                float Fo1 = -4.999999f;
                float Fo2 = -4.999998f;

                //This is the output
                Console.WriteLine("First pair: {0} and {1}\nSecond pair: {2} and {3}\nThird pair: {4} and {5}\nFourth pair: {6} and {7}",
                    F1, F2, S1, S2, T1, T2, Fo1, Fo2);

                decimal F1D = (decimal)F1;
                decimal F2D = (decimal)F2;
                decimal S1D = (decimal)S1;
                decimal S2D = (decimal)S2;
                decimal T1D = (decimal)T1;
                decimal T2D = (decimal)T2;
                decimal Fo1D = (decimal)Fo1;
                decimal Fo2D = (decimal)Fo2;

          
/*
             bool equal = ((Math.Round(F1D, 6, MidpointRounding.ToEven)) == (Math.Round(F2D, 6, MidpointRounding.ToEven)));

             bool equal1 = ((Math.Round(S1D, 6, MidpointRounding.ToEven)) == (Math.Round(S2D, 6, MidpointRounding.ToEven)));

             bool equal2 = ((Math.Round(T1D, 6, MidpointRounding.ToEven)) == (Math.Round(T2D, 6, MidpointRounding.ToEven)));

             bool equal3 = ((Math.Round(Fo1D, 6, MidpointRounding.ToEven)) == (Math.Round(Fo2D, 6, MidpointRounding.ToEven)));
             
             Console.WriteLine(equal + Environment.NewLine + equal1 + Environment.NewLine + equal2 + Environment.NewLine + equal3);
*/
             bool equal4 = (Math.Abs(F1D - F2D) < 0.000001m);
             bool equal5 = (Math.Abs(S1D - S2D) < 0.000001m);
             bool equal6 = (Math.Abs(T1D - T2D) < 0.000001m);
             bool equal7 = (Math.Abs(Fo1D - Fo2D) < 0.000001m);

             Console.WriteLine("\n" +equal4 + Environment.NewLine + equal5 + Environment.NewLine + equal6 + Environment.NewLine + equal7);
            }

        }

    }

