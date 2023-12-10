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

        [Theory]
        [InlineData(2640, 10)]
        public void Problem006_CalibrationTest(long want, long max) {
            long got = problem.Problem006(max);
            Assert.Equal(want, got);
        }

        [Theory]
        [InlineData(6, 13)]
        [InlineData(10_001, 104743)]
        public void Problem007_CalibrationTest(int limit, long want) {
            long got = problem.Problem007(limit);
            Assert.Equal(want, got);
        }

        [Theory]
        [InlineData(4, 5832)]
        [InlineData(13, 23_514_624_000)]
        public void Problem008_CalibrationTest(int digit, decimal want) {
            decimal got = problem.Problem008(digit);
            Assert.Equal(want, got);
        }

        [Theory]
        [InlineData(12, 60)]
        [InlineData(1000, 31875000)]
        public void Problem009_CalibrationTest(int sum, int want) {
            int got = problem.Problem009(sum);
            Assert.Equal(want, got);
        }

        [Theory]
        [InlineData(10, 17)]
        [InlineData(2_000_000, 1179908154)]
        public void Problem010_CalibrationTest(int sum, int want) {
            int got = problem.Problem010(sum);
            Assert.Equal(want, got);
        } 
    }
}
