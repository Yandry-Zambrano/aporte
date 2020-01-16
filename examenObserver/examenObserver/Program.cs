using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenObserver
{
	class Program
	{
		static void Main(string[] args)
		{
           // ingresamos el nombre de la persona a inscribirse
			Console.WriteLine("ingrese el nombre");
			 string nuevo = Console.ReadLine();

			//ingresamos la edad de la persona a inscribirse
			Console.WriteLine("ingrese la edad ");
			int edad = int.Parse(Console.ReadLine());

			//instanciamos la clase registro de inscripcion
			RegistroInscrpcion matriculador = new RegistroInscrpcion();

			//instanciamos la clase RegistroGYm
			RegistroGym alumno = new RegistroGym();

			//llamamos los metodos de la clase registro de inscripcion y de registro gym
			// los metodos son las diferentes notificaciones de inscripcion que estamos registrando en cad clase 
			matriculador.alta(new Notificacion());
			matriculador.especial(new Notificacion());
			matriculador.registra(new Notificacion());

			alumno.registra(new RegistroGym());
			alumno.nuevoAlumno(new RegistroGym());


			Console.ReadKey();

		}
	}
}
