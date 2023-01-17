using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    public class StairBuilder
    {
        public string Builder(int StairCount)
        {

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < StairCount + 1; i++)
            {
                for (int x = 0; x < StairCount - i; x++)
                {
                    sb.Append(" ");
                }
                for (int y = 0; y < i; y++)
                {
                    sb.Append("#");
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }

    }
}
