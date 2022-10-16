using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameInterfaces 
{
    public class Building : IHasVaule
    {
        private string tipo;
        private float area;


        private string ToString()
        {
            string str = $"{tipo, -20} {Value, 8:f2} {area, 8:f2}";

            return str;
        }

        public bool Equals(IHasValue other)
        {
            if(other is null)
                return false;

            return Value == other.Value;
        }
    }
}