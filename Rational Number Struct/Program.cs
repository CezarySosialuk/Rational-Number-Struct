namespace Rational_Number_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rational bap = new Rational(7, 10);
            Console.WriteLine(bap.Numerator);
            Console.WriteLine(bap.Denominator);
        }
        public struct Rational
        {
            public int Numerator, Denominator;
            public Rational(int a, int b)
            {
                if (b != 0)
                {
                    int temp = GCD(a, b);

                    this.Numerator = a / temp;
                    this.Denominator = b / temp;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        };
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}

