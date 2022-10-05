using System;

namespace Ransom_Note2 {
    class Ransom_Note2 {
        static void Main(string[] args) {      
            Console.WriteLine(CanConstruct("aa","aab").ToString());
        }

        public static bool CanConstruct(string ransomNote, string magazine) {
            char[] charransomNote = ransomNote.ToCharArray(); 
            char[] charmagazine = magazine.ToCharArray();
            int count = 0;

            for(int i = 0; i < charransomNote.Length; i++) {
                for(int j = 0; j < charmagazine.Length; j++) {
                    if(charransomNote[i] == charmagazine[j]) {
                        charmagazine[j] = ' ';
                        count++;
                        break;
                    }
                }
            }
            if(count == charransomNote.Length) {
                return true;
            }
            return false;
        }
    }
}