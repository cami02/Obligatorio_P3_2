using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BienvenidosUY_2.Models;

namespace BienvenidosUY_2.Models
{
    public class FotoAnuncio
    {
        public int Id { get; set; }

        public string Foto1
        { get { return Foto1; } set { Foto1 = value; } }

        public string Foto2
        { get { return Foto2; } set { Foto2 = value; } }

        public string Foto3
        { get { return Foto3; } set { Foto3 = value; } }

        public string Foto4
        { get { return Foto4; } set { Foto4 = value; } }

        public string Foto5
        { get { return Foto5; } set { Foto5 = value; } }

        public Anuncio IdAnuncio
        { get { return idAnuncio; } set { idAnuncio = value; } }

        Anuncio idAnuncio;
        

        #region Validaciones

        public bool validarFotos()
        {
            return (Foto1 != "" && Foto2 != "" && Foto3 != "");
        }
        #endregion
    }
}