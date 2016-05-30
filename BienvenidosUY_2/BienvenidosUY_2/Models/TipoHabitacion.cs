using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace BienvenidosUY_2.Models
{
    public class TipoHabitacion
    {

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }


        #region Validaciones


        public bool Validar()
        {
            return this.Tipo != "";
        }

        #endregion
    }
}