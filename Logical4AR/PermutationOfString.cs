﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logical4AR
{
    public class PermutationOfString
    {
        public static void Permute(char[] arry, int i, int n)
        {
            int j;
            if (i == n)
                Console.WriteLine(arry);
            else
            {
                for (j = i; j <= n; j++)
                {
                    Swap(ref arry[i], ref arry[j]);
                    Permute(arry, i + 1, n);
                    Swap(ref arry[i], ref arry[j]); //backtrack
                }
            }
        }

        static void Swap(ref char a, ref char b)
        {
            char tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
    }
}
