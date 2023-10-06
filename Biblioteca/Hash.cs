using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Hash
    {
        //Recibe un string con la clave original
        //Devuelve la clave hasheada
        public string GetHash(string password)
        {
            //var salt = BCrypt.Net.BCrypt.GenerateSalt(13);
            //var hash1 = BCrypt.Net.BCrypt.HashPassword(input, salt);
            var hash2 = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 8);
            return hash2;
        }

        //Recibe dos string, una clave origina y un hash para comparar
        //Si despues de hashear la clave son iguales retorna true
        //Si son diferentes devuelve false
        public bool ValidatePassword(string password, string hash)
        {
            var passHasheada = GetHash(password);
            bool valid = BCrypt.Net.BCrypt.EnhancedVerify(password, hash);
            return valid;
        }
    }
}
