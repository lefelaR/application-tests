using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pretestQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

             int [] a = {1,2,3,4,3,2,1};
            int[] b = { 3, 3, 4, 4 };
            //  Solution(a);
            Solution2(b);

        }

        public static int Solution(int[] N)
        {
            if (N.Length % 2 == 0)
            {
                return 0;
            }
            else
            {

                int length = N.Length;
                int MiddleNum = N[length / 2];
                for (int i = 0; i < length; i++)
                {
                    if (i != MiddleNum && MiddleNum >= N[i])
                    {
                        Console.WriteLine("0");
                        return 0;
                    }
                    Console.WriteLine("1");
                    return 1;
                }
                Console.WriteLine("1");
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
                else
                {
                    X = X + N[i];
                }
            }
            Console.WriteLine(X - Y);
            return X - Y;
        }



    }
}
