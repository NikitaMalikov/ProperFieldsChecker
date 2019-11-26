using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProperFieldsChecker
{
    class UserNameFieldCheker : FieldsCheker
    {
        public UserNameFieldCheker(string i_InputToCheck) : base(i_InputToCheck) { }

        public override void isValidField()
        {
            if (!m_InputToCheck.All(Char.IsLetterOrDigit) || !m_InputToCheck.Equals(null))
            {
                Console.WriteLine("the username is not valid. must contains only digits or letters - the input is not valid");
                ValidFlagField = false;
            }
            
            if (ValidFlagField)
            {
                Console.WriteLine("Valid username");
            }
        }
    }
}
