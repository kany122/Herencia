using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia.Clases
{
    public class DirectorCarrera : Docente
    {
        public string Facultad { get; set; }
        public DirectorCarrera(string cedula, string nombre, string apellido, DateOnly fechaNacimiento, string asignatura, int añosExperiencia, string facultad)
            : base(cedula, nombre, apellido, fechaNacimiento, asignatura, añosExperiencia)
        {
            Facultad = facultad;
        }
        public void dirigir()
        {
            Console.WriteLine($"Soy {nombre} {apellido}, dirijo la carrera de {Facultad} y enseño la asignatura de {Asignatura} con {AñosExperiencia} años de experiencia.");
        }
    }
}
