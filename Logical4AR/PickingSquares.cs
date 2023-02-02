using System;
using System.Collections.Generic;
using System.Text;

namespace Logical4AR
{
    public class PickingSquares
    {
        public static void CheckingSquares(int[] Input)
        {
            List<int> Output = new List<int>();
            for(int i = 0; i < Input.Length; i++)
            {
                for(int j=0; j< Input[i]; j++)
                {
                    if(Input[i] == j * j)
                    {
                        Output.Add(Input[i]);
                    }

                }
            }
            foreach(int i in Output)
            {
                Console.WriteLine(i);
            }
        }
    }
}
