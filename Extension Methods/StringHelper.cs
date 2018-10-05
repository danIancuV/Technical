using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string input)
        {
            char[] arr = input.ToCharArray();
            arr[0] = char.IsUpper(arr[0]) ? char.ToLower(arr[0]) : char.ToUpper(arr[0]);
            return new string(arr);
        }
    }
}
