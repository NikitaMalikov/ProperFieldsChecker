using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProperFieldsChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString;
            Console.Write("Enter a Email - ");
            testString = Console.ReadLine();

            FieldsCheker FirstFieldsCheker = new EmailFieldCheker(testString);
            FirstFieldsCheker.isValidField();

            Console.Write("Enter a Username - ");
            testString = Console.ReadLine();

            FieldsCheker SecondFieldsCheker = new UserNameFieldCheker(testString);
            SecondFieldsCheker.isValidField();
        }

    }
}
