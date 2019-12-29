using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;
using System.Data;
using System.Security.Cryptography;
using System.Security.Claims;

namespace Tripous.Identity
{
    /// <summary>
    /// Helper. Represents this library.
    /// </summary>
    static public class IdLib
    {
        static PasswordHasher fPasswordHasher;

 

        /// <summary>
        /// Generates and returns a password of a specified length.
        /// <para>Adapted from: https://codeshare.co.uk/blog/how-to-create-a-random-password-generator-in-c/ </para>
        /// </summary>
        static public string GeneratePassword(int Length = 10, string PasswordCharSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^*()_-+=[{]};:>|./?")
        {
            const int MinLength = 8;
            const int MaxLength = 128;
            const int MaxIdenticalConsecutiveChars = 2;

            if (Length < MinLength || Length > MaxLength)
            {
                return "Password length must be between 8 and 128.";
            }

            string Data = PasswordCharSet;

            char[] Password = new char[Length];
            int DataLength = Data.Length;

            bool Flag;
            Random Random = new Random();
            for (int CharPos = 0; CharPos < Length; CharPos++)
            {
                Password[CharPos] = Data[Random.Next(DataLength - 1)];

                Flag = CharPos > MaxIdenticalConsecutiveChars && Password[CharPos] == Password[CharPos - 1] && Password[CharPos - 1] == Password[CharPos - 2];

                if (Flag)
                {
                    CharPos--;
                }
            }

            return string.Join(null, Password);
        }


        /// <summary>
        /// Encrypts a byte buffer with MD5 and returns the string
        /// </summary>
        static public string ToMD5Hash(this byte[] Buffer)
        {
            byte[] HashBuffer = MD5.Create().ComputeHash(Buffer);
            return BitConverter.ToString(HashBuffer).Replace("-", "").ToLowerInvariant();
        }
        /// <summary>
        /// Encrypts a string with MD5 and returns the string
        /// </summary>
        static public string ToMD5Hash(this string Text)
        {
            return Encoding.UTF8.GetBytes(Text).ToMD5Hash();
        }

        /// <summary>
        /// Creates an authenticated <see cref="ClaimsIdentity"/> identity and the <see cref="ClaimsPrincipal"/> principal and assigns the context's Principal property.
        /// <para>No claims are added to the identity.</para>
        /// <para>Returns the newly created identity for the client code to add any needed claims to it.</para>
        /// </summary>
        static public ClaimsPrincipal CreateAuthenticatedIdentity(string AuthenticationType)
        {
            // NOTE: setting the second parameter actually authenticates the identity (IsAuthenticated returns true)
            ClaimsIdentity Identity = new ClaimsIdentity(new Claim[] { }, AuthenticationType);
            ClaimsPrincipal Principal = new ClaimsPrincipal(Identity);
            return Principal;
        }

        /* properties */
        /// <summary>
        /// The object used in hashing passwords.
        /// </summary>
        static public PasswordHasher PasswordHasher
        {
            get 
            {
                if (fPasswordHasher == null)
                    fPasswordHasher = new PasswordHasher();
                return fPasswordHasher;             
            }
            set { fPasswordHasher = value; }
        }
    }
}
