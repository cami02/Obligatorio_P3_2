using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BienvenidosUY_2.Models;


namespace BienvenidosUY_2.Models
{
    public class Anuncio
    {

        public int Id { get; set; }

        public string NombreAnuncio
        { get { return NombreAnuncio; } set { NombreAnuncio = value; } }

        public string DescripcionAnuncio
        { get { return DescripcionAnuncio; } set { DescripcionAnuncio = value; } }

        public string Linea1
        { get { return Linea1; } set { Linea1 = value; } }

        public string Linea2
        { get { return Linea2; } set { Linea2 = value; } }

        public int PrecioBase
        { get { return PrecioBase; } set { PrecioBase = value; } }

        public Habitacion Habitacion
        { get { return Habitacion; } set { Habitacion = value; } }


        #region Validaciones

        public bool validarDescripcion()
        {
            return this.DescripcionAnuncio.Length <= 250;
        }

        public bool validarNombreAnuncio()
        {
            return this.NombreAnuncio.Length <= 128;
        }

        public bool ValidarAnuncio()
        {
            return (validarDescripcion() && validarNombreAnuncio());
        }
        #endregion
    }
}