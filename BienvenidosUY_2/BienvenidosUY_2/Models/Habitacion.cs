using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BienvenidosUY_2.Models;

namespace BienvenidosUY_2.Models
{
    public class Habitacion
    {


        [Key]
        [Required]
        public int Id { get; set; }

        public int idTipoHabitacion { get; set; }

        //PREGUNTAR A LA PROFESORA
        [ForeignKey("idTipoHabitacion")]
        [Required]
        public TipoHabitacion Tipohabitacion
        { get { return Tipohabitacion; } set { Tipohabitacion = value; } }


        [Required]
        public TipoBanio IdTipoBanio
        { get { return IdTipoBanio; } set { IdTipoBanio = value; } }

        [Required]
        public int CantHuesped
        { get { return CantHuesped; } set { CantHuesped = value; } }

        [Required]
        public Alojamiento IdAlojamiento
        { get { return IdAlojamiento; } set { IdAlojamiento = value; } }


    }
}