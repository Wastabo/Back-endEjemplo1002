using Back_endEjemplo.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using Back_endEjemplo.Models;

namespace Back_endEjemplo.Services
{
    public class PeliculasServices
    {
        public List<Pelicula> ObtenerPeliculas()
        {

            var pelicula1 = new Pelicula()
            {
                Titulo = "Superman",
                Duracion = 123,
                Pais = "USA",
                Publicacion = new DateTime(2015, 11, 12)
            };

            var pelicula2 = new Pelicula()
            {
                Titulo = "Spiderman",
                Duracion = 130,
                Pais = "USA",
                Publicacion = new DateTime(2013, 02, 12)
            };

            return new List<Pelicula> { pelicula1, pelicula2 };
        }
    }
}