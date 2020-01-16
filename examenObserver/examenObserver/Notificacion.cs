using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenObserver
{
	class Notificacion:Incripcion,NuevaInscripcionGym
	{
		//esta clase notificacion nos enviara los mensaje de que ya nos hemos inscrito
		// esta clase hereda de la clase inscripcion y la interfaz nuevainscipciongym
		public void Incripcion(Incripcion nueva)
		{
			throw new NotImplementedException();
		}

		 
		public void nueva(Incripcion nueva)
		{
			Console.Write("Nuevo notificacion , te haz inscrito al gym.\n", nueva.Nombre, nueva.Edad);

		}
		// esta clase recibe como parametro el nombre y la edad el cual nos notificara
		//un mensaje de biemvenido
		internal void enviarNotificacion(string Nombre, int Edad)
		{
			Console.Write("Nuevo email: bienvenido , te has inscrito al gym.\n", Nombre, Edad);
		}
	}
}
