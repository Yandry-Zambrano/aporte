using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenObserver
{
	class RegistroGym
	{
		//creamos la clase registro gym que nos notificara que nos inscribimos al gym
		//estos metodos son de las notificaciones de inscripcion
		internal void nuevoAlumno(string nombre)
		{
			Console.Write("Nuevo Alumno ¡Enhorabuena , te has inscrito al gym.");
		}

		internal void registra(RegistroGym registroGym)
		{
			Console.WriteLine("Nuevo Registro ¡Enhorabuena , te has inscrito al gym.");

		}

		internal void nuevoAlumno(RegistroGym registroGym)
		{
			Console.WriteLine("Nuevo notificacion , te has Inscrito.\n");
		}
	}
}
