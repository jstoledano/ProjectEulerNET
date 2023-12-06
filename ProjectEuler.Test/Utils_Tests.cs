using Xunit;
using Project.Euler;

namespace Project.Euler.Test {
    public class Utils_Tests {
        Utils utils = new Utils();

        [Theory]
        [InlineData(false, -1)]
        [InlineData(false, 0)]
        [InlineData(false, 1)]
        [InlineData(true, 2)]
        [InlineData(true, 3)]
        [InlineData(true, 5)]
        [InlineData(true, 7)]
        [InlineData(false, 2222)]
        [InlineData(true, 1535348471)]
        public void ActualPrimesNumber_Test(bool want, long number) {
            bool got = utils.IsPrime(number);
            Assert.Equal(want, got);
        }

        [Theory]
        [InlineData(2, 4)]
        [InlineData(3, 9)]
        [InlineData(4, 16)]
        public void Cuadrados_Test(long number, long want) {
            long got = utils.Cuadrado(number);
            Assert.Equal(want, got);
        }
    }
}
