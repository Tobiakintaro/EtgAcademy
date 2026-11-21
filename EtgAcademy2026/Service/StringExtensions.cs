using System;
using System.Collections.Generic;
using System.Text;

namespace EtgAcademy2026.Service
{
    public static class StringExtensions
    {


        public static string ToTitleCase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            var words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            return string.Join(" ", words);
        }


        public static string MaskString(this string input, int unmaskedStartLength = 2, int unmaskedEndLength = 2, char maskChar = '*')
        {
            if (string.IsNullOrEmpty(input) || input.Length <= unmaskedStartLength + unmaskedEndLength)
            {
                return input;
            }
            var maskedPartLength = input.Length - unmaskedStartLength - unmaskedEndLength;
            var maskedPart = new string(maskChar, maskedPartLength);
            return input.Substring(0, unmaskedStartLength) + maskedPart + input.Substring(input.Length - unmaskedEndLength);
        }


    }
}
