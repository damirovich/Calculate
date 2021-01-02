using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public abstract class Number
    {
        public abstract void sum();// Сложение "+"
        public abstract void subtraction();// Вычетание "-"
        public abstract void division();// Деление "/"
        public abstract void multipication();// Умножение "*"

        public abstract int getResult();
        public abstract String getStringResult();
    }
}
