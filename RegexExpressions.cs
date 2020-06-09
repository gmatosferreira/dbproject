using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Funcionarios
{
    public static class RegexExpressions
    {
        private static Regex rgInt = new Regex(@"^[0-9]+");
        private static Regex rgDouble = new Regex(@"^[0-9]+(.[0-9]+)?");

        public static bool isInteger(String s)
        {
            return rgInt.IsMatch(s.Trim());
        }

        public static bool isDouble(String s)
        {
            return rgDouble.IsMatch(s.Trim());
        }

        public static bool isEmail(String s)
        {
            // TODOOO
            return false;
        }
    }
}
