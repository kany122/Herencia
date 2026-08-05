using System;
using System.Collections.Generic;
using System.Text;



namespace Herencia.Clases
{
      public class Estudiante : Persona
      {
         public string carrera { get; set; }
         public int semestre { get; set; }


           public Estudiante(string cedula, string nombre, string apellido, DateOnly fechaNacimiento, string carrera, int semestre)
                : base(cedula, nombre, apellido, fechaNacimiento)
           {
                this.carrera = carrera;
                this.semestre = semestre;
           }
           
           public void estudiar()
        {
            Console.WriteLine($"Soy {nombre} {apellido} de la carrera {carrera} y estoy en el semestre {semestre}.");
        }


    }
}
