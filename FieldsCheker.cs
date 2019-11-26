using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProperFieldsChecker
{
    public abstract class FieldsCheker
    {
        protected string m_InputToCheck;
        protected bool ValidFlagField = true;
        protected FieldsCheker(string i_InputToCheck)
        {
            m_InputToCheck = i_InputToCheck;
        }
        public abstract void isValidField();
    }
}
