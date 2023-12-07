﻿using System;
using System.Net.Http.Headers;

namespace Project.Euler {
    public class Level01 {
        Utils utils = new Utils();
    
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

        public long Problem006(long max) {
            // Sum Square Difference
            long sum_of_squares = 0;
            long simple_sum = 0;
            long diff = 0;

            for (long i = 1; i <= max; i++) {
                sum_of_squares += utils.Cuadrado(i);
                simple_sum += i;
            }
            diff = utils.Cuadrado(simple_sum) - sum_of_squares;

            return diff;
        }

        public long Problem007(int limit) {
            long prime = 3;
            int cuenta = 1;
            int number = 3;

            if (limit == 1) {
                return 2;
            }

            while (cuenta < limit) {
                if (utils.IsPrime(number)) {
                    cuenta++;
                    prime = number;
                }
                number += 2;
            }

            return prime;
        }
    }
}
