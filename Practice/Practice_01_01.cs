using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Practice_01_01
    {
        public static void Main(string[] args)
        {
            int[] numsForRef = new int[3];
            int[] numsForOut;
            int length = 5;

            FillOneToArray(ref numsForRef);
            InitArrayWithOne(out numsForOut, length);
            printArray(numsForRef);
            printArray(numsForOut);
        }

        private static void FillOneToArray(ref int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = 1;
            }
        }

        private static void InitArrayWithOne(out int[] nums, int length)
        {
            nums = new int[length];
            for(int i = 0; i < length; i++)
            {
                nums[i] = i;
            }
        }

        private static void printArray(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
