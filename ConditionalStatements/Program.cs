namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(AbsoluteValue(6832));
            //Console.WriteLine(AbsoluteValue(-392));

            //Console.WriteLine(DivisibleBy2Or3(15,30));
            //Console.WriteLine(DivisibleBy2Or3(2,90));
            //Console.WriteLine(DivisibleBy2Or3(7,12));

            //Console.WriteLine(IfConsistsOfUppercaseLetters("xyz"));
            //Console.WriteLine(IfConsistsOfUppercaseLetters("DOG"));
            //Console.WriteLine(IfConsistsOfUppercaseLetters("L9#"));

            //Console.WriteLine(IfGreaterThanThirdOne([2, 7, 12]));
            //Console.WriteLine(IfGreaterThanThirdOne([-5, -8, 50]));

            //Console.WriteLine(IfNumberIsEven(721));
            //Console.WriteLine(IfNumberIsEven(1248));

            //Console.WriteLine(IfSortedArray([3, 7, 10]));
            //Console.WriteLine(IfSortedArray([74,62,99]));

            Console.WriteLine(PositiveNegativeOrZero(5.24));
            Console.WriteLine(PositiveNegativeOrZero(0.0));
            Console.WriteLine(PositiveNegativeOrZero(-994.53));


        }

        static int AbsoluteValue(int val)
        {
            int output = Math.Abs(val);
            return output;
        }

        static int DivisibleBy2Or3(int a, int b)
        {
            int output;
            if ((a % 2 == 0 || a % 3 == 0) && (b % 2 == 0 || b % 3 == 0))
            {
                output = a * b;

            }
            else
            {
                output = a + b;
            }
            return output;
        }

        static bool IfConsistsOfUppercaseLetters(string a)
        {
            return a.All(Char.IsUpper);
        }

        static bool IfGreaterThanThirdOne(int[] a)
        {
            if (a[0] + a[1] > a[2] == true || a[0] * a[1] > a[2] == true)
            {
                return true;
            }
            return false;
            
        }

        static bool IfNumberIsEven(int a)
        {
            if (a % 2 == 0)
            {
            return true; 
            }
            else
            {
                return false;
            }
        }

        static bool IfSortedArray(int[] a)
        {
            int temp = a[0];
            foreach (int i in a)
            {
                if (i < temp == true)
                {
                    return false;
                }
                temp = i;
                
            }
            return true;
        }

        static string PositiveNegativeOrZero(double a)
        {
            if (a > 0)
            {
                return "positive";
            }
            else if (a < 0)
            {
                return "negative";
            }
            else
            {
                return "zero";
            }
        }
    }
}
