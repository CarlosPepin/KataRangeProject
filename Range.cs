using System;

namespace UnitTestRange
{
    public class Range
    {
        public int Left, Right;
        public bool IsLeftOpen, IsRightOpen;
        public string rango;

        public Range(string rango){
            this.rango = rango;
            this.IsLeftOpen = rango.Contains("(");
            this.IsRightOpen = rango.Contains(")");

            string[] separado = rango.Split(',');
            int.TryParse(separado[0].Substring(1), out this.Left);
            int.TryParse(separado[1].Substring(0,separado[1].Length-1), out this.Right);

            if (IsLeftOpen)
                this.Left = Left + 1;
            if (IsLeftOpen)
                this.Right = Right + 1;

           
        }      
    }
}