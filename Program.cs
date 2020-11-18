using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // here i will be doing my bet to actually understand wht i am fdoing in terns of doing this challeng with javascript
            var N = new int[] { 3, 2, 3, 4 };
             var a = new char[] {'a', 'b', 'c'};
            
    
            int start = 0;
            int len = 3;
            Solution1(N);
            Solution2(N);


           
            


          
        }


        public static int Solution1(int[] N)
        {
            if (N.Length % 2 == 0)
            {
                return 0;
            }
            else {
                int length = N.Length;
                int MiddleNum = N[length / 2];
                for (int i = 0; i < length; i++)
                { 
                    if ( i != MiddleNum && MiddleNum >= N[i])
                    {
                       
                        return 0;
                    }
                 
                    return 1;
                }
            
                return 1;
            }
        }


        public static int Solution2(int[] N)
        {

            int X = 0;
            int Y = 0;

        
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] % 2 == 0)
                {
                   Y = Y + N[i];
                }
                else {

                     X = X + N[i];
                }

            }
            Console.WriteLine(X - Y);
            return X - Y;
        }


        public static char[] F(char[]a, int start, int len)
        { 
            //build an array that containts LEN characters starting with the START character
            if (len <= 0 || start<= 0 || start+len-1>=a.Length)
            {
                return null;
            }

            char[] sub = new char[len];
            for(int i= start, j=0; j<len; i++, j++)
            {
                sub[j] = a[i];
               
            }
            return sub;
        }
    }
}

