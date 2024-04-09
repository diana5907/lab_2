using System;

namespace lab_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool exit = false; // Прапорець для виходу з програми
            while (!exit)
            {
                Console.WriteLine("Введіть ціле число з діапазону від 10 до 20 або натисніть '+' для виходу:");
                string input = Console.ReadLine();

                if (input == "+")
                {
                    exit = true; // Встановлюємо прапорець для виходу
                }
                else if (int.TryParse(input, out int number))
                {
                    string word = NumberConverter.ConvertNumberToWord(number);
                    Console.WriteLine($"Введене число у словах: {word}");
                }
                else
                {
                    Console.WriteLine("Невірний формат введеного числа. Будь ласка, введіть число з умови або натисніть '+' для виходу.");
                }
            }
        }
    }

    public class NumberConverter
    {
        // Метод для конвертації числа в слово
        public static string ConvertNumberToWord(int number)
        {
            switch (number)
            {
                case 10:
                    return "десять";
                case 11:
                    return "одинадцять";
                case 12:
                    return "дванадцять";
                case 13:
                    return "тринадцять";
                case 14:
                    return "чотирнадцять";
                case 15:
                    return "п'ятнадцять";
                case 16:
                    return "шістнадцять";
                case 17:
                    return "сімнадцять";
                case 18:
                    return "вісімнадцять";
                case 19:
                    return "дев'ятнадцять";
                case 20:
                    return "двадцять";
                default:
                    return "не вірне число";
            }
        }
    }
}
