using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Test.Data;

namespace Test.Class
{
    internal class FindKey
    {
        public static string key { get; set; }
        public static string FindKeys(List<string> cosets)
        {
            StringBuilder keyBuilder = new StringBuilder();

            foreach (string coset in cosets)
            {
                Dictionary<int, double> MIC = new Dictionary<int, double>();
                for (int l = 0; l < 26; l++)
                {
                    StringBuilder cosetBuilder = new StringBuilder();

                    for (int begin = 0; begin < coset.Length; begin++)
                    {
                        char elementofcoset = coset[begin];
                        int positioninalphabet = GetAlphabetPositions(elementofcoset);
                        int shift = (positioninalphabet - l + 26) % 26;
                        char shiftLetter = char.Parse(StaticData.alphabet[shift]);
                        cosetBuilder.Append(shiftLetter);
                    }
                    Dictionary<char, int> frequencyMap = CalculateFrequency(cosetBuilder.ToString());
                    double chiSquare = CalculateChiSquare(frequencyMap, StaticData.EnglishLetterFrequencies);
                    MIC.Add(l, chiSquare);
                }


                //// Convert shift to character
                // Find the shift with the highest MIC value
                int probableShift = MIC.OrderBy(pair => pair.Value).First().Key;

                // Convert the shift to character to get the probable key character
                char probableKeyChar = char.Parse(StaticData.alphabet[probableShift]);

                keyBuilder.Append(probableKeyChar);
            }

            return keyBuilder.ToString();
        }
        private static double CalculateChiSquare(Dictionary<char, int> observedFreq, Dictionary<char, double> expectedFreq)
        {
            double chiSquare = 0;
            int totalElements = observedFreq.Values.Sum(); // Calculate total count of elements

            foreach (var key in observedFreq.Keys)
            {
                double observed = observedFreq[key] / (double)totalElements; // Calculate observed frequency as a proportion
                double expected = expectedFreq[key] * totalElements / 100; // Adjust expected frequency to match the total elements

                chiSquare += Math.Pow(observed - expected, 2) / expected;
            }

            return chiSquare;
        }


        public static int GetAlphabetPositions(char letter)
        {
            // Convert the letter to uppercase for case-insensitive comparison
            char uppercaseLetter = char.ToUpper(letter);

            // Get the position of the letter in the alphabet
            int position = Array.IndexOf(StaticData.alphabet, uppercaseLetter.ToString());

            return position;
        }
        private static Dictionary<char, int> CalculateFrequency(string text)
        {
            Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char lowercaseChar = char.ToLower(c);

                    if (frequencyMap.ContainsKey(lowercaseChar))
                    {
                        frequencyMap[lowercaseChar]++;
                    }
                    else
                    {
                        frequencyMap[lowercaseChar] = 1;
                    }
                }
            }

            return frequencyMap;
        }

        public static void Start()
        {
            // Example usage
            List<string> cosets = new List<string>();

            foreach(var strings in KeyLenght.resultTupleList)
            {
                float average = strings.AverageSum;
                if (average > 0.05)
                {
                    cosets = strings.CipherText.Split(',').ToList();
                    key = FindKeys(cosets);
                }
            }
        }
    }
}
