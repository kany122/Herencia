using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia.Clases
{
    public class Persona
    {
  
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateOnly FechaNacimiento { get; set; }


        public Persona(string cedula, string nombre, string apellido, DateOnly fechaNacimiento)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {nombre} {apellido} y mi cédula es {cedula}. Nací el {FechaNacimiento.ToString("dd/MM/yyyy")}.");
        }




    }
}
