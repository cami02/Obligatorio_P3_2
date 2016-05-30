using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BienvenidosUY_2.Models;

namespace BienvenidosUY_2.Models
{
    public class Alojamiento
    {
        [Key]
        public int Id
        { get { return Id; } set { Id = value; } }

        [Required]
        public TipoAlojamiento Tipo
        { get { return Tipo; } set { Tipo = value; } }

        [Required]
        public string Ciudad
        { get { return Ciudad; } set { Ciudad = value; } }

        [Required]
        public string Barrio
        { get { return Barrio; } set { Barrio = value; } }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "La capacidad del alojamiento debe ser mayor a 0")]
        public int Capacidad
        { get { return Capacidad; } set { Capacidad = value; } }

        [Required]
        public string IdAnfitrion
        { get { return IdAnfitrion; } set { IdAnfitrion = value; } }


        #region Validaciones



        public bool ValidarCapacidadBarrio()
        {
            bool bandera = false;
            if (Capacidad >= 0 && Ciudad != "" && Barrio != "")
            {
                bandera = true;
            }
            return bandera;
        }


        #endregion
    }
}