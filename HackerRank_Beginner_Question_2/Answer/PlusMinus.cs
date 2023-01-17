using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{

    internal  class PlusMinus
    {
        public  List<decimal> Calculator(List<int> arr)
        {
            decimal n = 0; decimal z=0; decimal p=0;

            List<decimal> result = new List<decimal>();

           
            for (int i = 0; i < arr.Count; i++)
            {
               
                if (arr[i] < 0) n++;
                if(arr[i] > 0) p++;
                if(arr[i] == 0) z++;
               




            }

            decimal NegatifRate = Math.Round(n / arr.Count, 6);
            decimal PosittiveRate = Math.Round(p / arr.Count, 6);
            decimal Zero = Math.Round(z / arr.Count, 6);
            result.Add(PosittiveRate);
            result.Add(NegatifRate);
            result.Add(Zero);
            return result;
        }

       
    }
}
