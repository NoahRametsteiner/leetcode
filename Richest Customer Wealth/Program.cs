using System;

namespace Richest_Customer_Wealth {
    class Richest_Customer_Wealth {
        static void Main(string[] args) {
            int[,] array2D = new int[,] { {1,5}, {7,3}, {3,5}};
            Console.WriteLine(MaximumWealth(array2D));
        }

        public static int MaximumWealth(int[][] accounts) {
            
            int result = 0;
            int placeholder = 0;

            for(int i = 0; i < accounts.GetLength(0);i++){
                for(int a = 0; a <= accounts.GetLength(1);a++){
                    placeholder = placeholder + accounts[i][a];
                }
                if(placeholder>result){
                    result=placeholder;
                }
            }

            return result;
        }

    }
}