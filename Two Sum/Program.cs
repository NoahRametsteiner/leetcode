using System;

namespace Two_Sum {
    class Two_Sum {
        static void Main(string[] args) {
            int[] res={3,2,4};
            Console.WriteLine(TwoSum(res,6).ToString()); //);
        }
        public static int[] TwoSum(int[] nums, int target) {
            int[] res={0,0};
            for(int i=0; i<nums.Length; i++){
                for(int j=i+1; j<nums.Length; j++) {
                    if(nums[j]+nums[i]==target){
                        res[0]=i;
                        res[1]=j;
                        return res;
                    }
                }
            }
            return null;
        }
    }
}