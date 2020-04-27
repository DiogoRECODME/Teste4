using System;

namespace Answers
{
    public static class OneB
    {
        public static string HalfString(string s)
        {
            double l = s.Length / 2;
            return s.Substring((int)Math.Floor(l), s.Length - (int)l);
        }

        public static bool AtoZ(string s)
        {
            if ((s[0] == 'a') && (s[s.Length-1] == 'z'))
                return true;
            return false;
        }
        
        public static string Trimmer(string s)
        {
            string result = s.Trim();
            return result;
        }
        
    }


}
