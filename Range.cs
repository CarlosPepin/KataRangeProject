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

        public List<int> getAllPoints(){
            return this.valores;
        } 
         public bool ContainsRange(Range r){
            if(this.Left <= r.Left && this.Right >= r.Right)
                return true;

             return false;

        } 

        public int[] endPoints(){
            if (valores.FirstOrDefault() == valores.LastOrDefault())
                return new int[] {valores.FirstOrDefault()};
            return new int[] {valores.FirstOrDefault(),valores.LastOrDefault()};
        }

        public bool overlapsRange(Range r){
            var overlap = r.valores.Intersect(this.valores);
            if (overlap.Count() != 0)
            {
                return true;
            }
            return false;
        }
        public bool EqualRange(Range r){
            return r.rango == this.rango;
        }

    }
}