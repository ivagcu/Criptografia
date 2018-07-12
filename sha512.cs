using System;
using System.Text;
using System.Security.Cryptography;

namespace Rextester
{
    class Random
    {
        public static void Main()
        {
            Console.WriteLine("Introduce una clave: ");
            string input = Console.ReadLine();

            var bytes = Encoding.UTF8.GetBytes(input);
            using (var hash = SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));

                Console.WriteLine("La clave hash generada es: "+ hashedInputStringBuilder.ToString());
            }
        }
    }
}
