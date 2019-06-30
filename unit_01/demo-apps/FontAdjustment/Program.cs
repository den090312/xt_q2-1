using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using UtilsLibrary;

namespace FontAdjustment
{
    internal class InputModel
    {
        [Required] [Range(1, 3)] public int Font { get; set; }
    }
    internal class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var fontSettings = new FontSettingsStorage();
            var input = new InputModel();
            fontSettings.PrintCurrentSettings();
            while (true)
            {
                PrintData();
                if (!int.TryParse(Console.ReadLine(), out var number))
                {
                    Console.WriteLine("Failed to parse user input.");
                    continue;
                }

                input.Font = number;

                if (!ValidateUserInput(input))
                {
                    continue;
                }

                fontSettings.ToggleFontSetting(input.Font);
                fontSettings.PrintCurrentSettings();
            }
        }

        private static bool ValidateUserInput(InputModel input)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(input);
            if (Validator.TryValidateObject(input, context, results, true))
            {
                return true;
            }

            foreach (var error in results)
            {
                Console.WriteLine(error.ErrorMessage);
            }

            return false;
        }

        private static void PrintData()
        {
            Console.WriteLine("Введите:");
            Console.WriteLine("\t1: Bold");
            Console.WriteLine("\t2: Italic");
            Console.WriteLine("\t3: Underline");
        }
    }
}
