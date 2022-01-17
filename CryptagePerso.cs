using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agirman_Cryptage
{
    class CryptagePerso 
    {
        static public void VigenereCryptage(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++) s[i] = char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for(int i=0;i<s.Length;i++)
            {
                if (char.IsLetter(s[i]))
                {
                    s[i]= (char)(s[i]+key[j]-'A');
                    if (s[i] > 'Z') s[i] = (char)(s[i] - 'Z' + 'A' - 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1;

            }
        }

         static public void VigenereDecryptage(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++)
                s[i] = Char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    s[i] = s[i] >= key[j] ?
                        (char) (s[i] - key[j] + 'A'):
                        (char)('A' + ('Z' - key[j] + s[i] - 'A') + 1);
                }

                j = j + 1 == key.Length ? 0 : j + 1;
            }
        }
    }
}
