using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace seguridad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Validación de datos
            Console.Write("Ingrese su edad: ");
			string entrada = Console.ReadLine();

			if (int.TryParse(entrada, out int edad) && edad > 0)
			{
				Console.WriteLine("Edad válida: " + edad);
			}
			else
			{
				Console.WriteLine("Entrada inválida!");
			}
            Console.Write("Ingrese su correo electrónico: ");
            string correo = Console.ReadLine();

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(correo, patron))
            {
                Console.WriteLine("Correo válido!");
            }
            else
            {
                Console.WriteLine("Formato de correo inválido!");
            }
            //Manejo de contraseñas
            string passwordh = "Patito123";
            string salt = Guid.NewGuid().ToString();
            string passwordConSalt = passwordh + salt;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(passwordConSalt));
                string hash = Convert.ToBase64String(bytes);
                Console.WriteLine("Contraseña original: " + passwordh);
                Console.WriteLine("Salt: " + salt);
                Console.WriteLine("Contraseña con salt: " + passwordConSalt);
                Console.WriteLine("Hash: " + hash);
            }
            //Prevención de inyección SQL
            //Es más seguro usar firstname y password que solo strings
            string firstname = "Melissa";
            string password = "123";

            string hashedPassword = HashPassword(password);

            string connectionString = "Server=localhost\\SQLEXPRESS;Database=UserDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Users WHERE firstname = @firstname AND password = @password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        Console.WriteLine("Acceso concedido!");
                    }
                    else
                    {
                        Console.WriteLine("Usuario o contraseña incorrectos!");
                    }
                }
            }
        }

        // Método auxiliar fuera de Main
        static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}