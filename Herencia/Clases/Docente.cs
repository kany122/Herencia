using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia.Clases
{
    public class Docente : Persona
    {
       public string Asignatura { get; set; }
        public int AñosExperiencia { get; set; }
        public Docente(string cedula, string nombre, string apellido, DateOnly fechaNacimiento, string asignatura, int añosExperiencia)
            : base(cedula, nombre, apellido, fechaNacimiento)
        {
            Asignatura = asignatura;
            AñosExperiencia = añosExperiencia;
        }

        public void enseñar()
        {
            Console.WriteLine($"Soy {nombre} {apellido}, enseño la asignatura de {Asignatura} y tengo {AñosExperiencia} años de experiencia.");
        }
    }
}
