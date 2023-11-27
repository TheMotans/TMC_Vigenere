using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Class
{
    internal class KeyLenght
    {
        public static List<(int KeyLength, string CipherText, float AverageSum)> resultTupleList { get; set; }
        public static void IndexOfCoincedence(string ciphertext)
        {
                        int maxkeylenght = 10;//cîte 
            int cipherLenght = ciphertext.Length;
            List<AnalysisResult> results = new List<AnalysisResult>();
            List<string> cosets = new List<string>();

            for (int k = 1; k < maxkeylenght; k++)//pasul
            {
                string newcipher = "";
                //int divede = cipherLenght / k;//pînă la cîte element adăugăm în strin
                for (int row = 0; row < k; row++)
                {
                    int forverification = k;
                    //int lastpostion = row;
                    for (int col = row; col < cipherLenght; col += k)
                    {
                        char firstletter = ciphertext[col];
                        //lastpostion = lastpostion + k;
                        newcipher = newcipher + firstletter.ToString();
                    }

                    float suma = FrequencyAnalise(newcipher);

                    results.Add(new AnalysisResult
                    {
                        CipherText = newcipher,
                        Sum = suma,
                        KeyLength = k
                    });
                    newcipher = "";
                }
                var averageByK = results
                    .GroupBy(result => result.KeyLength)
                    .Select(group => new
                    {
                        KeyLength = group.Key,
                        CipherText = string.Join(",", group.Select(result => result.CipherText)),
                        AverageSum = group.Average(result => result.Sum)
                    });
                // Convert the anonymous type to a named tuple
                resultTupleList = averageByK
                    .Select(result => (result.KeyLength, result.CipherText, result.AverageSum))
                    .ToList();

            }
        }
        private static float FrequencyAnalise(string ciphertext)
        {
            Dictionary<string, int> repeatedSequences = new Dictionary<string, int>();
            for (int i = 0; i < ciphertext.Length; i++)
            {
                char firstletter = ciphertext[i];
                if (!repeatedSequences.ContainsKey(firstletter.ToString()))
                {
                    int numberOfrepeat = 0;
                    foreach (char letter in ciphertext)
                    {
                        if (letter == firstletter)
                            numberOfrepeat++;
                    }
                    repeatedSequences.Add(firstletter.ToString(), numberOfrepeat);
                }
            }
            float suma = CalculateIndexOfCoincidence(repeatedSequences, ciphertext.Length);
            return suma;
        }
        private static float CalculateIndexOfCoincidence(Dictionary<string, int> repeatedSequences, int numberOfElements)
        {
            float sum = 0;

            foreach (var letter in repeatedSequences)
            {
                float proportion = (float)letter.Value / numberOfElements * (((float)letter.Value - 1) / (numberOfElements - 1));
                sum += proportion;
            }

            return sum;
        }
    }
}
