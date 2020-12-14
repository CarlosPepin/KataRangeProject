using System;
using Xunit;

namespace UnitTestRange
{
    public class UnitTest1
    {
        [Fact]
        public void TestEsc111()
        {
            Range R = new Range("[1,2]");
            var c1 = R.Left == 1;
            var c2 = R.Right == 2;
            Assert.Equal( c1 && c2 ,true);
        }

        [Fact]
        public void TestEsc112()
        {
            Range R1 = new Range("(1,3)");
            var c4 = R1.Left == 2;
            var c3 = R1.Right == 2;
            Assert.Equal( c3 && c4 ,true);
        }


    }
}
