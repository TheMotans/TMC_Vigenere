using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data;

namespace Test.Class
{
    internal class AttackForceBrute
    {
        public static void buttonAttackForceBrute_Click(string ciphertext, int keyLength)
        {
            //string ciphertext = textBoxEncrypted.Text; // Textul cifrat
            //int keyLength = textBoxKey.TextLength; // Lungimea cheii (ar trebui să fie cunoscută)
            int maxvalue = StaticData.alphabet.Length;
            if (keyLength > 1)
            {
                for (int i = 0; i < maxvalue; i++)
                {
                    for (int j = 0; j < maxvalue; j++)
                    {
                        for (int k = 0; k < maxvalue; k++)
                        {
                            string key = $"{StaticData.alphabet[i]}{StaticData.alphabet[j]}{StaticData.alphabet[k]}";
                            string plaintext = Decrypt.DecryptVigenere(ciphertext, key);
                            //textBoxMessage.Text = plaintext;
                            //textBoxKey.Text = key;
                        }
                    }
                }
            }
        }
    }
}
