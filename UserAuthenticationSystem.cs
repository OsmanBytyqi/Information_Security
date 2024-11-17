using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json;
using InformationSecurity.DTOs;

namespace InformationSecurity
{
    public class UserAuthenticationSystem
    {
        private const int SaltSize = 128;
        private const int Iterations = 210000;
        private const int KeySize = 512;
        private const string FilePath = "users.json";

        private Dictionary<string, UserKeyDTO> users;

        public UserAuthenticationSystem()
        {
            users = LoadUsers();
        }

        public void RegisterUser(string username, string password)
        {
            if (users.ContainsKey(username))
            {
                Console.WriteLine("User already exists. Please choose a different username.");
                return;
            }

            byte[] salt = GenerateSalt(SaltSize);
            byte[] key = GenerateKeyBytes(password, salt, Iterations, KeySize);

            users[username] = new UserKeyDTO
            {
                Salt = Convert.ToBase64String(salt),
                Key = Convert.ToBase64String(key)
            };
            SaveUsers();
            Console.WriteLine("User registered successfully!");
        }

        public bool AuthenticateUser(string username, string password)
        {
            if (!users.ContainsKey(username))
            {
                Console.WriteLine("Invalid credentials");
                return false;
            }

            UserKeyDTO user = users[username];
            byte[] storedSalt = Convert.FromBase64String(user.Salt);
            byte[] storedKey = Convert.FromBase64String(user.Key);
            byte[] computedKey = GenerateKeyBytes(password, storedSalt, Iterations, KeySize);

            if (CompareKeys(storedKey, computedKey))
            {
                Console.WriteLine("Authentication successful");
                return true;
            }
            {
                Console.WriteLine("Invalid credentials");
                return false;
            }
        }

        private byte[] GenerateSalt(int size)
        {
            using var rng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[size];
            rng.GetBytes(salt);
            return salt;
        }

        private byte[] GenerateKeyBytes(string password, byte[] salt, int iterations, int keySize)
        {
            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA512);
            return pbkdf2.GetBytes(keySize);
        }

        private bool CompareKeys(byte[] key1, byte[] key2)
        {
            if (key1.Length != key2.Length) return false;

            for (int i = 0; i < key1.Length; i++)
            {
                if (key1[i] != key2[i]) return false;
            }

            return true;
        }

        private void SaveUsers()
        {
            try
            {
                var serializedData = JsonSerializer.Serialize(users);
                File.WriteAllText(FilePath, serializedData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving users: {ex.Message}");
            }
        }

        private Dictionary<string, UserKeyDTO> LoadUsers()
        {
            try
            {
                if (!File.Exists(FilePath)) return new Dictionary<string, UserKeyDTO>();

                string jsonData = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<Dictionary<string, UserKeyDTO>>(jsonData) ?? new Dictionary<string, UserKeyDTO>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading users: {ex.Message}");
                return new Dictionary<string, UserKeyDTO>();
            }
        }
    }
}

