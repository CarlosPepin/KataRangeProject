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


    }
}
