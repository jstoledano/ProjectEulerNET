using Xunit;
using Project.Euler;
using System;


namespace Project.Euler.Test
{
    public class Level002_Test
    {
        Level002 l002 = new Level002();

        [Fact]
        public void Problem011_CalibrationTest()
        {
            // Arrange
            long want = 70_600_674;
            // Act
            long got = l002.Problem011();
            // Assert
            Assert.Equal(want, got);
        }

        [Fact]
        public void Problem012_CalibrationTest()
        {
            // Arrange
            long want = 76_576_500;
            // Act
            long got = l002.Problem012();
            // Assert
            Assert.Equal(want, got);
        }
    }
}
