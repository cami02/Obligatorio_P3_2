using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BienvenidosUY_2.Models;

namespace BienvenidosUY_2.Models
{
    public class ServicioAlojamiento
    {

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public Alojamiento Alojamiento
        { get { return Alojamiento; } set { Alojamiento = value; } }

        [Required]
        public Servicio Servicio
        { get { return Servicio; } set { Servicio = value; } }



        #region Validaciones


        public bool Validar()
        {
            return this.Servicio.Id >= 0 && this.Alojamiento.Id >= 0;
        }

        #endregion

    }
}