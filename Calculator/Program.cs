using System;
using System.Collections.Generic;
using System.Linq;
using Calculator;

namespace Calculator
{
   class Program
    {
        private static bool its_an_arabic_numbers = true;

        private static string[] pars(string input)
        {
            string[] parsed_input = input.Split(" ");
            if (parsed_input.Length != 3)
            { //Проверка сколько символов введен
				Console.WriteLine("Неверный формат ввода данных. Введите выражение, разделяя каждый символ _пробелом_");
				input = Console.ReadLine();
				return pars(input);
            }
            else 
            {
                return parsed_input;
            }
        }
		public static void Main(string[] args)
		{ 
		
			Console.Write("Введите выражение: ");
			//string input = Convert.ToString(input_a_value);
			string input = Console.ReadLine();
			while (input.Length > 0)
			{
				string[] parsed_input = pars(input);
				string operation = parsed_input[1];
				Number values;
				int value1 = 0;
				int value2 = 0;
				// Парсинг в int. Если введены римские, выкинет исключение
				try
				{
					value1 = int.Parse(parsed_input[0]);
					value2 = int.Parse(parsed_input[2]);
				}
				catch (System.FormatException)
				{
					its_an_arabic_numbers = false;
					Console.WriteLine("Введены римские цифры");
				}

				if (its_an_arabic_numbers)
				{
					
                    values = new Arabic_Numerals(value1, value2);
				}
				else
				{
					values = new Roman_Numerals(parsed_input[0], parsed_input[2]);
				}

				if (operation.Equals("+"))
				{
					values.sum();
				}
				else if (operation.Equals("-"))
				{
					values.subtraction();
				}
				else if (operation.Equals("/") || operation.Equals(":"))
				{
					values.division();
				}
				else if (operation.Equals("*") || operation.Equals("x"))
				{
					values.multipication();
				}

				if (its_an_arabic_numbers)
				{
					Console.WriteLine("Ответ: " + values.getResult());
				}
				else
				{
					Console.WriteLine("Ответ: " + values.getStringResult());
				}
				Console.WriteLine();
				Console.Write("Введите следующее выражение: ");
				input = Console.ReadLine(); 
			}
			Console.WriteLine("Вы вышли из калькулятора");

		}

	}

}
