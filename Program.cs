using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrimeEngine();

            Console.WriteLine(Stopwatch.Frequency);

            Console.ReadKey();
        }

        static void PrimeEngine()
        {
            PrimeNumber primeNumber = new PrimeNumber();

            //BigInteger[] numberArray = {101, 1009, 10091, 100913, 1009139, 10091401};
            BigInteger[] numberArraySmall = { 101, 1009, 100913, 1009139, 10091401, 100914061, 1009140611, 10091406133 };
            BigInteger[] numberArray = { 101, 1009, 100913, 1009139, 10091401, 100914061, 1009140611, 10091406133, 100914061337, 1009140613399 };

            EngineForDefaultWithCounter(primeNumber, numberArraySmall);

            EngineForDecentWithCounter(primeNumber, numberArray);

            EngineForDefaultWithTimer(primeNumber, numberArraySmall);

            EngineForDecentWithTimer(primeNumber, numberArray);
        }

        #region counters
        static void EngineForDefaultWithCounter(PrimeNumber pn, BigInteger[] arr)
        {
            Console.WriteLine("Default - Counter");
            Console.WriteLine("Number;IsPrime;Counter");
            foreach(BigInteger b in arr)
            {
                Console.WriteLine("{0};{1};{2}", b, pn.IsPrimeDefaultWithCounter(b), pn.counter);
            }
        }

        static void EngineForDecentWithCounter(PrimeNumber pn, BigInteger[] arr)
        {
            Console.WriteLine("Decent - Counter");
            Console.WriteLine("Number;IsPrime;Counter");
            foreach (BigInteger b in arr)
            {
                Console.WriteLine("{0};{1};{2}", b, pn.IsPrimeDecentWithCounter(b), pn.counter);
            }
        }
        #endregion

        #region timers
        static void EngineForDefaultWithTimer(PrimeNumber pn, BigInteger[] arr)
        {
            Console.WriteLine("Default - Time");
            Console.WriteLine("Number;IsPrime;Time");
            foreach (BigInteger b in arr)
            {
                long start = Stopwatch.GetTimestamp();
                bool isPrime = pn.IsPrimeDefault(b);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("{0};{1};{2}", b, isPrime, stop - start);
            }
        }

        static void EngineForDecentWithTimer(PrimeNumber pn, BigInteger[] arr)
        {
            Console.WriteLine("Decent - Time");
            Console.WriteLine("Number;IsPrime;Time");
            foreach (BigInteger b in arr)
            {
                long start = Stopwatch.GetTimestamp();
                bool isPrime = pn.IsPrimeDecent(b);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("{0};{1};{2}", b, isPrime, stop - start);
            }
        }
        #endregion
    }
}
