namespace Rational_Number_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rational bap = new Rational(7, 10);
            Console.WriteLine(bap.To_String());
        }
        public struct Rational
        {
            int Numerator, Denominator;
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
            public string To_String()
            {
                string temp = this.Numerator.ToString() + "/" + this.Denominator.ToString();
                return temp;
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

