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

            byte[] arr = new byte[n];
            ConsoleKeyInfo curr;
            byte i0;

            for (int i = 0; i < n; i++)
            {
                do
                {
                    i0 = 2;
                    curr = Console.ReadKey();
                    str = curr.KeyChar.ToString();
                    if (str == "q") return;
                    if (byte.TryParse(curr.KeyChar.ToString(), out i0) & (i0 == 0) | (i0 == 1))
                    {
                        break;
                    }
                    else
                        i0 = 2;
                } while (i0 == 2);

                arr.SetValue(i0, i);
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
