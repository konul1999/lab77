using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab77.Extensions
{
    internal static class StringExtension
    {
       public static string Capitalize(this string word)
        {
            if (word == null || word.Trim() == "") return word; // boş və null yoxlaması
            string first = word[0].ToString().ToUpper();
            string rest = word.Substring(1).ToLower();
            return first + rest;
        }
    }
}
