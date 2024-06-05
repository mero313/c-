using System;

namespace problems
{
    public class Problem24
    {
        public static string Problem()
        {
            string str = "mero";
            string result = "";

            if (str.Length < 3)
            {
                return str.ToUpper();
            }
            else
            {
                for (int i = str.Length - 3; i < str.Length; i++)
                {
                    result += str[i];
                }
                result = result.ToUpper();
            }

            return str.Remove(str.Length - 3) + result;
        }
    }
}
