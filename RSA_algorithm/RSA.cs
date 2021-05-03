using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSA_algorithm
{
    class RSA
    {
        // Znalezienie odwrotności.
        private long Inv(long e, long phiN)
        {
            for (long i = 0; i < phiN; i++)
            {
                if (e * i % phiN == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        // Potęgowanie.
        private long Pow(long a, long b)
        {
            long result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }

        // Szyfrowanie.
        public long Encode(long word)
        {
            // Dwie duże liczby pierwsze.
            long p = 5, q = 7;
            // Iloczyn pq;
            long n = p * q;
            // Phi(n)
            long phiN = (p - 1) * (q - 1);
            // Wybranie e - publiczne
            // Wybranie d - prywatne
            long e = 11;
            long d = Inv(e, phiN);

            long result = Pow(word, e) % n;
            return result;
        }

        // Deyszyfracja.
        public long Decode(long word, long d)
        {
            long p = 5, q = 7;
            long n = p * q;

            long result = Pow(word, d) % n;
            return result;
        }
    }
}
