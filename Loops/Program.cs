
using System;
using System.Diagnostics.Metrics;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MultiplicationTable();

            //TheBiggestNumber([190,291,145,209,280,200]);
            //TheBiggestNumber([-9, -2, -7, -8, -4]);

            //Two7sNextToEachOther([8, 2, 5, 7, 9, 0, 7, 7, 3, 1]);
            //Two7sNextToEachOther([9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7]);

            //ThreeIncreasingAdjacent([45, 23, 44, 68, 65, 70, 80, 81, 82]);
            //ThreeIncreasingAdjacent([7, 3, 5, 8, 9, 3, 1, 4]);

            //SieveOfEratosthenes(30);

            //ExtractString("##abc##def");
            //ExtractString("12####78");
            //ExtractString("gar##d#en");
            //ExtractString("++##--##++");

            //FullSequenceOfLetters("ds");
            //FullSequenceOfLetters("or");

            //SumAndAverage(11, 66);
            //SumAndAverage(-10, 00);

            //DrawTriangle();

            ToThePowerOf(-2, 3);
            ToThePowerOf(5, 5);
        }

        static void MultiplicationTable()
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    string output = (i * j).ToString();
                    for (int n = 3; n > output.Length; n--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(output + " ");
                    

                }
                Console.WriteLine(" ");

            }
        }

        static void TheBiggestNumber(int[] ints)
        {
            int bignum = int.MinValue;
            foreach (int num in ints)
            {
                if (num > bignum)
                {
                    bignum = num;
                }
            }
            Console.WriteLine(bignum);
        }

        static void Two7sNextToEachOther(int[] digits)
        {
            int digitsCount = digits.Length;
            int output = 0;
            for (int i = 0; i < digitsCount - 1; i++)
            {
                if (digits[i] == 7 && digits[i + 1] == 7)
                {
                    output++;
                }
            }
            Console.WriteLine(output);

        }

        static void ThreeIncreasingAdjacent(int[] numbers)
        {
            bool output = false;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i + 1] == numbers[i] + 1 && numbers[i + 2] == numbers[i] + 2)
                {
                    output = true;
                }

            }
            Console.WriteLine(output);
        }

        static void SieveOfEratosthenes(int n)
        {
            Console.Write("2, 3, ");
            int multiplier = 1; 
            int  multiCounter= 0; 
            for (int i = 1; i < n; i++)
            {
                if (6 * multiplier + 1 == i || 6 * multiplier - 1 == i) // Formular er 6*x +1 eller 6*x -1 for Primtal. Multiplier er x.
                {
                    Console.Write(i +", ");
                    multiCounter++;
                    if (multiCounter == 2) // Multiplier skal kun gå op hver anden gang. 
                    {
                        multiplier++;
                        multiCounter = 0;
                    }
                }
                
            }
            
        }

        static void ExtractString(string v)
        {
            int firstOccurance = v.IndexOf("#");
            int lastOccurance  = v.LastIndexOf("#");
            string output = v.Substring(firstOccurance +2, lastOccurance - firstOccurance -3);
            if (output == "")
            {
                Console.WriteLine("empty string");
            }
            else
            {
                Console.WriteLine(output);                
            }

                
        
        }

        static void FullSequenceOfLetters(string v)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int startIndex = alphabet.IndexOf(v[0]);
            int endIndex = alphabet.IndexOf(v[1]);
            string output = alphabet.Substring(startIndex, endIndex - startIndex +1);
            Console.WriteLine(output);


        }

        static void SumAndAverage(double v1, double v2)
        {
            double sum = 0;
            double numCount = 0;
            double average;
            for (double i = v1; i <= v2; i++)
            {
                sum += i;
                numCount++;
            }
            average = sum / numCount;
            Console.WriteLine("Sum: " + sum + ", Average: " + average);
        }

        static void DrawTriangle()
        {

            int column = 1;
            int row = 10;

            for (int i = 0; i < row; i++)
            {
                for (int x = 0; x <= row - i; x++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < column; j++)
                {
                    Console.Write("*");
                }
                column += 2;
                Console.WriteLine();


            }
        }

        static void ToThePowerOf(int num, int pow)
        {
            int output = num;
            for (int i = 0; i < pow - 1; i++)
            {
                output *= num;
            }
            Console.WriteLine(output);
        }

    }
}
