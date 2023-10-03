using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics
{
    public class Minimum
    {
        public T FindMinimum<T>(T value1, T value2, T value3) where T : IComparable<T>
        {
            T min = value1;

            if (value2.CompareTo(min) < 0)
                min = value2;

            if (value3.CompareTo(min) < 0)
                min = value3;

            return min;
        }

        
    }


    public class MinimumFinder<T> where T : IComparable<T>
    {
        private T value1;
        private T value2;
        private T value3;

        public MinimumFinder(T value1, T value2, T value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }

        public T FindMinimum()
        {
            return Minimum(value1, value2, value3);
        }

        private T Minimum(T v1, T v2, T v3)
        {
            T min = v1;

            if (v2.CompareTo(min) < 0)
                min = v2;

            if (v3.CompareTo(min) < 0)
                min = v3;

            return min;
        }
    }
}
