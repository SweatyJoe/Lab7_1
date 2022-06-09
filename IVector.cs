using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    internal interface IVector
    {
        public Vector sumVectors(Vector vector1, Vector vector2);
        public Vector multiplication(Vector vector, float number);
    }
}
