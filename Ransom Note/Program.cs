using System;

namespace Ransom_Note {
    class Ransom_Note {
        static void Main(string[] args) {

            Console.WriteLine(CanConstruct("aa","aab"));
        }
        public static bool CanConstruct(string ransomNote, string magazine) {
            int a= 0, strlen= ransomNote.Length;
            char[]? charNote = ransomNote.ToCharArray();
            char[]? charmagazine = magazine.ToCharArray();
                        
            for (int i=0; i<strlen; i++) {
                string str = new string(charmagazine);
                for (int j=0; j<strlen; j++) {
                    str = new string(charmagazine);
                    if(str.IndexOf(charNote[i])!=-1){
                        charmagazine[magazine.IndexOf(charNote[i])]=' ';
                        a++;
                    }else{
                        return false;
                    }
                }
            }
            return true;
        }
    }
}