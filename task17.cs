using System;

namespace problems
{
    public class Problem17
    {
        public static string Problem()
        {

            string str = "python";

            if (str.Length >= 3 && str.Substring(1,2) == "yt"){

                return str.Substring(0, 1) + str.Substring(3);
            }
            return str;




        }



    }
}


