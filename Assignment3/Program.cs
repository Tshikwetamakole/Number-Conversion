using System;

namespace NumberToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (up to 4 digits): ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"In words: {ConvertToWords(number)}");
        }

        static string ConvertToWords(int number)
        {
            if (number < 0 || number > 9999)
                return "Number out of range. Only 0 to 9999 is supported.";

            if (number == 0)
                return "Zero";

            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] thousands = { "", "Thousand" };

            string words = "";

            if (number / 1000 > 0)
            {
                words += ones[number / 1000] + " " + thousands[1] + " ";
                number %= 1000;
            }

            if (number / 100 > 0)
            {
                words += ones[number / 100] + " Hundred ";
                number %= 100;
            }

            if (number >= 10 && number <= 19)
            {
                words += teens[number - 10] + " ";
            }
            else
            {
                if (number / 10 > 0)
                {
                    words += tens[number / 10] + " ";
                }

                if (number % 10 > 0)
                {
                    words += ones[number % 10] + " ";
                }
            }

            return words.Trim();
        }
    }
}
