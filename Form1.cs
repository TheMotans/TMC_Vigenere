
using Microsoft.VisualBasic.Devices;

namespace Test
{
    public partial class Form1 : Form
    {
        static string[] alphabet { get; set; } = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public Form1()
        {
            InitializeComponent();
            //string encryptedText = Encrypt("ABC", "BBB");
            //labelEncrypt.Text = encryptedText;
            //string decrypttext = DecryptVigenere("BCD", "BBB");
            //textBoxMessage.Text = decrypttext;
            KasiskiTest();
        }
        static string Encrypt(string plaintext, string keyword)
        {
            string encryptedText = "";

            for (int i = 0, j = 0; i < plaintext.Length; i++)
            {
                string c = plaintext[i].ToString().ToUpper();
                string a = keyword[j % keyword.Length].ToString().ToUpper();
                if (alphabet.Contains(c))
                {
                    int position = alphabet.ToList().IndexOf(c);
                    int key = alphabet.ToList().IndexOf(a);
                    int sum = (position + key) % 26;
                    encryptedText += alphabet[sum];
                    j++;
                }
                else
                {
                    encryptedText += c;
                }
            }
            return encryptedText;
        }

        static string DecryptVigenere(string ciphertext, string key)
        {
            string plaintext = "";

            for (int i = 0, j = 0; i < ciphertext.Length; i++)
            {
                string c = ciphertext[i].ToString().ToUpper();
                string a = key[j % key.Length].ToString().ToUpper();

                if (alphabet.Contains(c))
                {
                    int position = alphabet.ToList().IndexOf(c);
                    int shift = alphabet.ToList().IndexOf(a);
                    plaintext += alphabet[(position - shift + 26) % 26];
                    j++;
                }
                else
                {
                    plaintext += c;
                }
            }
            return plaintext;
        }


        static void KasiskiTest()
        {
            string ciphertext = "JFNHCQZXKRLBPGFISWYJFNHCQZXKRLBPGFISW";

            int minRepeatDistance = 1; // Lungimea minimă a secvențelor repetate
            Dictionary<string, List<int>> repeatedSequences = new Dictionary<string, List<int>>();

            // Căutare secvențe repetate
            for (int i = 0; i < ciphertext.Length - minRepeatDistance; i++)
            {
                for (int j = i + minRepeatDistance; j < ciphertext.Length; j++)
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
    



        private void button1_Click(object sender, EventArgs e)
        {
            string plaintext = textBoxMessage.Text;
            string keyword = textBoxKey.Text; // Your keyword here
            string encryptedText = Encrypt(plaintext, keyword);

            labelEncrypt.Text = encryptedText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ciphertext = labelEncrypt.Text; // Textul cifrat
            int keyLength = textBoxKey.TextLength; // Lungimea cheii (ar trebui să fie cunoscută)

            for (int i = 0; i < char.MaxValue; i++)
            {
                for (int j = 0; j < char.MaxValue; j++)
                {
                    for (int k = 0; k < char.MaxValue; k++)
                    {
                        string key = $"{(char)i}{(char)j}{(char)k}";
                        string plaintext = DecryptVigenere(ciphertext, key);
                        textBoxMessage.Text = plaintext;
                        textBoxKey.Text = key;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ciphertext = labelEncrypt.Text;
            string keyword = textBoxKey.Text; // Your keyword here
            string decrypttext = DecryptVigenere(ciphertext, keyword);

            textBoxMessage.Text = decrypttext;
        }
    }
}
