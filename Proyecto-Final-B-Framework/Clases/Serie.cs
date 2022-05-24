using System;
using System.Collections.Generic;

namespace Proyecto_Final_B.Clases
{
    public class Serie : Contenido
    {

        // temporadas deven de ser un lista
        private List<string> temporada;
        // una matriz de listas que contiene las temporadas
        private List<string>[] capitulos_temporada;

        public Serie(string nombre, List<string> temporada, List<string>[] capitulos_temporada) : base(nombre)
        {

            // TEMPORADA
            // validar que la lista tenga elementos
            if (temporada.Count < 1)
            {
                throw new Exception("el numero de temporadas es 0, nesesitas tener una temporada añadida");
            }
            else if (temporada.Count >= 1)
            {
                foreach (string elemento in temporada) // recorriendo las temporadas
                {
                    if (String.IsNullOrEmpty(elemento)) // verificando elementos nulos en las temporadas / verificando que no sea un espacio vacio
                    {
                        throw new Exception("Error se encuentra caracteres nulos o vacios en la lista de temporadas");
                    }
                }
                this.temporada = temporada;
            }
            else
            {
                throw new Exception("error en la lista de temporadas");
            }

            // CAPITULOS TEMPORADA
            if (capitulos_temporada.Length < 0) // verificando si la matriz tiene temporadas 
            {
                throw new Exception("la serie tiene " + capitulos_temporada.Length + " temporadas en la lista de capitulos");
            }
            else if (capitulos_temporada.Length < temporada.Count)
            {
                throw new Exception("la serie tiene menos temporadas en la lista de capitulos (" + capitulos_temporada.Length + ") que en la lista de temporadas (" + temporada.Count + ")");
            }
            else if (capitulos_temporada.Length > temporada.Count)
            {
                throw new Exception("la serie tiene mas temporadas en la lista de capitulos (" + capitulos_temporada.Length + ") que en la lista de temporadas (" + temporada.Count + ")");
            }
            else if (capitulos_temporada.Length == temporada.Count)
            {
                for (uint i = 0; i < capitulos_temporada.Length; i++) // recorriendo la matriz 
                {
                    if (capitulos_temporada[i] == null) // verificando si en la matriz faltan lista de capitulos
                    {
                        throw new Exception("en la temporada " + (i + 1) + " no se encuentra nigun capitulo");
                    }
                    else if (capitulos_temporada[i].Count >= 1) // verificando que la lista tenga mas de un elemento
                    {
                        foreach (string elemento in capitulos_temporada[i]) // recorriendo la lista de la matriz en la posicion i
                        {
                            if (String.IsNullOrEmpty(elemento)) // detectando elementos nulos o vacios
                            {
                                throw new Exception("Error se encuentra caracteres nulos en la lista de los capitulos temporada " + (i + 1));
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("error en la lista de capitulos temporada " + i); // errores desconocidos en las listas 
                    }
                    this.capitulos_temporada = capitulos_temporada;
                }
            }
            else
            {
                throw new Exception("error en la matriz de capitulos"); // error desconocido en la matriz
            }
        }

        public List<string> Temporada
        {
            get => temporada; set
            {
                temporada = value;
            }
        }
        public List<string>[] Capitulos_temporada
        {
            get => capitulos_temporada; set
            {
                capitulos_temporada = value;
            }
        }
    }
}
