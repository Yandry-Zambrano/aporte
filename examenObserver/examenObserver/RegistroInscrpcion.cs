using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenObserver
{
	class RegistroInscrpcion
	{
		// en la clase registro gym se procede a crear la inscripcionn de las personas creando una lista
		//la lista es de tipo NuevaInscripcionGym
		public void alta(Incripcion nueva)
		{
			Console.WriteLine("creando inscripcion .", nueva.Edad, nueva.Nombre);
			(new Notificacion()).enviarNotificacion(nueva.Nombre, nueva.Edad);
			if (nueva.PrimeraMatricula)
			{
				(new RegistroGym()).nuevoAlumno(nueva.Nombre);
			}
		}
		//creamos la lista de tipo nuevainscripciongym y se guardara en observers
		public List<NuevaInscripcionGym> observers = new List<NuevaInscripcionGym>();
		public virtual void registra(NuevaInscripcionGym observer)
		{
			observers.Add(observer);
		}

		//creamos el metodo el cual contiene un foreach y un mensaje de que ya nos hemos registrado
		//en el foreach lo que se guardara es el nombre y la edad de la persona
		public virtual void especial(Incripcion nueva)
		{
			Console.WriteLine("Creada la inscripcion .", nueva.Edad, nueva.Nombre);
			foreach (NuevaInscripcionGym observer in observers)
			{
				observer.nueva(nueva);
			}
		}
	}
}
