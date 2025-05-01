using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== КОНСОЛЬНИЙ КАЛЬКУЛЯТОР ===");

        try
        {
            Console.Write("Введіть перше число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть операцію (+, -, *, /): ");
            string operation = Console.ReadLine();

            Console.Write("Введіть друге число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("❌ Помилка: ділення на нуль!");
                        return;
                    }
                    result = num1 / num2;
                    break;

                default:
                    Console.WriteLine("❌ Невідома операція.");
                    return;
            }

            Console.WriteLine($"✅ Результат: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("❌ Помилка: некоректне число.");
        }
    }
}

