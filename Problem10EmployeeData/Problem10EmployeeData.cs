using System;
/*
A marketing company wants to keep record of its employees. Each record would have the following characteristics:
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
Use descriptive names. Print the data at the console.
Expected Output
First name: Amanda
Last name: Jonson
Age: 27
Gender: f
Personal ID: 8306112507
Unique Employee number: 27563571
*/
    class Problem10EmployeeData
    {
        static void Main()
        {
            string firstName = "Sub";
            string lastName = "Zero";
            byte age = 20;
            char gender = 'm';
            long IDN = 6666666666;
            int EMPN = 10000002;

            Console.WriteLine(" First Name: {0}\n Last Name: {1}\n Age: {2}\n Gender: {3}\n IDN: {4}\n EMPN: {5}\n", firstName, lastName, age, gender, IDN, EMPN);  


        }
    }

