using System;
using System.Numerics;
using System.Text;

namespace DigitalSignature
{
    class DSA
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        public static int FastPow(int a, int b, int mod)
        {
            int result = 1;
            a = a % mod;
            while (b > 0)
            {
                if ((b & 1) == 1)
                    result = (result * a) % mod;
                a = (a * a) % mod;
                b >>= 1;
            }
            return result;
        }

        public static int ModInverse(int a, int mod)
        {
            return FastPow(a, mod - 2, mod);
        }

        public static int Hash(string message, int p, int q)
        { 
            int H = 100;
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            foreach (byte b in bytes)
            {
                H = ((H + b) * (H + b)) % q;
            }
            return H;
        }

        public static (int r, int s) Sign(int p, int q, int g, int x, int k, int hash)
        {
            int r = FastPow(g, k, p) % q;
            if (r == 0) return (0, 0);
            int kInv = ModInverse(k, q);
            int s = (kInv * (hash + x * r)) % q;
            if (s == 0) return (0, 0);
            return (r, s);
        }

        public static int Verify(int p, int q, int g, int y, int r, int s, int hash)
        {
            if (r <= 0 || r >= q || s <= 0 || s >= q) return 0;
            
            int w = ModInverse(s, q);
            int u1 = (hash * w) % q;
            int u2 = (r * w) % q;
            int v = ((FastPow(g, u1, p) * FastPow(y, u2, p)) % p) % q;
            return v;
        }
    }
}
