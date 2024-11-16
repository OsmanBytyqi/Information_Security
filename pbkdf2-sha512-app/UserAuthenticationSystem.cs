using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace desktop_app
{
    internal class UserAuthenticationSystem
    {
        private const int SaltSize = 128;
        private const int Iterations = 210000;
        private const int KeySize = 512;

        private Dictionary<string, (byte[] Salt, byte[] Key)> users = new Dictionary<string, (byte[] Salt, byte[] Key)>();

        public void RegisterUser(string username, string password)
        {
            if (users.ContainsKey(username))
            {
                Console.WriteLine("User already exists. Please choose a different username.");
                return;
            }

            byte[] salt = GenerateSalt(SaltSize);
            byte[] key = GenerateKeyBytes(password, salt, Iterations, KeySize);

            users[username] = (salt, key);
            Console.WriteLine("User registered successfully!");
        }

        private byte[] GenerateSalt(int size)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[size];
                rng.GetBytes(salt);
                return salt;
            }
        }

        private byte[] GenerateKeyBytes(string password, byte[] salt, int iterations, int keySize)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA512))
            {
                return pbkdf2.GetBytes(keySize);
            }
        }

        private bool CompareKeys(byte[] key1, byte[] key2)
        {
            if (key1.Length != key2.Length)
                return false;

            for (int i = 0; i < key1.Length; i++)
            {
                if (key1[i] != key2[i])
                    return false;
            }

            return true;
        }

        public bool AuthenticateUser(string username, string password)
        {
            if (!users.ContainsKey(username))
            {
                Console.WriteLine("invalid Credentials");
                return false;
            }

            (byte[] storedSalt, byte[] storedKey) = users[username];
            byte[] computedKey = GenerateKeyBytes(password, storedSalt, Iterations, KeySize);
            if (CompareKeys(storedKey, computedKey))

            {
                Console.WriteLine("Authentication successfull");
                return true;
            }
            else
            {
                Console.WriteLine("invalid Credentials");
                return false;
            }
        }
    }
}
