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
        private static Regex rgCoordinates = new Regex(@"^([-+]?)([\d]{1,2})(((\.)(\d+)(,)))(\s*)(([-+]?)([\d]{1,3})((\.)(\d+))?)$");
        private static Regex rgISBN = new Regex(@"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$");

        

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
            // In adition to pattern, check each side length because of db varchar() length restrictions
            if(validate(rgEmail, s))
            {
                if (s.Trim().Split('@')[0].Length <= 64 || s.Trim().Split('@')[0].Length <= 255)
                    return true;
            }
            return false;
        }

        public static bool isPhoneNumber(String s)
        {
            // Aditional validation because Int32 conversion does not accept numbers with 10 digits!
            if (s.Trim().Length != 9)
                return false;
            return validate(rgInt, s);
        }

        public static bool isCoordinates(String s)
        {
            return validate(rgCoordinates, s);
        }

        public static bool isISBN(String s)
        {
            return validate(rgISBN, s);
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
