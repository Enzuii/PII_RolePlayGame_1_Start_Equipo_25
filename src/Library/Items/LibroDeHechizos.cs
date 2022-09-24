using System.Collections.Generic;

namespace RoleplayGame
{
    public class LibroDeHechizos
    {
        public Hechizo[] Hechizos { get; set; }
        
        public int Ataque
        {
            get
            {
                int valor = 0;
                foreach (Hechizo hechizo in this.Hechizos)
                {
                    valor += hechizo.Ataque;
                }
                return valor;
            }
        }

        public int Defensa
        {
            get
            {
                int value = 0;
                foreach (Hechizo hechizo in this.Hechizos)
                {
                    value += hechizo.Defensa;
                }
                return value;
            }
        }
    }
}