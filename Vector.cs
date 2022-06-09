using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    public class Vector : IVector
    {
        private float x { get; set; }
        private float y { get; set; }
        private float z { get; set; }
        delegate int getLengthDelegate();

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vector(){

        }

        public Vector sumVectors(Vector vector1, Vector vector2) => vector1 + vector2;

        public Vector multiplication(Vector vector, float number) => vector * number;

        public static Vector operator +(Vector vector1, Vector vector2)
        {
            Vector sumVector = new Vector(0, 0, 0);
            sumVector.x = vector1.x + vector2.x;
            sumVector.y = vector1.y + vector2.y;
            sumVector.z = vector1.z + vector2.z;
            return sumVector;
        }

        public static Vector operator *(Vector vector, float number)
        {
            vector.x *= number;
            vector.y *= number;
            vector.z *= number;
            return vector;
        }

        override public string ToString()
        {
            return "[" + x + "," + y + "," + z + "]";
        }
    }
}
