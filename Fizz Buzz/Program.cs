using System;

namespace Fizz_Buzz {
    class Fizz_Buzz {
        static void Main(string[] args) {
            IList<string> list = new List<string>();
            //Console.WriteLine(3%3);
            list=FizzBuzz(5);
            foreach(var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static IList<string> FizzBuzz(int n) {
            IList<string> Fizz_Buzz = new List<string>();
            for(int i = 1; i <= n; i++){
                if(i%3 == 0 && i%5 == 0){
                    Fizz_Buzz.Add("FizzBuzz".ToString());
                }else if(i%3 == 0){
                    Fizz_Buzz.Add("Fizz".ToString());
                }else if(i%5 == 0){
                    Fizz_Buzz.Add("Buzz".ToString());
                }else{
                Fizz_Buzz.Add(i.ToString());
                }
            }
            return Fizz_Buzz;
        }

    }
}