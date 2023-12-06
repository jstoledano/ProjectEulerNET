using System;

namespace Project.Euler {
    public class Utils {
        private bool isPrime(long number) {
            for (long i=3; i*i<=number; i+=2) {
                if (number % i == 0) {
                    return false;
                }
            }
            return true;        
        }
    
        public bool IsPrime(long number) {
            if (number == 2) { return true; }
            if (number <= 1 || number % 2 == 0) {
                return false;
            }
            return isPrime(number);
        }

        public long Cuadrado(long number) {
            return number * number;
        }
    }
}
