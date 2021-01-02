using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Roman_Numerals : Number
    {
        private String roman_value1;
        private String roman_value2;

        private int roman_value1_int;
        private int roman_value2_int;

        private int result_int;
        private String sign = "";
        private String result_string;
        private readonly String[] roman_letters_10 = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };

        public  Roman_Numerals(String value1, String value2)
        {
            this.roman_value1 = value1;
            this.roman_value2 = value2;
            this.roman_value1_int = convert_to_int(roman_value1);
            this.roman_value2_int = convert_to_int(roman_value2);
        }
        private String convert_result_to_romes(int n, int ostatok) 
        {
            ostatok = n % 10;
            if (ostatok != 0) {
                try
                {
                    return convert_result_to_romes(n - ostatok, 0) + roman_letters_10[ostatok - 1];
                }
                catch (ArrayTypeMismatchException e)
                {
                    sign = "-";
                    return convert_result_to_romes(n - ostatok, 0) + roman_letters_10[(ostatok - 1) * -1];
                }
            }
            //Возможность вывести отрицательное римское число
            if (n > 0)
            {
                n = n - 10;
                return convert_result_to_romes(n, 0) + "X";
            }
            else if (n < 0)
            {
                n = n + 10;
                return convert_result_to_romes(n, 0) + "X";
            } else { return sign; }
        }

        public override void sum()
        {
            result_int = roman_value1_int + roman_value2_int;
            result_string = convert_result_to_romes(result_int, result_int);
        }
        public override void subtraction()
        {
            result_int = roman_value1_int - roman_value2_int;
            result_string = convert_result_to_romes(result_int, result_int);
        }
        public override void division()
        {
            try
            {
                result_int = roman_value1_int / roman_value2_int;
                result_string = convert_result_to_romes(result_int, result_int);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Проверьте правильность ввода римских цифр. Вероятно введены и арабские и римские одновременно.");
                return;
            }
        }
        public override void multipication()
        {
            result_int = roman_value1_int * roman_value2_int;
            result_string = convert_result_to_romes(result_int, result_int);
        }
        public override int getResult()
        {
            return result_int;
        }
        public override String getStringResult() 
        {
            return result_string;
        }
        private int convert_to_int(String romes_values)
        {
            char[] value_char = romes_values.ToCharArray();
            int[] value_int = new int[value_char.Length];
            for (int i = 0; i < value_char.Length; i++)
            {
                switch (value_char[i]) {
                    case 'I':
                        value_int[i] = 1;
                        break;
                    case 'V':
                        value_int[i] = 5;
                        break;
                    case 'X':
                        value_int[i] = 10;
                        break;
                    default:
                        Console.WriteLine("Содержится неверный символ. Проверьте правильность ввода римских цифр:" + "\n" +
                            "I = 1" + "\n" +
                              "V = 5" + "\n" +
                              "X = 10");
                        break;
                }

            }
            int result = value_int[0];
            for (int i = 0; i < value_int.Length && value_int.Length > i + 1; i++) {
                if (value_int[i] > value_int[i + 1])
                {
                    result += value_int[i + 1];
                }
                else if (value_int[i] < value_int[i + 1]) {
                    result = result + value_int[i + 1] - 2;
                }
            }
            return result;
        }
        public String getRomes_value1()
        {
            return roman_value1;
        }
        public String getRomes_value2()
        {
            return roman_value2;
        }
        public void setRomes_value1(String roman_value1)
        {
            this.roman_value1 = roman_value1;
        }
        public void setRomes_value2(String roman_value2)
        {
            this.roman_value2 = roman_value2;
        }
        public int getRomes_value1_int()
        {
            return roman_value1_int;
        }

        public int getRomes_value2_int()
        {
            return roman_value2_int;
        }

        public void setRomes_value1_int(int roman_value1_int)
        {
            this.roman_value1_int = roman_value1_int;
        }

        public void setRomes_value2_int(int roman_value2_int)
        {
            this.roman_value2_int = roman_value2_int;
        }
    }
    
}
