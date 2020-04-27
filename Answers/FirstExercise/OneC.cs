using System;
using System.Collections.Generic;
using System.Linq;

namespace Answers
{
    public class OneC
    {
        public static List<int> ListOperator(List<int> nums)
        {
            //List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            List<int> result = new List<int>();

            foreach (int i in nums)
                result.Add((i * i) + (8 * 3));
            
            return result;
        }

    }

}