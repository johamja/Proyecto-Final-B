using System;
using System.Collections.Generic;

namespace Proyecto_Final_B.Clases
{
    public class Serie : Contenido
    {

        private List<string> temporada;
        private List<string>[] capitulos_temporada;

        public Serie(string nombre, List<string> temporada, List<string>[] capitulos_temporada) : base(nombre)
        {

            // TEMPORADA
            if (temporada.Count < 1) // validar que la lista tenga elementos
            {
                throw new Exception("el numero de temporadas es menor a 1, nesesitas tener una temporada añadida");
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
                throw new Exception("la matriz de capitulos por temporada tiene " + capitulos_temporada.Length + " temporadas");
            }
            else if (capitulos_temporada.Length < temporada.Count)
            {
                throw new Exception("la matriz tiene menos temporadas (" + capitulos_temporada.Length + ") que en la lista de temporadas (" + temporada.Count + ")");
            }
            else if (capitulos_temporada.Length > temporada.Count)
            {
                throw new Exception("la matriz tiene mas temporadas (" + capitulos_temporada.Length + ") que en la lista de temporadas (" + temporada.Count + ")");
            }
            else if (capitulos_temporada.Length == temporada.Count)
            {
                for (uint i = 0; i < capitulos_temporada.Length; i++) // recorriendo la matriz 
                {
                    if (capitulos_temporada[i] == null) // verificando si en la matriz faltan lista de capitulos
                    {
                        throw new Exception("en la temporada " + (i + 1) + " no se encuentra una lista de capitulos");
                    }
                    else if (capitulos_temporada[i].Count >= 1) // verificando que la lista tenga mas de un elemento
                    {
                        foreach (string elemento in capitulos_temporada[i]) // recorriendo la lista de la matriz en la posicion i
                        {
                            if (String.IsNullOrEmpty(elemento)) // detectando elementos nulos o vacios
                            {
                                throw new Exception("Error se encuentra caracteres nulos en la lista de los capitulos temporada " + (i + 1));
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("error en la lista de capitulos temporada " + i); // errores desconocidos en las listas 
                    }
                }
                this.capitulos_temporada = capitulos_temporada;
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
                if (value.Count < 1) // validar que la lista tenga elementos
                {
                    throw new Exception("el numero de temporadas es menor a 1, nesesitas tener una temporada añadida");
                }
                else if (value.Count >= 1)
                {
                    foreach (string elemento in value) // recorriendo las temporadas
                    {
                        if (String.IsNullOrEmpty(elemento)) // verificando elementos nulos en las temporadas / verificando que no sea un espacio vacio
                        {
                            throw new Exception("Error se encuentra caracteres nulos o vacios en la lista de temporadas");
                        }
                    }
                    temporada = value;
                }
                else
                {
                    throw new Exception("error en la lista de temporadas");
                }
            }
        }
        public List<string>[] Capitulos_temporada
        {
            get => capitulos_temporada; set
            {
                if (value.Length < 0) // verificando si la matriz tiene temporadas 
                {
                    throw new Exception("la matriz de capitulos por temporada tiene " + value.Length + " temporadas");
                }
                else if (value.Length < temporada.Count)
                {
                    throw new Exception("la matriz tiene menos temporadas (" + value.Length + ") que en la lista de temporadas (" + temporada.Count + ")");
                }
                else if (value.Length > temporada.Count)
                {
                    throw new Exception("la matriz tiene mas temporadas (" + value.Length + ") que en la lista de temporadas (" + temporada.Count + ")");
                }
                else if (value.Length == temporada.Count)
                {
                    for (uint i = 0; i < value.Length; i++) // recorriendo la matriz 
                    {
                        if (value[i] == null) // verificando si en la matriz faltan lista de capitulos
                        {
                            throw new Exception("en la temporada " + (i + 1) + " no se encuentra una lista de capitulos");
                        }
                        else if (value[i].Count >= 1) // verificando que la lista tenga mas de un elemento
                        {
                            foreach (string elemento in value[i]) // recorriendo la lista de la matriz en la posicion i
                            {
                                if (String.IsNullOrEmpty(elemento)) // detectando elementos nulos o vacios
                                {
                                    throw new Exception("Error se encuentra caracteres nulos en la lista de los capitulos temporada " + (i + 1));
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("error en la lista de capitulos temporada " + i); // errores desconocidos en las listas 
                        }
                    }
                    capitulos_temporada = value;
                }
                else
                {
                    throw new Exception("error en la matriz de capitulos"); // error desconocido en la matriz
                }
            }
        }
    }
}
