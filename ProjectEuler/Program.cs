using System;
using Project.Euler;

namespace PE {
    class ProjectEulerClass {
        static void Main(string[] args) {
            Level001 level001 = new Level001();
            Console.WriteLine($"Problema 001: {level001.Problem001(1_000)}");
            Console.WriteLine($"Problema 002: {level001.Problem002(4_000_000)}");
            Console.WriteLine($"Problema 003: {level001.Problem003(600_851_475_143)}");
            Console.WriteLine($"Problema 004: {level001.Problem004(3)}");
            Console.WriteLine($"Problema 005: {level001.Problem005(20)}");
            Console.WriteLine($"Problema 006: {level001.Problem006(100)}");
            Console.WriteLine($"Problema 007: {level001.Problem007(10_001)}");
            Console.WriteLine($"Problema 008: {level001.Problem008(13)}");
            Console.WriteLine($"Problema 009: {level001.Problem009(1_000)}");
            Console.WriteLine($"Problema 010: {level001.Problem010(2_000_000)}");

            Level002 l002 = new Level002();
            Console.WriteLine($"Problema 011: {l002.Problem011()}");
            Console.WriteLine($"Problema 012: {l002.Problem012()}");
        }
    }
}
