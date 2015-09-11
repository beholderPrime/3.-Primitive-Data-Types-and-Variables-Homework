using System;
/*A bank account has a holder name (first name, middle name and last name), 
 * available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. 
 * Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/
    class Problem11BankAccountData
    {
        static void Main()
        {
            string FName = "John";
            string SName = "\"Cash\"";
            string Lname = "Bastard";
            decimal money = 500.50m;
            string bank = "Fibank";
            string iban = "FINV BGSF 1234 5678 9012 4444";
            string CN1 = "4255 2600 0333 0450";
            string CN2 = "5155 6980 1040 3542";
            string CN3 = "6709 6953 1234 5678";
            Console.WriteLine("{0} {1} {2}\nAvailable amount of money: {3}\n{4} IBAN: {5}", FName, SName, Lname, money, bank, iban);
            Console.WriteLine("Card number: {0}\nCard number: {1}\nCard number: {2}", CN1, CN2, CN3);
         
        }
    }

