using Test.Data;

namespace Test.Class
{
    internal class Decrypt
    {
        public static string DecryptVigenere(string ciphertext, string key)
        {
            string plaintext = "";

            for (int i = 0, j = 0; i < ciphertext.Length; i++)
            {
                string c = ciphertext[i].ToString().ToUpper();
                string a = key[j % key.Length].ToString().ToUpper();

                if (StaticData.alphabet.Contains(c))
                {
                    int position = StaticData.alphabet.ToList().IndexOf(c);
                    int shift = StaticData.alphabet.ToList().IndexOf(a);
                    plaintext += StaticData.alphabet[(position - shift + 26) % 26];
                    j++;
                }
                else
                {
                    plaintext += c;
                }
            }
            return plaintext;
        }
    }
}
