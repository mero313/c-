using System;

namespace problems
{
    public class Problem24_3
    {
       public static void task24()
        {
            string str1 = "akram nfigmke";
            string str2 ="mustafa baker";

            char c1 =' ' ;
            char c2 =' ';

            for (int i = 0; i < str1.Length ; i++)
            {
                 if ( str1[i] == ' ' ){
                    
                    c1= str1[i+1];
                    
                 }
            }

            
            for (int i = 0; i < str2.Length ; i++)
            {
                 if ( str2[i] == ' '){
                    
                    c2= str2[i+1];
                    
                 }
            }
            

                
               if (c1 > c2 ){
                Console.WriteLine(str2);
                Console.WriteLine(str1);
               }

            else{
                Console.WriteLine(str1);
                Console.WriteLine(str2);
            }
                
            }

             


        }



    }



