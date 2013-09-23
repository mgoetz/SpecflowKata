using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowKata
{
    public class Calc
    {
        public static int Add(string value)
        {
            int returnValue = 0;
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    returnValue = value
                        .Split(new char[] { ',', '\n' })
                        .Select(x => int.Parse(x))
                        .Sum();
                }
            }
            catch (Exception e)
            { returnValue = -1; }

            return returnValue;
        }
    }
}
