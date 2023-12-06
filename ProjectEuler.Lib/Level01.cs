using System;
using System.Net.Http.Headers;

namespace Project.Euler {
    public class Level01 {
        public int Problem001(int limite) {
            // Multiples of 3 or 5
            int suma = 0;
            for (int i = 1; i < limite; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    suma += i;
                }
            }
            return suma;
        }

        public int Problem002(int limit) {
            // Even Fibonacci numbers
        
            int suma = 0;
            int a = 1;
            int b = 2;
            while (a < limit) {
                if (a % 2 == 0) {
                    suma += a;
                }
                int c = a + b;
                a = b;
                b = c;
            }
            return suma;
        }

        public long Problem003(long number) {
            // Largest Prime Factor
        
            Utils utils = new Utils();
            long largestFactor = 2;
            if (utils.IsPrime(number)) {
                return number;
            }

            for (long divisor=3; (divisor*divisor)<=number; divisor+=2) {
                if (number % divisor == 0) {
                    largestFactor = divisor;
                    number /= divisor;
                }
            }

            if (number > largestFactor) {
                largestFactor = number;
            }
            return largestFactor;
        }
    
        public long Problem004(int digits) {
            // Largest palindrome product
            long max = (long)Math.Pow(10, digits) - 1;
            long largest = 0;

           for (long i=max; i>0; i--) {
                for (long j=max; j>0; j--) {
                    long product = i * j;
                    // Convert long to string
                    string number = (product).ToString();
                    // Reverse string
                    char[] charArray = number.ToCharArray();
                    Array.Reverse(charArray);
                    string reverse = new string(charArray);
                    // Compare
                    if (number == reverse && product > largest) {
                        largest = product;
                    }
                }
           }
           return largest;
        }

        public long Problem005(long max) {
            long small = 1;
        
            for(long k = 1; k < max; k++) {
                if(small % k > 0) {
                    for (long j = 1; j < max; j++) {
                        if ((small * j) % k == 0) {
                            small *= j;
                            break;
                        }
                    }
                }
            }

            return small;
        }
    }
}
