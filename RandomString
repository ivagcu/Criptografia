using System;
using System.Linq;

private static Random random = new Random();
public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            string pass = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            Console.WriteLine("El pass generado es: " + pass);
            
            return pass;
            
        }
