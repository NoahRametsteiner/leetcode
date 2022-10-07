using System;

namespace Roman_to_Integer {
    class Roman_to_Integer {
        static void Main(string[] args) {
            Console.WriteLine(RomanToInt("DCXXI"));
        }

        public static int RomanToInt(string s) {
            int res=0;
            char[] ch = s.ToCharArray();

            for(int i=0; i<ch.Length; i++) {
                switch (ch[i]) {
                    case 'I':
                        try {
                            if(ch[i+1]=='V'){
                                res=res + 4;
                                i++;
                            }else if(ch[i+1]=='X'){
                                res=res + 9;
                                i++;
                            }else{
                                res=res+1;
                            }
                        }catch (Exception e) {res=res+1;}
                        break;
                    case 'V':
                        res=res+5;
                        break;
                    case 'X':
                        try {
                            if(ch[i+1]=='L'){
                                res=res + 40;
                                i++;
                            }else if(ch[i+1]=='C'){
                                res=res + 90;
                                i++;
                            }else{
                                res=res+10;
                            }
                        }catch (Exception e) {res=res+10;}
                        break;
                    case 'L':
                        res=res+50;
                        break;
                    case 'C':
                        try {
                            if(ch[i+1]=='D'){
                                res=res + 400;
                                i++;
                            }else if(ch[i+1]=='M'){
                                res=res + 900;
                                i++;
                            }else{
                                res=res+100;
                            }
                        }catch (Exception e) {res=res+100;}
                        break;
                    case 'D':
                        res=res+500;
                        break;
                    case 'M':
                        res=res+1000;
                        break;
                    default:
                        break;
                }
            }
            return res;
        }
    }
}