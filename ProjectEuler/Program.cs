using System;
using Project.Euler;

namespace PE {
    class ProjectEulerClass {
        static void Main(string[] args) {
            Level01 level01 = new Level01();
            Console.WriteLine($"Problema 001: {level01.Problem001(1_000)}");
            Console.WriteLine($"Problema 002: {level01.Problem002(4_000_000)}");
        }
    }
}
