using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KultyshevaEA.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            int l = value.Length;
                if (l % 2 != 0)
                {
                value = value.Remove((value.Length / 2), 1);
                }
            return value;











        }
    } 
}
