using System;
using System.Collections.Generic;

namespace Proyecto_Final_B.Clases
{
    public class Cuenta
    {
        private float Puntos_Acumulados_P;
        private float Puntos_Acumulados_S;
        private float Puntos_Acumulados_J;
        private Usuario usuario;
        private List<Contenido> contenido = new List<Contenido>();

        public Cuenta(Usuario usuario, List<Contenido> contenido)
        {
            Usuario = usuario;
            if (contenido.Count >= 1)
            {
                foreach (Contenido elemento1 in contenido) // verificamos la lista si tiene elementos repetidos
                {
                    foreach (Contenido elemento2 in contenido)
                    {
                        if (elemento1 == elemento2)
                        {
                            break;
                            throw new Exception("la lista de contenido no puede tener elementos repetidos");
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                this.contenido = contenido;
            }
            else
            {
                throw new Exception("se requiere almenos un elemento en la lista");
            }
        }

        public Usuario Usuario
        {
            get => usuario; set
            {
                if (value is Usuario)
                {
                    usuario = value;
                }
                else
                {
                    throw new Exception("se requiere de un usuario");
                }
            }
        }
        public List<Contenido> Contenido
        {
            get => contenido; set
            {
                if (value.Count >= 1)
                {
                    foreach (Contenido elemento1 in value) // verificamos la lista si tiene elementos repetidos
                    {
                        foreach (Contenido elemento2 in value)
                        {
                            if (elemento1 == elemento2)
                            {
                                break;
                                throw new Exception("la lista de contenido no puede tener elementos repetidos");
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    contenido = value;
                }
                else
                {
                    throw new Exception("se requiere almenos un elemento en la lista");
                }
            }
        }

        public float Puntos_Totales()
        {
            return (Puntos_Acumulados_P + Puntos_Acumulados_S + Puntos_Acumulados_J);
        }

        // acumulacion de puntos @peliculas
        public void Puntos(Pelicula pelicula, TimeSpan consumo)
        {
            try
            {
                foreach (Contenido elemento in contenido) // buscar en la lista de contenido
                {
                    if (elemento is Pelicula && elemento.Nombre == pelicula.Nombre) // verificar si el elemento de la lista es un objeto de tipo <Pelicula>
                    {
                        if (consumo <= pelicula.Duracion && consumo >= new TimeSpan(0, 0, 0)) // verificar si el consumo de la pelicula es menor o igual a la duracion
                        {
                            // realizamos proceso de adicion de puntos de usuario
                            float total = (float)consumo.TotalMinutes / 60;
                            Puntos_Acumulados_P += total;
                            break;
                        }
                        else
                        {
                            throw new Exception("se encuentra un error con el consumo, no se encuentra en el rango 0:0:0 a " + pelicula.Duracion);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("error en realizar el calculo de los puntos " + error);
            }
        }
        // acumulacion de puntos @series 
        public void Puntos(Serie serie, int consumo)
        {
            try
            {
                foreach (Contenido elemento in contenido) // buscar en la lista de contenido
                {
                    if (elemento is Serie && elemento.Nombre == serie.Nombre) // verificar si el elemento de la lista es un objeto de tipo <Pelicula>
                    {
                        int total = 0;

                        for (int i = 0; i < serie.Capitulos_temporada.Length; i++)
                        {
                            total += serie.Capitulos_temporada[i].Count;
                        }

                        if (consumo <= total && consumo >= 0)
                        {
                            Puntos_Acumulados_S = consumo / 3;
                        }
                        else
                        {
                            throw new Exception("se encuentra un error con el consumo, no se encuentra en el rango 0 a " + total);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("error en realizar el calculo de los puntos " + error);
            }
        }
        // acumulacion de puntos @juegos
        public void Puntos(Juego juego, int consumo)
        {
            try
            {
                foreach (Contenido elemento in contenido) // buscar en la lista de contenido
                {
                    if (elemento is Juego && elemento.Nombre == juego.Nombre) // verificar si el elemento de la lista es un objeto de tipo <Pelicula>
                    {
                        if (consumo <= juego.Score && consumo >= 0)
                        {
                            Puntos_Acumulados_J += (consumo / 300);
                        }
                        else
                        {
                            throw new Exception("se encuentra un error con el consumo, no se encuentra en el rango 0 a " + juego.Score);
                        }

                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("error en realizar el calculo de los puntos " + error);
            }
        }
    }
}
