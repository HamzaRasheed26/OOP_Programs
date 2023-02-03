using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    internal class Subject
    {
        private string code;
        private string type;
        private int creditHour;
        private int fees;

        // constructur
        public Subject(string code, string type, int creditHour, int fees)
        {
            this.code = code;
            this.type = type;
            this.creditHour = creditHour;
            this.fees = fees;
        }

        public string getCode()
        {
            return code;
        }
        public string getType()
        {
            return type;
        }
        public int getCreditHour()
        {
            return creditHour;
        }
        public int getFees()
        {
            return fees;
        }
    }
}
