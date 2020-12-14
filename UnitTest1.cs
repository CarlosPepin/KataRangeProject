using System;
using System.Collections.Generic;
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

        [Fact]
        public void TestEsc311(){
            Range R1 = new Range("[2,9]");
            var v = R1.notContains(2);
            Assert.Equal(v,false);
        }
        
        [Fact]
        public void TestEsc312(){
            Range R1 = new Range("(2,9]");
            var v = R1.notContains(2);
            Assert.Equal(v,true);
        }

        [Fact]
        public void TestEsc411(){
            Range R1 = new Range("[1,4]");
            var v = R1.getAllPoints();
            List<int> v2 = new List<int>(){1,2,3,4};
            Assert.Equal(v,v2);
        }
          [Fact]
        public void TestEsc412(){
            Range R1 = new Range("(1,4)");
            var v = R1.getAllPoints();
            List<int> v2 = new List<int>(){2,3};
            Assert.Equal(v,v2);
        }

         [Fact]
        public void TestEsc413(){
            Range R1 = new Range("(1,3)");
            var v = R1.getAllPoints();
            List<int> v2 = new List<int>(){2};
            Assert.Equal(v,v2);
        }

        [Fact]
        public void TestEsc414(){
            Range R1 = new Range("(1,2)");
            var v = R1.getAllPoints();
            List<int> v2 = new List<int>(){};
            Assert.Equal(v,v2);
        }

        [Fact]
        public void TestEsc511(){
            Range R1 = new Range("(0,9)");
            Range R2 = new Range("[0,9]");
            var v = R1.ContainsRange(R2);
            Assert.Equal(v,false);
        }

        [Fact]
        public void TestEsc512(){
            Range R1 = new Range("[2,3]");
            Range R2 = new Range("(2,3)");
            var v = R1.ContainsRange(R2);
            Assert.Equal(v,true);
        }

        [Fact]
        public void TestEsc611(){
            Range R1 = new Range("[0,10)");
            int[] v2 = new int[2] {0,9};
            var v = R1.endPoints();
            Assert.Equal(v,v2);
        }
        
        [Fact]
        public void TestEsc612(){
            Range R1 = new Range("(0,10)");
            int[] v2 = new int[2] {1,9};
            var v = R1.endPoints();
            Assert.Equal(v,v2);
        }

        [Fact]
        public void TestEsc711(){
            Range R1 = new Range("[2,5)");
            Range R2 = new Range("[1,2)");
            var v = R1.overlapsRange(R2);
            Assert.Equal(v,false);
        }
        [Fact]
        public void TestEsc712(){
            Range R1 = new Range("[2,5)");
            Range R2 = new Range("[1,2]");
            var v = R1.overlapsRange(R2);
            Assert.Equal(v,true);
        }

    }
}
