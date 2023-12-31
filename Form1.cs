﻿
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Test.Class;
using Test.Data;
using static System.Net.Mime.MediaTypeNames;

namespace Test
{
    public partial class Form1 : Form
    {
        //static string[] alphabet { get; set; } = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        //public static readonly Dictionary<char, double> EnglishLetterFrequencies = new Dictionary<char, double>
        //{
        //    {'a', 0.08167},
        //    {'b', 0.01492},
        //    {'c', 0.02782},
        //    {'d', 0.04253},
        //    {'e', 0.12702},
        //    {'f', 0.02228},
        //    {'g', 0.02015},
        //    {'h', 0.06094},
        //    {'i', 0.06966},
        //    {'j', 0.00153},
        //    {'k', 0.00772},
        //    {'l', 0.04025},
        //    {'m', 0.02406},
        //    {'n', 0.06749},
        //    {'o', 0.07507},
        //    {'p', 0.01929},
        //    {'q', 0.00095},
        //    {'r', 0.05987},
        //    {'s', 0.06327},
        //    {'t', 0.09056},
        //    {'u', 0.02758},
        //    {'v', 0.00978},
        //    {'w', 0.02360},
        //    {'x', 0.00150},
        //    {'y', 0.01974},
        //    {'z', 0.00074}
        //};

        public Form1()
        {
            InitializeComponent();
        }
        //{
        //    string encryptedText = "";

        //    for (int i = 0, j = 0; i < plaintext.Length; i++)
        //    {
        //        string c = plaintext[i].ToString().ToUpper();
        //        string a = keyword[j % keyword.Length].ToString().ToUpper();
        //        if (alphabet.Contains(c))
        //        {
        //            int position = alphabet.ToList().IndexOf(c);
        //            int key = alphabet.ToList().IndexOf(a);
        //            int sum = (position + key) % 26;
        //            encryptedText += alphabet[sum];
        //            j++;
        //        }
        //        else
        //        {
        //            encryptedText += c;
        //        }
        //    }
        //    return encryptedText;
        //}

        //static string DecryptVigenere(string ciphertext, string key)
        //{
        //    string plaintext = "";

        //    for (int i = 0, j = 0; i < ciphertext.Length; i++)
        //    {
        //        string c = ciphertext[i].ToString().ToUpper();
        //        string a = key[j % key.Length].ToString().ToUpper();

        //        if (alphabet.Contains(c))
        //        {
        //            int position = alphabet.ToList().IndexOf(c);
        //            int shift = alphabet.ToList().IndexOf(a);
        //            plaintext += alphabet[(position - shift + 26) % 26];
        //            j++;
        //        }
        //        else
        //        {
        //            plaintext += c;
        //        }
        //    }
        //    return plaintext;
        //}


        static void KasiskiTest()
        {
            string ciphertext = "JFNHCQZXKRLBPGFISWYJFNHCQZXKRLBPGFISW";
            int[] repeatdistance = { 3, 4 };
            Dictionary<string, double> frecventNormal = new Dictionary<string, double>()
            {
                {"e", 12.7 },{"t",9.1},{"a",8.2},{"o",7.5},{"i",7},{"n",6.7},{"s",6.3},{"h",6.1},{"r",6},{"d",4.3},{"l",4},{"c",2.8},{"u",2.8},{"m",2.4},{"w",2.4},{"f",2.2},{"g",2}
                ,{"y",2},{"p",1.9},{"b",1.5},{"v",1},{"k",0.8},{"j",0.15},{"x",0.15},{"q",0.1},{"z",0.07}
            };

            int[] minRepeatDistance = { 3, 4 }; // Lungimea minimă a secvențelor repetate
            Dictionary<string, List<int>> repeatedSequences = new Dictionary<string, List<int>>();

            // Căutare secvențe repetate
            for (int min = 0; min < 2; min++)
            {
                for (int i = 0; i < ciphertext.Length - minRepeatDistance[min]; i++)
                {
                    for (int j = i + minRepeatDistance[min]; j < ciphertext.Length; j++)
                    {
                        string sequence = ciphertext.Substring(i, j - i);

                        if (ciphertext.Substring(j).Contains(sequence))
                        {
                            if (!repeatedSequences.ContainsKey(sequence))
                                repeatedSequences[sequence] = new List<int>();

                            repeatedSequences[sequence].Add(j - i);
                        }
                    }
                }
            }

            // Identificarea factorilor comuni
            var commonFactors = new List<int>();
            foreach (var sequence in repeatedSequences)
            {
                List<int> distances = sequence.Value;
                if (distances.Count >= 2)
                {
                    for (int i = 0; i < distances.Count - 1; i++)
                    {
                        for (int j = i + 1; j < distances.Count; j++)
                        {
                            int factor = GCD(distances[i], distances[j]);
                            commonFactors.Add(factor);
                        }
                    }
                }
            }

            // Afișarea factorilor comuni
            Console.WriteLine("Factori comuni:");
            foreach (int factor in commonFactors.Distinct())
            {
                Console.WriteLine(factor);
            }
        }

        // Funcție pentru calculul celui mai mare divizor comun
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }


        //static float FrequencyAnalise(string ciphertext)
        //{
        //    Dictionary<string, int> repeatedSequences = new Dictionary<string, int>();
        //    for (int i = 0; i < ciphertext.Length; i++)
        //    {
        //        char firstletter = ciphertext[i];
        //        if (!repeatedSequences.ContainsKey(firstletter.ToString()))
        //        {
        //            int numberOfrepeat = 0;
        //            foreach (char letter in ciphertext)
        //            {
        //                if (letter == firstletter)
        //                    numberOfrepeat++;
        //            }
        //            repeatedSequences.Add(firstletter.ToString(), numberOfrepeat);
        //        }
        //    }
        //    float suma = CalculateIndexOfCoincidence(repeatedSequences, ciphertext.Length);
        //    return suma;
        //}

        //public void KeyLenght(string ciphertext)
        //{
        //    //int maxKeyLength = 10;  // Maximum key length to consider
        //    //int cipherLength = ciphertext.Length;  // Length of the ciphertext

        //    //// Iterate through different key lengths
        //    //for (int k = 1; k < maxKeyLength; k++)
        //    //{
        //    //    List<string> substrings = new List<string>();  // List to store substrings for the current key length
        //    //    List<AnalysisResult> results = new List<AnalysisResult>();

        //    //    // Generate substrings based on the current key length
        //    //    for (int i = 0; i < k; i++)
        //    //    {
        //    //        StringBuilder substringBuilder = new StringBuilder();  // StringBuilder to efficiently build substrings

        //    //        // Construct substring by taking characters at intervals of k
        //    //        for (int j = i; j < cipherLength; j += k)
        //    //        {
        //    //            substringBuilder.Append(ciphertext[j]);
        //    //        }
        //    //        float suma = FrequencyAnalise(substringBuilder.ToString());

        //    //        results.Add(new AnalysisResult
        //    //        {
        //    //            CipherText = substringBuilder.ToString(),
        //    //            Sum = suma,
        //    //            KeyLength = k
        //    //        });
        //    //        //newcipher = "";
        //    //        //substrings.Add(substringBuilder.ToString());  // Add the constructed substring to the list
        //    //    }
        //    //    var averageByK = results
        //    //        .GroupBy(result => result.KeyLength)
        //    //        .Select(group => new
        //    //        {
        //    //            KeyLength = group.Key,
        //    //            CipherText = string.Join(" , ", group.Select(result => result.CipherText)),
        //    //            AverageSum = group.Average(result => result.Sum)
        //    //        });
        //    //    dataGridView1.Rows.Clear();

        //    //    foreach (var result in averageByK)
        //    //    {
        //    //        dataGridView1.Rows.Add(result.KeyLength, result.AverageSum, result.CipherText);
        //    //    }
        //    // Now 'substrings' contains the substrings for the current key length (k)
        //    // You can perform further analysis or display the substrings as needed
        //    //Console.WriteLine($"Key Length: {k}");
        //    //foreach (var substring in substrings)
        //    //{
        //    //    Console.WriteLine(substring);
        //    //}
        //    //Console.WriteLine();
        //    //}


        //    int maxkeylenght = 10;//cîte 
        //    int cipherLenght = ciphertext.Length;
        //    List<AnalysisResult> results = new List<AnalysisResult>();
        //    List<string> cosets = new List<string>();

        //    for (int k = 1; k < maxkeylenght; k++)//pasul
        //    {
        //        string newcipher = "";
        //        //int divede = cipherLenght / k;//pînă la cîte element adăugăm în strin
        //        for (int row = 0; row < k; row++)
        //        {
        //            int forverification = k;
        //            //int lastpostion = row;
        //            for (int col = row; col < cipherLenght; col += k)
        //            {
        //                char firstletter = ciphertext[col];
        //                //lastpostion = lastpostion + k;
        //                newcipher = newcipher + firstletter.ToString();
        //            }

        //            float suma = FrequencyAnalise(newcipher);

        //            results.Add(new AnalysisResult
        //            {
        //                CipherText = newcipher,
        //                Sum = suma,
        //                KeyLength = k
        //            });
        //            newcipher = "";
        //        }
        //        var averageByK = results
        //            .GroupBy(result => result.KeyLength)
        //            .Select(group => new
        //            {
        //                KeyLength = group.Key,
        //                CipherText = string.Join(" , ", group.Select(result => result.CipherText)),
        //                AverageSum = group.Average(result => result.Sum)
        //            });
        //        dataGridView1.Rows.Clear();

        //        foreach (var result in averageByK)
        //        {
        //            dataGridView1.Rows.Add(result.KeyLength, result.AverageSum, result.CipherText);
        //        }
        //    }
        //}

        //public double CalculateChisquared(string coset)
        //{
        //    //Dictionary<char, double> expectedFrequencies = EnglishLetterFrequencies;

        //    //Dictionary<char, int> observedFrequencies = FrequencyAnalysis(coset);

        //    //double chiSquared = 0.0;

        //    //foreach (var kvp in observedFrequencies)
        //    //{
        //    //    char letter = kvp.Key;
        //    //    int observedFrequency = kvp.Value;
        //    //    double expectedFrequency = expectedFrequencies.ContainsKey(letter) ? expectedFrequencies[letter] * coset.Length : 0.0;

        //    //    if (expectedFrequency > 0) // Avoid division by zero
        //    //    {
        //    //        chiSquared += Math.Pow(observedFrequency - expectedFrequency, 2) / expectedFrequency;
        //    //    }
        //    //}

        //    //return chiSquared;
        //}
        public Dictionary<char, int> FrequencyAnalysis(string text) //
        {
            Dictionary<char, int> frequencyDictionary = new Dictionary<char, int>();

            foreach (char character in text)
            {
                if (char.IsLetter(character)) // Optional: You can filter only letters if needed
                {
                    char lowercaseChar = char.ToLower(character); // Convert to lowercase for case-insensitive analysis

                    if (frequencyDictionary.ContainsKey(lowercaseChar))
                    {
                        frequencyDictionary[lowercaseChar]++;
                    }
                    else
                    {
                        frequencyDictionary[lowercaseChar] = 1;
                    }
                }
            }

            return frequencyDictionary;
        }

        //static float CalculateIndexOfCoincidence(Dictionary<string, int> repeatedSequences, int numberOfElements)
        //{
        //    float sum = 0;

        //    foreach (var letter in repeatedSequences)
        //    {
        //        float proportion = (float)letter.Value / numberOfElements * (((float)letter.Value - 1) / (numberOfElements - 1));
        //        sum += proportion;
        //    }

        //    return sum;
        //}



        private void buttonCryptMessage_Click(object sender, EventArgs e)
        {
            string plaintext = textBoxMessage.Text;
            string keyword = textBoxKey.Text; // Your keyword here
            string encryptedText = Encrypt.CryptMessage(plaintext, keyword);
            textBoxEncrypted.Text = encryptedText;
        }

        private void buttonAttackForceBrute_Click(object sender, EventArgs e)
        {
            //string ciphertext = textBoxEncrypted.Text; // Textul cifrat
            //int keyLength = textBoxKey.TextLength; // Lungimea cheii (ar trebui să fie cunoscută)
            //int maxvalue = StaticData.alphabet.Length;
            //if (keyLength > 1)
            //{
            //    for (int i = 0; i < maxvalue; i++)
            //    {
            //        for (int j = 0; j < maxvalue; j++)
            //        {
            //            for (int k = 0; k < maxvalue; k++)
            //            {
            //                string key = $"{StaticData.alphabet[i]}{StaticData.alphabet[j]}{StaticData.alphabet[k]}";
            //                string plaintext = Decrypt.DecryptVigenere(ciphertext, key);
            //                textBoxMessage.Text = plaintext;
            //                textBoxKey.Text = key;
            //            }
            //        }
            //    }
            //}

            AttackForceBrute.buttonAttackForceBrute_Click(textBoxEncrypted.Text, textBoxKey.TextLength);
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string ciphertext = textBoxEncrypted.Text;
            string keyword = textBoxKey.Text; // Your keyword here
            string decrypttext = Decrypt.DecryptVigenere(ciphertext, keyword);

            textBoxMessage.Text = decrypttext;
        }

        private void buttonIC_Click(object sender, EventArgs e)
        {
            string cipher = textBoxEncrypted.Text.ToLower();
            StringBuilder substringBuilder = new StringBuilder();  // StringBuilder to efficiently build substrings
            foreach (char c in cipher)
            {
                if (StaticData.EnglishLetterFrequencies.ContainsKey(c))
                {
                    substringBuilder.Append(c);
                }
                // Construct substring by taking characters at intervals of k
            }
            KeyLenght.IndexOfCoincedence(substringBuilder.ToString());

            dataGridView1.Rows.Clear();

            foreach (var result in KeyLenght.resultTupleList)
            {
                dataGridView1.Rows.Add(result.KeyLength, result.AverageSum, result.CipherText);
            }
        }

        private  void buttonFindKeyWithMIC_Click(object sender, EventArgs e)
        {
            //string cipher = textBoxEncrypted.Text.ToLower();
            //StringBuilder substringBuilder = new StringBuilder();  // StringBuilder to efficiently build substrings
            //foreach (char c in cipher)
            //{
            //    if (StaticData.EnglishLetterFrequencies.ContainsKey(c))
            //    {
            //        substringBuilder.Append(c);
            //    }
            //    // Construct substring by taking characters at intervals of k
            //}
            //List<int> potentialKeys = FindKey.FindKeysWithMIC(substringBuilder.ToString());
            FindKey.Start();
            textBoxKey.Text = FindKey.key;
        }
    }
}
