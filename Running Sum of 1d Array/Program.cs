using System;

namespace Zigzag_Conversion {
    class Zigzag_Conversion {
        static void Main(string[] args) {
            int[] nums = {1,2,3,4};
            int[] array = RunningSum(nums);
            foreach(var item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static int[] RunningSum(int[] nums) {
            int[] res = new int[nums.Length];

            for(int i = 0; i < nums.Length;i++){
                for(int a = 0; a <= i;a++){
                    res[i] = res[i]+nums[a];
                    
                }
            }
            return res;
        }

    }
}