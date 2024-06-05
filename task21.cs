using System;
using System.Reflection.Metadata.Ecma335;

namespace problems
{
    public class Problem21
    {
        public static int Problem(){
            int x = 20;
            int y = 21;
            if(x>=20 && x<= 30 && y>=20 && y<=30){
                if(x<y){
                    return y;
                }
                else {
                    return x;
                }
                
            }
            return 0;
        }
        
        }
         
    }


