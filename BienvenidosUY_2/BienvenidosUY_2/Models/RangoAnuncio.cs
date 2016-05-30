using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BienvenidosUY_2.Models;

namespace BienvenidosUY_2.Models
{
    public class RangoAnuncio
    {

        [Required]
        public Anuncio IdAnuncio
        { get { return IdAnuncio; } set { IdAnuncio = value; } }

        [Required]
        public DateTime Fecha1
        { get { return Fecha1; } set { Fecha1 = value; } }

        [Required]
        public DateTime Fecha2
        { get { return Fecha2; } set { Fecha2 = value; } }

        [Required]
        public int Precio
        { get { return Precio; } set { Precio = value; } }

        [Required]
        public int Id { get; set; }


        #region Validaciones

        public bool ValidacionesRango()
        {
            return (validarRango() && validarFechasRango() && validarFechas());
        }

        public bool validarRango()
        {
            return (this.Fecha1 != null && this.Fecha2 != null);
        }

        public bool validarFechas()
        {
            return (this.Fecha1 < this.Fecha2);
        }

        public bool validarFechasRango()
        {
            return (this.Fecha1 > (Convert.ToDateTime("1/1/2016")) && this.Fecha2 < (Convert.ToDateTime("31/12/2016")));

        }

        public bool validarRangoBase(DateTime fechaDesde, DateTime fechaHasta, List<RangoAnuncio> Rangos)
        {
            int i = 0;
            bool bandera = false;
            while (i < Rangos.Count)
            {
                if (this.IdAnuncio.Id == Rangos[i].Id)
                {
                    if (fechaDesde > Rangos[i].Fecha2 && fechaDesde < fechaHasta)
                    {
                        bandera = true;
                    }
                    else
                    {
                        bandera = false;
                    }
                }
                i++;
            }
            return bandera;
        }


        #endregion
    }
}