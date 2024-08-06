namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(AddAndMultiply(2, 4, 5));

            //Console.WriteLine(CtoF(0));
            //Console.WriteLine(CtoF(100));
            //Console.WriteLine(CtoF(-300));

            //Console.WriteLine(ElementaryOperations(3,8));
            //Console.WriteLine(IsResultTheSame(2 + 2, 2 * 2));
            //Console.WriteLine(IsResultTheSame(9/3, 16-1));

            //Console.WriteLine(ModuloOperations(8, 5, 2));

            //Console.WriteLine(CubeOf(2));
            //Console.WriteLine(CubeOf(-5.5));

            SwapTwoNumbers(87, 45);
            SwapTwoNumbers(-13, 2);
        }

        static int AddAndMultiply(int a, int b, int c)
        {
            int output = (a + b) * c;
            
            return output;
        }

        static string CtoF(double a) 
        {
            string output = "T = " + (a * 9 / 5 + 32).ToString() + "F";
            if (a < -271.15)
            {
                string failMessage = "Temperature below absolute zero!";
                return failMessage;
            }
            else
            {
                return output;
            }
            
        }

        static string ElementaryOperations(double a, double b)
        {
            string output = $"{a + b}, {a - b}, {a * b}, {a / b} ";
            if (b ==0)
            {
                output = "Remember that you can't divide any number by 0!";
            }
            return output;
        }

        static bool IsResultTheSame(int a, int b)
        {
            return a == b;
        }

        static int ModuloOperations(int a, int b, int c)
        {
            int output = a % b % c;
            return output;
        }

        static double CubeOf(double a)
        {
            double output = Math.Pow(a, 3);
            return output;
        }

        static void SwapTwoNumbers(int a, int b)
        {
            Console.WriteLine($"Before: a = {a}, b = {b};");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After: a = {a}, b = {b};");
        }


    }
}
