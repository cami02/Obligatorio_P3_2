using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BienvenidosUY_2.Models;

namespace BienvenidosUY_2.Models
{
    public class Servicio
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Tipo
        { get { return Tipo; } set { Tipo = value; } }
    }
}