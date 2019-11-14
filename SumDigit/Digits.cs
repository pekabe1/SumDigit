using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumDigit
{
   public class Digits
    {
        string digitsToSum { get; set; }

        public Digits(string digits)
        {
            this.digitsToSum = digits;       
        }
        public List<int> DigitsList()
        {
           
            List<int> result = new List<int>();
           
            foreach (char item in digitsToSum)
            {
                if (char.IsDigit(item))
                {
                    result.Add((int)char.GetNumericValue(item));
                }else
                    result.Add(0);
            }
            return result;
        }

        public int SumDigits()
        {
            int result = DigitsList().Sum();
            return result;
        }


    }
}
