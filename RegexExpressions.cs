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
        // Useful website to create regex expressions: https://regexr.com/

        private static Regex rgInt = new Regex(@"^[0-9]+");
        private static Regex rgDouble = new Regex(@"^[0-9]+(.[0-9]+)?");
        private static Regex rgEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        public static bool isInteger(String s)
        {
            return validate(rgInt, s);
        }

        public static bool isDouble(String s)
        {
            return validate(rgDouble, s);
        }

        public static bool isEmail(String s)
        {
            return validate(rgEmail, s);
        }

        private static bool validate(Regex r, String s)
        {
            // Remove white spaces
            s = s.Trim();
            if (s.Length == 0)
                return false;
            // Get match length
            int len = r.Match(s).Length;
            // Check if match length is same as string
            // (If not, the string has chars that do not match the pattern)
            if (len == s.Length)
                return true;
            return false;
        }
    }
}
