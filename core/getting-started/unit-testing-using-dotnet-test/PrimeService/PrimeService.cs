using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            else if (candidate is 2 or 3 or 5 or 7)
            {
                return true;
            }
            else if (candidate is 4 or 6 or 8 or 9)
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");

        }
    }
}