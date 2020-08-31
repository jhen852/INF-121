/*
 * Created by SharpDevelop.
 * User: JHENNY
 * Date: 31/08/2020
 * Time: 10:56 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * 
 * CLASE #1
 */
using System;

namespace Ej1POO
{
	/// <summary>
	/// Description of Cuaderno.
	/// </summary>
	public class Cuaderno
	{
		//Atributos
		private String marca,tamaño,tipo;
		private int precio;
		
		//Metodos
		// datos son parametros que vamos a mandar
		public void leer(){//Realiza una tarea especifica para menjar objetos
			marca=Console.ReadLine();
			tamaño=Console.ReadLine();
			tipo=Console.ReadLine();
			//Aqui estamos castiando
			precio=int.Parse(Console.ReadLine());
		}
		
		public void mostrar(){
			Console.Write(marca+" "+tamaño+" "+tipo+" "+precio);
		}
		
	}
}
