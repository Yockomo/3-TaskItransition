using System;
using System.Linq;

namespace _3_Itransition
{
    static class InputChecker
    {
        public static void CheckInput(string[] args)
        {
            if (args.Length < 3)
                ThrowException("Count of arguments < 3!");
            else if (args.Length % 2 != 1)
                ThrowException("Even numbers of arguments!");
            else if (args.Distinct().Count() != args.Length)
                ThrowException("One or few arguments are repeated!");
        }
        public static void ThrowException(string exceptionText)
        {
            throw new Exception($"{exceptionText} \n Correct input Example : rock scissors paper");
        }
    }
}
