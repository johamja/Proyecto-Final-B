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

        // metodo accesor para el atributo nombre 
        public string Nombre
        {
            get => nombre; set
            {
                // si el nombres corresponde a valor nulo // si el nombre tiene spacios vacios // si el nombre tiene el tamaño menor a 5 letras  
                if (String.IsNullOrEmpty(value) || value.Length <= 3)
                {
                    // lanzamos un error
                    throw new Exception("Revisar el nombre de la atracción");
                }
                // de lo contrario pasamos el valor al atributo nombre del objeto contenido
                else
                {
                    nombre = value;
                }
            }
        }
    }
}
