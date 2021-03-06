using System;

namespace Proyecto_Final_B.Clases
{
    public class Juego : Contenido
    {
        private string genero;
        private uint score;

        public Juego(string nombre, string genero, uint score) : base(nombre)
        {
            Genero = genero;
            Score = score;
        }

        public string Genero
        {
            get => genero; set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrEmpty(value) || value.Length <= 3)
                {
                    throw new Exception("verifique el genero del juego no esta vacio, con espacios en blanco y que tenga como minimo cuatro letras");
                }
                else
                {
                    genero = value;
                }
            }
        }

        public uint Score
        {
            get => score; set
            {
                if (value >= 0 && value <= 1000)
                {
                    score = value;
                }
                else
                {
                    throw new Exception("el valor de cada juego debe de estar comprendidio entre 0 y 1000");
                }
            }
        }
    }
}
