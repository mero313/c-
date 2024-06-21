using System;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

namespace problems
{

    public class Problem22
    {
        public static Boolean Problem(){
            string str = "edzszewz";
            int count = 0;
            for(int i =0; i< str.Length; i++){
                if(str[i] == 'z'){
                    count++;
                }
            }
            if (count >=2 && count < 4){
                return true;
            }
            else{
                return false;
            }
        }
    }


}
      


