using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Extention_method
{
    internal static class Helper
    {
        public static bool IsOdd(this int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;

            }
        }
        public static bool IsEven(this int number)
        {
            if (number % 2 != 0)
            {
                return false;
            }
            else
            {
                return true;

            }
        }
        public static bool Hasdigit(this string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckPassword(this string password)
        {
            if (password.Length <8)
            {
                return false;
            }
            foreach (char c in password)
            {
                if (!char.IsDigit(c))
                {
                    return true;
                }
                else if (char.IsLower(c))
                {
                    return true;
                }
                else if (!char.IsUpper(c))
                {
                    return true;
                }

            }

            return false;
            //   return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && password.Length <= 8;
        }


        public static string Capitalize(this string input)
        {
           
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();


        }
    }
   

    }
