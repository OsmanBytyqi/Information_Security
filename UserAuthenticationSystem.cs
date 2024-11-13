using System.Security.Cryptography;

public class UserAuthenticationSystem
{
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
}
