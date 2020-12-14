using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"[@]{1}[#]+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])[@]{1}[#]+";
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                Regex regex = new Regex(pattern);
                Match match = regex.Match(text);

                if (!regex.IsMatch(text))
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    string barcode = match.Groups["barcode"].Value;
                    StringBuilder sb = new StringBuilder();

                    for (int k = 0; k < barcode.Length; k++)
                    {
                        if (char.IsDigit(barcode[k]))
                        {
                            sb.Append(barcode[k]);
                        }
                    }
                    string output = sb.ToString();

                    if (output == string.Empty)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {output}");
                    }
                }
            }
        }
    }
}
