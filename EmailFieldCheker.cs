using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProperFieldsChecker
{
    class EmailFieldCheker : FieldsCheker
    {
        private List<string> m_ListOfValidDomains;

        public EmailFieldCheker(string i_InputToCheck) : base(i_InputToCheck)
        {
            //By deafult only google mails are valid, can be extand by AddValidDomain method
            m_ListOfValidDomains = new List<string> { "gmail.com" };
        }

        public void AddValidDomain(string i_NewValidDomain)
        {
            m_ListOfValidDomains.Add(i_NewValidDomain);
        }

        public override void isValidField()
        {
            string[] SplitedInput = m_InputToCheck.Split('@');

            //Case there are more then two '@'s or none - the input is not valid
            if (SplitedInput.Length > 2 || SplitedInput.Length == 1)
            {
                Console.WriteLine("There muse be one '@' in your address - the input is not valid");
                ValidFlagField = false;
            }
            else
            {
                //Case the domain is not in one of our valid domains return false - the input is not valid
                if (!m_ListOfValidDomains.Contains(SplitedInput[1]))
                {
                    Console.WriteLine("the domain is not in one of our valid domains - the input is not valid");
                    ValidFlagField = false;
                }
                if (!SplitedInput[0].All(Char.IsLetterOrDigit))
                {
                    Console.WriteLine("the localpart is not valid must contains only digits or letters - the input is not valid");
                    ValidFlagField = false;
                }
            }

            if (ValidFlagField)
            {
                Console.WriteLine("Valid email");
            }
        }

    }
}
