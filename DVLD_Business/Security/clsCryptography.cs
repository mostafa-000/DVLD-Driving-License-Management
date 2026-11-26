using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business.Security
{
    public class clsCryptography
    {
        public static string ComputeHash(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public static bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            if (string.IsNullOrEmpty(enteredPassword) || string.IsNullOrEmpty(storedHashedPassword))
                return false;

            string hashedInput = ComputeHash(enteredPassword);
            return string.Equals(hashedInput, storedHashedPassword, StringComparison.OrdinalIgnoreCase);
        }
    }
}