using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Print_Company_Information
{
    class printCompanyInfo
    {
        static void Main()
        {
            Console.WriteLine("Please enter company name");
            string companyName = Console.ReadLine();
            Console.WriteLine("Please enter company address");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Please enter company phone number");
            string companyPhoneNumb = Console.ReadLine();
            Console.WriteLine("Please enter company fax number");
            string companyFax = Console.ReadLine();
            Console.WriteLine("Please enter company web site");
            string companyWebSite = Console.ReadLine();
            Console.WriteLine("Please enter manager first name");
            string managerFN = Console.ReadLine();
            Console.WriteLine("Please enter manager last name");
            string managerLN = Console.ReadLine();
            Console.WriteLine("Please enter manager age");
            int managerAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter manager phone number");
            string managerPhoneNumb = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", companyPhoneNumb);
            if(companyFax == "")
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine(companyFax);
            }
            Console.WriteLine("Web site: {0}", companyWebSite);
            Console.WriteLine("Manager: {0} {1}(age: {2}, tel. {3})", managerFN, managerLN, managerAge, managerPhoneNumb);

        }
    }
}
