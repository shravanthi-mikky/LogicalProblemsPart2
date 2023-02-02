using System;
using System.Collections.Generic;
using System.Text;

namespace Logical4AR
{
    public class Pyramid
    {
        public static void PyramidFormation(int[] InputArray)
        {
            Array.Sort(InputArray);

            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            foreach (var Input in InputArray)
            {
                if(Input%2 == 0)
                {
                    even.Add(Input);
                }
                else
                {
                    odd.Add(Input);
                }
            }


        }
    }
}
