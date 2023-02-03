using System;
using System.Collections.Generic;
using System.Text;

namespace Logical4AR
{
    public class PossibleNDigitValues
    {
        public static void Digits(int N, int sumN)
        {
            int low = 1,high=10;
            for(int i = 0; i < N-1; i++)
            {
                low = low * 10;
                high = high * 10;
            }
            high = high-1;

            Console.WriteLine(low+" "+high);
            for(int i = low; i <= high; i++)
            {
                int temp = i;
                int sum = 0, remainder=0;
                while(temp>0)
                {
                    remainder = temp % 10;
                    sum += remainder;
                    temp /= 10;
                }
                if (sum == sumN)
                {
                    Console.Write(i + " ");
                }

            }
            Console.WriteLine();
        }
    }
}
