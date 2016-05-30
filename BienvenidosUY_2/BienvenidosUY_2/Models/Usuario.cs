using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
 
namespace BienvenidosUY_2.Models
{
    public class Usuario
    {

        #region Atributos y Properties
        [Key]
        public int Id { get; set; }

        public string Email
        { get { return Email; } set { Email = value; } }


        public string Pass
        { get { return Pass; } set { Pass = value; } }


        public string Nombre
        { get { return Nombre; } set { Nombre = value; } }


        public string Apellido
        { get { return Apellido; } set { Apellido = value; } }

        public string Direccion
        { get { return Direccion; } set { Direccion = value; } }

        public int Celular
        { get { return Celular; } set { Celular = value; } }


        public string DescripcionUsuario
        { get { return DescripcionUsuario; } set { DescripcionUsuario = value; } }


        public string Foto
        { get { return Foto; } set { Foto = value; } }

        private string tipoUsuario = "Registrado";

        #endregion



        #region Validaciones        

        // Método que valida la contraseña ingresada por el usuario
        public bool ValidarPassword()
        {
            return this.validarPasswordLargoMinimo(this.Pass) && this.tieneMayusculasPassword(this.Pass) &&
                   this.tieneMinusculasPassword(this.Pass) && this.tieneDigitosPassword(this.Pass) &&
                   this.tieneCaracterImprimiblePassword(this.Pass);
        }

        // Método que valida el largo de la contraseña
        public bool validarPasswordLargoMinimo(string pass)
        {
            return pass.Length >= 8;
        }
        // Método que valida que la contraseña contenga mayúsculas
        public bool tieneMayusculasPassword(string pass)
        {
            return pass.Any(c => char.IsUpper(c));
        }
        // Método que valida que la contraseña contenga minúsculas
        public bool tieneMinusculasPassword(string pass)
        {
            return pass.Any(c => char.IsLower(c));
        }
        // Método que valida que la contraseña contenga dígitos
        public bool tieneDigitosPassword(string pass)
        {
            return pass.Any(char.IsDigit);
        }
        // Método que valida que la contraseña contenga al menos un caracter imprimible no alfabético ni numérico.
        public bool tieneCaracterImprimiblePassword(string pass)
        {
            return !Regex.IsMatch(pass, @"^[0-9a-zA-Zs]+$");
        }
        // Método que valida que la descripción contenga hasta 250 caracteres.
        public bool validarLargoDescripcion(string descripcionUsuario)
        {
            return descripcionUsuario.Length <= 250;
        }
        // Método que valida que el nombre y el apellido solo contengan caracteres especiales y espacio.
        public bool validarNombreApellido()
        {
            return (Regex.IsMatch(this.Nombre, @"^([a-zA-Z]+\s)*[a-zA-Z]+$") && Regex.IsMatch(this.Apellido, @"^([a-zA-Z]+\s)*[a-zA-Z]+$"));
        }

        #endregion


        #region Seguridad

        public static string Encriptar(string pass)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(pass);
            data = x.ComputeHash(data);
            return System.Text.Encoding.ASCII.GetString(data);
        }


        public static bool MatchHash(string pass, string HashUser)
        {
            HashUser = Encriptar(HashUser);
            if (HashUser == pass)
                return true;
            else
                return false;

        }
        #endregion
    }
}