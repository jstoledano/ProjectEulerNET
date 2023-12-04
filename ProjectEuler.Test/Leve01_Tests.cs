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
    }
}
