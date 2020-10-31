using System;
using System.Linq;
using System.Threading;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int pocet = 0;
            foreach (char c in str)
            {
                if (letter == c)
                    pocet++;
            }
            return pocet;

        }
    }
}
