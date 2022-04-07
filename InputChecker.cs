using System;
using System.Linq;

namespace _3_Itransition
{
    static class InputChecker
    {
        public static void CheckInput(string[] args)
        {
            if(args.Length < 1) 
                throw new Exception("Empty field! \n Correct input Example : rock scissors paper");
            if (args.Length % 2 != 1) 
                throw new Exception("Even numbers of arguments! \n Correct input Example : rock scissors paper");
            if(args.Distinct().Count() != args.Length)
                throw new Exception("One or few arguments are repeated! \n Correct input Example : rock scissors paper");
        }
    }
}
