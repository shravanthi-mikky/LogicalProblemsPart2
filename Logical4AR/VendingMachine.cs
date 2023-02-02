using System;
using System.Collections.Generic;
using System.Text;

namespace Logical4AR
{
    public class VendingMachine
    {

        public static void Machine(int PriceOfItem, int MoneyGiven)
        {
            // 0-1, 1-5, 2-10, 3-25, 4-50, 5-100

            int[] pair = {0,0,0,0,0,0};
            
            int MoneyLeft = MoneyGiven - PriceOfItem;
            while(MoneyLeft >= 100)
            {
                pair[5]++;
                MoneyLeft -= 100;
            }
            while (MoneyLeft >= 50)
            {
                pair[4]++;
                MoneyLeft -= 50;
            }
            while (MoneyLeft >= 25)
            {
                pair[3]++;
                MoneyLeft -= 25;
            }

            while (MoneyLeft >= 10)
            {
                pair[2]++;
                MoneyLeft -= 10;
            }

            while (MoneyLeft >= 5)
            {
                pair[1]++;
                MoneyLeft -= 5;
            }

            while (MoneyLeft >= 1)
            {
                pair[0]++;
                MoneyLeft -= 1;
            }

            foreach(int item in pair)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
