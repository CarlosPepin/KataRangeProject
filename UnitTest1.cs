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

        [Fact]
        public void TestEsc113()
        {
            Range R1 = new Range("(1,2]");
            var c4 = R1.Left == 2;
            var c3 = R1.Right == 2;
            Assert.Equal( c3 && c4, true);
        }
        [Fact]
        public void TestEsc114()
        {
            Range R1 = new Range("[1,2)");
            var c4 = R1.Left == 1;
            var c3 = R1.Right == 1;
            Assert.Equal( c3 && c4, true);
        }

        [Fact]
        public void TestEsc121()
        {
            Range R1 = new Range("(1,2)");
            var c5 = R1.valores.Count;
            Assert.Equal( c5 == 0, true);
        }

        [Fact]
        public void TestEsc211(){
            Range R1 = new Range("(2,6)");
            var v = R1.Contains(6);
            Assert.Equal(v,false);
        }

        [Fact]
        public void TestEsc212(){
            Range R1 = new Range("(2,6]");
            var v = R1.Contains(6);
            Assert.Equal(v,true);
        }



    }
}
