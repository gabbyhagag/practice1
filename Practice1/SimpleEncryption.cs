using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class SimpleEncryption
    {
        //my code
        public static string Encrypt(string text, int n) // gabbyg - abbyg - abbygb - abygb - abygby - abgby
        {
            if (text == null) return text;
            if (n < 1) return text;
            StringBuilder sb = new StringBuilder(text);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (text.Length + 1) / 2; j++)
                {
                    sb.Append(sb[j]);
                    sb.Remove(j, 1);
                }
            }
            return sb.ToString();
        }

        public static string Decrypt(string encryptedText, int n) // abgby - ab , gby - aby ,gb - abby , g - gabby
        {
            if (encryptedText == null) return encryptedText;
            if (n < 1) return encryptedText;
            for (int i = 0; i < n; i++)
            {
                StringBuilder sb = new StringBuilder(encryptedText.Substring(0, encryptedText.Length / 2));
                StringBuilder sb1 = new StringBuilder(encryptedText.Substring(encryptedText.Length / 2));
                int c = 0;
                if (encryptedText.Length % 2 == 0) c = 1;
                for (int j = 0; j < (encryptedText.Length + 1) / 2; j++)
                {
                    sb.Insert(sb.Length - j - c, sb1[sb1.Length - 1]);
                    sb1.Remove(sb1.Length - 1, 1);
                    c++;
                }
                encryptedText = sb.ToString();
            }
            return encryptedText;
        }

    }
}
