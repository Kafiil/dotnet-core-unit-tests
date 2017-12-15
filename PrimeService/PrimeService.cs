using System;

namespace PrimeServices
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 0) candidate *= -1;
            if (candidate < 2) return false;

            for (int divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0) return false;
            }
            return true;
        }
    }
}
