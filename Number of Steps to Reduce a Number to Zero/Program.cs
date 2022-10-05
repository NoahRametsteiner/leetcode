using System;

namespace Number_of_Steps_to_Reduce_a_Number_to_Zero {
    class Number_of_Steps_to_Reduce_a_Number_to_Zero {
        static void Main(string[] args) {
            Console.WriteLine(nos(8));
        }
        public static int nos(int num) {
            int count = 0, newnumber = num;

            for(int i = 0;; i++) {
                if(newnumber <= 0){
                    break;
                }

                if (newnumber % 2 == 0){
                    //Even
                    newnumber=newnumber/2;
                    count++;
                }else{
                    //Odd
                    newnumber=newnumber-1;
                    count++;
                }
            }return count;
        }
    }
}