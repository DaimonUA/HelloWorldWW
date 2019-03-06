using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            string str;
            Console.WriteLine("Press <q> for quit");
            Console.WriteLine("Enter number:");
            while (n == 0)
            {
                str = Console.ReadLine();
                if (str.ToLower() == "q")
                    return;
                else
                    Int32.TryParse(str,out n);
            }

            byte[] arr;
            ConsoleKeyInfo curr; 

            for (int i = 0; i < n; i++)
            {
                curr = Console.ReadKey();
                byte.TryParse(curr.KeyChar.ToString(),out );
            }

        }

        //static int SeekArray(int[] myarray,int currInbex,int idx)
        //{
        //    int res = 0;
        //    int i = currInbex;

        //    for (currInbex = i; currInbex < myarray.Length-1; currInbex++)
        //    {
        //        if (myarray[currInbex] == 0)
        //            return 0;
        //        res++;
        //        if (res == 1) idx = currInbex;

        //    }

        //    return res;
        //}
    }
}
