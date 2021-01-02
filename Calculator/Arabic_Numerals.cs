using System;
using System.Collections.Generic;
using System.Text;


 namespace Calculator
{
   public class Arabic_Numerals : Number
    {
        private int value1;
        private int value2;
        private int result;

        public Arabic_Numerals(int value1, int value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }
        public override void sum()
        {
            this.result = value1 + value2;
        }
        public override void subtraction()
        {
            this.result = value1 - value2;
        }
        public override void division()
        {
            try
            {
                this.result = value1 / value2;
            }
            catch (ArithmeticException 
            e) {
                Console.WriteLine("Деление на 0");
                return;
            }
        }
        public override void multipication()
        {
            this.result = value1 * value2;
        }
        override
            public int getResult()
            {
                return result;
            }
        override
            public String getStringResult()
            {
                return "" + result;
            }
        public int getValue1()
        {
            return value1;
        }
        public int getValue2()
        {
            return value2;
        }
        public void setResult(int result)
        {
            this.result = result;
        }
        public void setValue1(int value1)
        {
            this.value1 = value1;
        }
        public void setValue2(int value2)
        {
            this.value2 = value2;
        }
    }
}
