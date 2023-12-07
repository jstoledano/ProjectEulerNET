using System;
using Project.Euler;

namespace PE {
    class ProjectEulerClass {
        static void Main(string[] args) {
            Level01 level01 = new Level01();
            Console.WriteLine($"Problema 001: {level01.Problem001(1_000)}");
            Console.WriteLine($"Problema 002: {level01.Problem002(4_000_000)}");
            Console.WriteLine($"Problema 003: {level01.Problem003(600_851_475_143)}");
            Console.WriteLine($"Problema 004: {level01.Problem004(3)}");
            Console.WriteLine($"Problema 005: {level01.Problem005(20)}");
            Console.WriteLine($"Problema 006: {level01.Problem006(100)}");
            Console.WriteLine($"Problema 007: {level01.Problem007(10_001)}");
        }
    }
}
