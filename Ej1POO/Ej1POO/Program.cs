/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 31/08/2020
 * Time: 10:55 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej1POO
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// creacion Obejtos
			//NombreClase objeto= new NombreClase ();
			
			Cuaderno A= new Cuaderno(); // un objeto
			
			A.leer();
			A.mostrar();
			
			// otro objeto
			
			Cuaderno Z= new Cuaderno();
			
			Console.WriteLine("Otro Objeto");
			
			Z.leer();
			Z.mostrar();
			
			Console.ReadKey(true);
		}
	}
}