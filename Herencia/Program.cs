
using Herencia.Clases;

Persona objPersonal = new Persona("123456789", "Sebastian", "Veliz", new DateOnly(1990, 5, 15));

Console.WriteLine("Persona 1");
objPersonal.Saludar();

Console.WriteLine();
Console.WriteLine("objEstudiante1 1");
Estudiante objEstudiante1 = new Estudiante("987654321", "Juan", "Perez", new DateOnly(2000, 10, 20), "Desarrollo de Software", 2);
objEstudiante1.Saludar();
objEstudiante1.estudiar();

Console.WriteLine();
Console.WriteLine("objDocente1 1");
Docente objDocente1 = new Docente("456789123", "Maria", "Gonzalez", new DateOnly(1985, 3, 10), "Matemáticas", 10);
objDocente1.Saludar();
objDocente1.enseñar();
Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Director 1");
DirectorCarrera objDirectorCarrera = new DirectorCarrera("321654987", "Carlos", "Rodriguez", new DateOnly(1975, 7, 25), "Gestión de Proyectos", 15, "Facultad de Ingeniería");
objDirectorCarrera.Saludar();
objDirectorCarrera.enseñar();
objDirectorCarrera.dirigir();
Console.ReadLine();
