using System;
using System.Text.RegularExpressions;

class Ex2
{
    static void Main()
    {
        string pattern = @"(\+\d{3})(([-](2)[-]\d{3}[-])|([\s](2)[\s]\d{3}[\s]))\d{4}"; // шаблон
        /*
        (\+\d{3})   плюс і 3 цифри
        (
            (   розділення лише дефісом
                [-]   дифіс
                (2)   двійка
                [-]   дифіс
                \d{3}   3 цифри
                [-]   дифіс
            ) |
            (   розділення лише пробілом
                [\s]   пробіл
                (2)   двійка
                [\s]   пробіл
                \d{3}   3 цифри
                [\s]   пробіл
            )
        )
        \d{4}   4 цифри
        */

        while (true)
        {
            string? action = Console.ReadLine();

            if (action?.ToUpper() == "END")
            {
                break;
            }

            if (action != null)
            {
                if (Regex.IsMatch(action, pattern))
                {
                    Console.WriteLine(action);
                }
            }
        }
        Console.ReadKey();
    }
}
