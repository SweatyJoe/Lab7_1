namespace Lab7_1
{
    class Program
    {
        public static void main(string[] args)
        {
            float x, y, z;
            x = getRandomNumber();
            y = getRandomNumber();
            z = getRandomNumber();
            Vector vector = new Vector(x, y, z);
            Console.WriteLine("vector = " + vector.ToString());
            x = getRandomNumber();
            y = getRandomNumber();
            z = getRandomNumber();
            Vector anotherVector = new Vector(x, y, z);
            Console.WriteLine("anotherVector = " + anotherVector.ToString());
            Vector v = new Vector();
            v = v.sumVectors(vector, anotherVector);
            Console.WriteLine("sum = " + v.ToString());
            vector = v.multiplication(vector, 3.14f);
            Console.WriteLine("3.14 * vector = " + vector.ToString());
        }

        protected static float getRandomNumber()
        {
            Random r = new Random();
            return r.Next(-10, 10);
        }
    }
}