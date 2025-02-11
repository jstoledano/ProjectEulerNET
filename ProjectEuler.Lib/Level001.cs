﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

namespace Project.Euler {
    public class Level001 {
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
            long diff;

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

        public decimal Problem008(int size) {
            // Producto más grande en una serie
            // Encuentra los cuatro dígitos adyacentes en la serie de 
            // 1000 dígitos que tienen el mayor producto. 
            // ¿Cuál es el valor del producto?    


            string longNumber = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064448664523874930358907296290491560440772390713810515859307960866701724271218839987979087922749219016997208880937766572733300105336788122023542180975125454059475224352584907711670556013604839586446706324415722155397536978179778461740649551492908625693219784686224828397224137565705605749026140797296865241453510047482166370484403199890008895243450658541227588666888116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            
            // Creamos la variable que almacenará el producto máximo
            decimal maxProduct = 0;
 
            // Creamos segmentos de tamaño size
            for (int i = 0; i <= (longNumber.Length - size); i++) {
                // Almacenamos cada segmento en la variable segment
                string segment = longNumber.Substring(i, size);
                // Creamos la variable que almacenará el producto de cada segmento
                decimal product = 1;

                
                for (int j = 0; j < size; j++) {
                    // Convertimos cada dígito del segmento en decimal
                    decimal digit = decimal.Parse(segment[j].ToString());
                    
                    // Multiplicamos cada dígito del segmento
                    product *= digit;
                }

                if (product > maxProduct) {
                    maxProduct = product;
                }
            }

            return maxProduct;
        }

        public int Problem009(int sum) {
            // A Pythagorean triplet is a set of three natural numbers,
            // a < b < c, for wich
            //        a^2 + b^2 = c^2
            // For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2
            // There exists exactly one Pythagorean triplet for 
            // which a + b + c = 1000. 
            // Find the product abc.
            int product = 0;
            int suma = 0;
            int catetos = 0;
            int hipotenusa = 0;

            for (int a = 1; a < sum; a++) {
                for (int b = 1; b < sum; b++) {
                    for (int c = 1; c < sum; c++) {
                        suma = a + b + c;
                        if (a < b && b < c) {
                            catetos = a*a + b*b;
                            hipotenusa = c*c;
                            if (catetos == hipotenusa) {
                                if (suma == sum) {
                                    product = a * b *c;
                                }
                            }
                        }
                    }
                }
            }

            return product;
        }

        public Int64 Problem010(Int64 limit) {
            // Suma de primos
            //
            // La suma de los primos menores de 10 es 2+3+5+7=15
            // ¿Cuál es la suma de los primos menores de 
            // dos millones?

            Int64 suma = 2;

            for (int i = 3; i <= limit; i++) {
                if (utils.IsPrime(i)) {
                    suma += Convert.ToInt64(i);
                }
            }

            return suma;
        }
    }
}
