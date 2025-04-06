using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_HomeWork11
{
    public class ComparablePair<T1,T2> : Pair<T1,T2> , IComparable<ComparablePair<T1,T2>> 
        where T1 : IComparable<T1>
        where T2 : IComparable<T2>
    {
        public ComparablePair(T1 value1, T2 value2) : base(value1, value2)
        {
           
        }
        
        public int CompareTo(ComparablePair<T1, T2> other)
        {
            if (other == null) return 1;
            int firstCompare = this.FirstValue.CompareTo(other.FirstValue);
            if (firstCompare != 0)
            {
                return firstCompare;
            }

            return this.SecondValue.CompareTo(other.SecondValue);

        }
    }
}

