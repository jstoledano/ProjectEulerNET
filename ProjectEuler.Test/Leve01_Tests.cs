using Xunit;
using Project.Euler;

namespace Project.Euler.Test {
    public class Level01_Tests {
        Level01 problem = new Level01();

        [Fact]
        public void Problem001_CalibrationTest() {
            // Arrange
            int want = 23; 
            // Act
            int got = problem.Problem001(10);
            // Assert
            Assert.Equal(want, got);
        }

        [Fact]
        public void Problem002_CalibrationTest() {
            Assert.Equal(44, problem.Problem002(90));
        }

        [Theory]
        [InlineData(11, 11)]
        [InlineData(1535348471, 1535348471)]
        [InlineData(29, 13_195)]
        [InlineData(6857, 600_851_475_143)]
        public void Problem003_CalibrationTest(long want, long number) {
            long got = problem.Problem003(number);
            Assert.Equal(want, got);
        }

        [Fact]
        public void Problem004_CalibrationTest() {
            Assert.Equal(9009, problem.Problem004(2));
        }

        [Theory]
        [InlineData(2520, 10)]
        [InlineData(232_792_560, 20)]
        public void Problem005_CalibrationTest(long want, long max) {
            long got = problem.Problem005(max);
            Assert.Equal(want, got);
        }
    }
}
