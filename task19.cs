using System;

namespace problems
{
    public class Problem19
    {
        public static int Problem(){

            int x = 50;
            int y = 95;


            if (x == y){
                return 0 ;
            }

            int x1 = (100-x);
            int y1 = (100-x);
            

            if (x1 < y1 ){
                return x;
            }
            else{
                return y;
            }
            




            
        }



    }
    }


        