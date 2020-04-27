using System;
using System.Collections.Generic;

namespace Answers
{
    public static class OneA
    {
        
        public static List<int> ImparDivisivel9Above50(List<int> nums)
        {
            //List<int> nums = new List<int> { 239, 23, 56, 92, 44, 93, 99 };
            List<int> result = new List<int> ();
            foreach (int i in nums)
            {
                if ((i > 50) && (i % 2 != 0) && (i % 9 == 0))
                    result.Add(i);
            }
            return result;
        }
    }

  
}
