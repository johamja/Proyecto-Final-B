using System;

namespace Proyecto_Final_B.Clases
{
    public class Pelicula : Contenido
    {

        private TimeSpan duracion;
        private byte calificacion;

        public Pelicula(string nombre, TimeSpan duracion, byte calificacion) : base(nombre)
        {
            if (duracion.Days >= 1)
            {
                throw new Exception("una pelicula no puede durar un dia");
            }
            else if (duracion.Hours > 4)
            {
                throw new Exception("una pelicula no puede dirar mas de 4 horas");
            }
            else
            {
                this.Duracion = duracion;
            }

            this.Calificacion = calificacion;
        }

        public TimeSpan Duracion
        {
            get => duracion; set
            {
                duracion = value;
            }
        }
        public byte Calificacion
        {
            get => calificacion; set
            {
                if (value > 6)
                {
                    throw new Exception("la calificacion solo tiene como parametros [0,1,2,3,4,5] ");
                }
                else
                {
                    calificacion = value;
                }
            }
        }
    }
}
