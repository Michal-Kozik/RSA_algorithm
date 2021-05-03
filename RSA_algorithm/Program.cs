using System;

namespace RSA_algorithm
{
    class Program
    {
        // https://www.comparitech.com/blog/information-security/rsa-encryption/

        static void Main(string[] args)
        {
            RSA rsa = new RSA();
            long result = rsa.Encode(2);
            Console.WriteLine(result);
            result = rsa.Decode(result, 11);
            Console.WriteLine(result);

        }
    }
}
