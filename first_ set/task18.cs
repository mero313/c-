using System;

namespace problems
{
    public class Problem18
    {
        public static int Problem(){

            int x = 6;
            int y = 27;
            int z = 64;

            int largest = x;

            if(y > largest){
                largest = y;
            }
            if(z > largest ){
                largest = z;
            }
            return largest;

            




            
        }



    }
    }


        