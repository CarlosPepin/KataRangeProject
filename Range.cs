using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestRange
{
    public class Range
    {
        public int Left, Right;
        public bool IsLeftOpen, IsRightOpen;
        public string rango;
        public List<int> valores = new List<int>();

        public Range(string rango){
            this.rango = rango;
            this.IsLeftOpen = rango.Contains("(");
            this.IsRightOpen = rango.Contains(")");

            string[] separado = rango.Split(',');
            int.TryParse(separado[0].Substring(1), out this.Left);
            int.TryParse(separado[1].Substring(0,separado[1].Length-1), out this.Right);

            if (IsLeftOpen)
                this.Left = Left + 1;
            if (IsRightOpen)
                this.Right = Right - 1;

            if (Right - Left >= 0){
                this.valores = Enumerable.Range(Left, Right - Left + 1).ToList();
            }
        }  

        public bool Contains(int val){
            return this.valores.Contains(val);
        }    
         public bool notContains(int val){
            return !this.valores.Contains(val);
        } 
    }
}