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


        // Funci�n auxiliar para contar el n�mero de divisores de un n�mero
        public int CountDivisors(long n)
        {
            int count = 1;
            // Se realiza la factorizaci�n en primos y se utiliza la f�rmula:
            // Si n = p1^a1 * p2^a2 * ... * pk^ak, el n�mero de divisores es (a1+1)*(a2+1)*...*(ak+1).
            for (long factor = 2; factor * factor <= n; factor++)
            {
                int exponent = 0;
                while (n % factor == 0)
                {
                    exponent++;
                    n /= factor;
                }
                if (exponent > 0)
                    count *= (exponent + 1);
            }
            // Si al final n es mayor que 1, es un factor primo restante
            if (n > 1)
                count *= 2;

            return count;
        }
    }
}
