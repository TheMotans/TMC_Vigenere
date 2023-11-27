using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data;

namespace Test.Class
{
    internal class Encrypt
    {
        public static string CryptMessage(string plaintext, string keyword)
        {
            string encryptedText = "";

            for (int i = 0, j = 0; i < plaintext.Length; i++)
            {
                string c = plaintext[i].ToString().ToUpper();
                string a = keyword[j % keyword.Length].ToString().ToUpper();
                if (StaticData.alphabet.Contains(c))
                {
                    int position = StaticData.alphabet.ToList().IndexOf(c);
                    int key = StaticData.alphabet.ToList().IndexOf(a);
                    int sum = (position + key) % 26;
                    encryptedText += StaticData.alphabet[sum];
                    j++;
                }
                else
                {
                    encryptedText += c;
                }
            }
            return encryptedText;
        }
    }
}
