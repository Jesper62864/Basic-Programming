
namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddSeparator("ABCD", "^");
            //AddSeparator("chocolate", "-");

            //Console.WriteLine(IsPalindrome("eye"));
            //Console.WriteLine(IsPalindrome("home"));

            //LengthOfAString("computer");
            //LengthOfAString("ice cream");

            //StringInReverseOrder("qwerty");
            //StringInReverseOrder("oe93 kr");

            //NumberOfWords("This is sample sentence");
            //NumberOfWords("OK");

            //RevertWordsOrder("John Doe.");
            //RevertWordsOrder("A, B. C");

            //HowManyOccurrences("do it now", "do");
            //HowManyOccurrences("empty", "d");

            //SortCharactersDescending("onomatopoeia");
            //SortCharactersDescending("fohjwf42os");

            //CompressString("kkkktttrrrrrrrrrr");
            //CompressString("p555ppp7www");
        }
        static void AddSeparator(string str, string sep)
        {
            string output = string.Join(sep,str.ToArray());
            Console.WriteLine(output);
        }

        static bool IsPalindrome(string v)
        {
            char[] reverse = v.ToCharArray();
            Array.Reverse(reverse);
            return string.Join("", reverse) == v;



        }



        static void CompressString(string v)
        {
            throw new NotImplementedException();
        }

        static void SortCharactersDescending(string v)
        {
            throw new NotImplementedException();
        }

        static void HowManyOccurrences(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        static void RevertWordsOrder(string v)
        {
            throw new NotImplementedException();
        }

        static void NumberOfWords(string v)
        {
            throw new NotImplementedException();
        }

        static void StringInReverseOrder(string v)
        {
            throw new NotImplementedException();
        }

        static void LengthOfAString(string v)
        {
            throw new NotImplementedException();
        }

        

        
    }
}
