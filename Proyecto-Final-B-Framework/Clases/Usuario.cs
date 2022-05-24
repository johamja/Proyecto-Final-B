using System;

namespace Proyecto_Final_B.Clases
{
    public class Usuario
    {
        private uint id;
        private string nombre;
        private DateTime fecha_de_afiliacion;
        Random aleatorio = new Random();

        // constructor 
        public Usuario(string nombre, DateTime fecha_de_afiliacion)
        {
            id = (uint)aleatorio.Next(100000, 999999); // Id aleatorio
            Nombre = nombre;
            if (fecha_de_afiliacion <= DateTime.Now) // validacion de la fecha_de_afiliacion no sea meyor a la fecha actual
            {
                this.fecha_de_afiliacion = fecha_de_afiliacion;
            }
            else
            {
                throw new Exception("la fecha de afiliacion ");
            }
        }
        // constructor / sobrecarga
        public Usuario(uint id, string nombre, DateTime fecha_de_afiliacion)
        {
            Id = id;
            Nombre = nombre;
            if (fecha_de_afiliacion <= DateTime.Now) // validacion de la fecha_de_afiliacion no sea meyor a la fecha actual
            {
                this.fecha_de_afiliacion = fecha_de_afiliacion;
            }
            else
            {
                throw new Exception("la fecha de afiliacion ");
            }
        }

        public uint Id
        {
            get => id; set
            {
                // validamos que el nuevo id de la sobrecarga este en el rango 1000000 - 2000000
                if (value >= 1000000 && value <= 2000000)
                {
                    id = value;
                }
                else
                {
                    throw new Exception("Error de id no se encuentra en el rango 1000000 - 2000000");
                }
            }
        }
        public string Nombre
        {
            get => nombre; set
            {
                if (String.IsNullOrEmpty(value) || value.Length <= 3) // si el nombres corresponde a valor nulo / si el nombre tiene el tamaño menor o igual 3 letras 
                {
                    throw new Exception("Revisar el nombre de la atracción");
                }
                else
                {
                    nombre = value;
                }
            }
        }
        public DateTime Fecha_de_afiliacion
        {
            get => fecha_de_afiliacion; set
            {
                if (value <= DateTime.Now) // validacion de la fecha_de_afiliacion no sea meyor a la fecha actual
                {
                    value = fecha_de_afiliacion;
                }
                else
                {
                    throw new Exception("la fecha de afiliacion es mayor a " + DateTime.Now);
                }
            }
        }
    }
}
