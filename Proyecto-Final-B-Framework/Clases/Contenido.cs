using System;

namespace Proyecto_Final_B.Clases
{
    public class Contenido
    {
        private string nombre; //nombre para las peliculas, series y juegos

        public Contenido(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre
        {
            get => nombre; set
            {
                if (String.IsNullOrEmpty(value) || value.Length <= 3) // que el nombre no sea nulo y que sea mayor que 3
                {
                    throw new Exception("el nombre no tiene que ser un dato nulo y tiene que ser mayor que 3");
                }
                else
                {
                    nombre = value;
                }
            }
        }
    }
}
