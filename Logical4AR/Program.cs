using System;
using System.Linq;

namespace Logical4AR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                Console.WriteLine("Enter the option to perform the operation \n1) Pair Intersection \n2) Subraction");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        int[] Pair1 = new int[2];
                        int[] Pair2 = new int[2];
                        PairIntersection.arrayInput(Pair1);
                        PairIntersection.arrayInput(Pair2);
                        int[] resultPair = PairIntersection.Pair_Intersection(Pair1, Pair2);
                        Console.WriteLine("[{0}]", string.Join(", ", resultPair));
                        break;
                    case 2:
                        VendingMachine.Machine(250, 700);
                        break;
                    case 3:
                        int[] InputArray = {169,145,225,211,121,183,100,111,196,214,275 };
                        PickingSquares.CheckingSquares(InputArray);
                        break;

                }
            }
        }
    }
}
