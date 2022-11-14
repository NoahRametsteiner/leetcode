using System;

namespace Zigzag_Conversion {
    class Zigzag_Conversion {
        static void Main(string[] args) {

            Console.WriteLine(GenerateZigZagString("PAYPALISHIRING",4));
        }

        public static string GenerateZigZagString(string s, int numRows) {
                string str="";
                int colums = 0, strlen=s.Length;
                
                for (int b = 0;; b++) {
                    if(strlen>numRows){
                        strlen=strlen-numRows;
                        colums++;
                        for (int k = 0; k < numRows-2; k++) {
                            if(strlen!=0){
                                strlen--;
                                colums++;
                            }else{break;}
                        }
                    }else{
                        if(strlen!=0){
                            colums++;
                        }break;
                    }
                }
                
                string[,] Numbers = new string[colums,numRows];
                int matrixcolums = 0,strposition=0,rowposition=0;strlen=s.Length;
                for (int b = 0;; b++) {
                    if(strlen>numRows){
                        strlen=strlen-numRows;
                        for(int i=0;i<numRows;i++){Numbers[matrixcolums,i] = s[strposition].ToString();strposition++;}
                        matrixcolums++;rowposition=numRows-2;
                        for (int k = 0; k < numRows-2; k++) {
                            if(strlen!=0){
                                strlen--;
                                Numbers[matrixcolums,rowposition] = s[strposition].ToString();strposition++;
                                rowposition--;
                                matrixcolums++;
                            }else{break;}
                        }
                    }else{
                        if(strlen!=0){
                            for(int i=0;i<strlen;i++){Numbers[matrixcolums,i] = s[strposition].ToString();strposition++;}
                            matrixcolums++;
                        }break;
                    }
                }

                for (int a = 0; a < Numbers.GetLength(1); a++)
                {
                    for (int b = 0; b < Numbers.GetLength(0); b++)
                    {
                        str = str + Numbers[b,a];
                    } 
                }
                return str;
            }
    }
}