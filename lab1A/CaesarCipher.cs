using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class CaesarCipher
    {
        public static char Encrypt(char c, int offset)
        {
            char first = char.IsUpper(c) ? 'A' : 'a';
            int result = ((c + offset - first) % 26) + first;
            return (char)result;
        }
        public static char Decrypt(char c, int offset)
        {
            char first = char.IsUpper(c) ? 'A' : 'a';
            int result = (c - offset - first) % 26;
            result = result >= 0 ? result : 26 + result;
            result += first;
            return (char)result;
        }
    }
}
