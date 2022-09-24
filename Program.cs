using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            LibroDeHechizos libro = new LibroDeHechizos();
            libro.Hechizos = new Hechizo[]{ new Hechizo() };

            Mago Istari = new Mago("Istari");
            Istari.BastonMagico = new BastonMagico();
            Istari.LibroDeHechizos = libro;

            Enano Gruñon = new Enano("Gruñon");
            Gruñon.Hacha = new Hacha();
            Gruñon.Casco = new Casco();
            Gruñon.Escudo = new Escudo();

            Console.WriteLine($"Gruñon tiene {Gruñon.Vida} de vida");
            Console.WriteLine($"Istari ataca a Gruñon con {Istari.Ataque}");

            Gruñon.OfensaDeAtaque(Istari.Ataque);

            Console.WriteLine($"Gruñon tiene {Gruñon.Vida} de vida");

            Gruñon.Curar();

            Console.WriteLine($"Gruñon tiene {Gruñon.Vida} de vida restaurada");
        }
    }
}
