using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace Open_Lab_04._01
{
    public class Checker
    {
        public bool DoubleLetters(string str)
        {
            int L = str.Length;                       
            for (int i = 0; i < L-1; i++)
            {               
                if (i < L -1 && str[i] == str[i + 1])
                    return true;                              
            }
            return false;
        }
    }
}
