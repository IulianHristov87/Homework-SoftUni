using System;

namespace _10.EmployeeData
{
    class employeeData
    {
        static void Main()
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            char gender = 'f';
            long personalID = 8306112507;
            int uniEmployeeNumb = 27563571;

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalID);
            Console.WriteLine("Unique Employee Number: {0}", uniEmployeeNumb);
        }
    }
}
