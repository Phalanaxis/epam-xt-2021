using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Task_3._3._2
{
    public static class Super_string
    {
        public static string Get_language(this string str)
        {
            if (str != null)
            {
                str = str.ToLower();

                if (str.All(c => c >= 'а' && c <= 'я' || c == 'ё'))
                {
                    return "Russian";
                }
                if (str.All(c => c >= 97 && c <= 122))
                {
                    return "English";
                }
                if (str.All(c => c >= '0' && c <= '9'))
                {
                    return "Number";
                }
                else
                {
                    return "Mixed";
                }
            }

            return str;
        }
    }
}
