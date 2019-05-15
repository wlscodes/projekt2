using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2
{
    class PrimeNumber
    {
        public long counter;

        public bool IsPrimeDefaultWithCounter(BigInteger number)
        {
            counter = 1;
            if (number < 2) return false;
            else if (number < 4) return true;
            else if (number % 2 == 0) return false;
            else
            {
                for (BigInteger i = 3; i < number / 2; i += 2)
                {
                    counter++;
                    if (number % i == 0) return false;
                }
            }
            return true;
        }

        public bool IsPrimeDefault(BigInteger number)
        {
            if (number < 2) return false;
            else if (number < 4) return true;
            else if (number % 2 == 0) return false;
            else
            {
                for (BigInteger i = 3; i < number / 2; i += 2)
                {
                    if (number % i == 0) return false;
                }
            }
            return true;
        }

        public bool IsPrimeDecentWithCounter(BigInteger number)
        {
            counter = 1;
            if (number < 2) return false;
            else if (number < 4) return true;
            else if (number % 2 == 0) return false;
            else
            {
                for (BigInteger i = 3; i * i <= number; i += 2)
                {
                    counter++;
                    if (number % i == 0) return false;
                }
            }
            return true;
        }

        public bool IsPrimeDecent(BigInteger number)
        {
            if (number < 2) return false;
            else if (number < 4) return true;
            else if (number % 2 == 0) return false;
            else
            {
                for (BigInteger i = 3; i * i <= number; i += 2)
                {
                    if (number % i == 0) return false;
                }
            }
            return true;
        }

    }
}
