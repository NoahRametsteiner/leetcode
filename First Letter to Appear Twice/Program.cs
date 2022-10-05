using System;

namespace First_Letter_to_Appear_Twice {
    class First_Letter_to_Appear_Twice {
        static void Main(string[] args) {
           Console.WriteLine(RepeatedCharacter("abccbaacz"));
        }
        public static char RepeatedCharacter(string s) {
            char[] chars = s.ToCharArray();
            int index=0;
            for (int i = 0; i < s.Length; i++) {
                for (int j = 0; j < s.Length; j++) {
                    if (chars[i] == chars[j]){
                        if(index < j){
                            index=j;
                            break;
                        }
                    }
                }
            }
            return chars[index];
        }
    }
}