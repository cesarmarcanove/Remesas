// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class remesas5 {

		static void Main(string[] args) {
			// Listando las variables
			double env;
			double p;
			double reme1;
			double reme2;
			double tasa1;
			double tasa2;
			double unit;
            Console.Clear();
			Console.WriteLine();
			Console.WriteLine(" Ingrese monto en dolares a enviar la remesa: $");
			env = Double.Parse(Console.ReadLine());
			// Ingresano numeros de personas en transferencias unitarias.
			Console.WriteLine(" Cuantas personas desea enviar: ");
			p = Double.Parse(Console.ReadLine());
			Console.WriteLine(" ");
			// Cantidad de personas
			// backup: p <- 8;
			// Tasa pais emisor
			tasa1 = 20;
			// Tasa Pais recibidor
			tasa2 = 10;
			// Dividiendo la cantidad de remesa por cada personas
			unit = env/p;
			// Resultados - Etapa 1
			Console.WriteLine(" El Monto de la remesa es de: $"+env);
			Console.WriteLine(" Tienes "+p+" personas para dar la remesa por enviar.");
			Console.WriteLine(" La cantidad unitaria es de: $"+unit+" dolares por persona.");
			Console.WriteLine(" ");
			Console.WriteLine(" La Tasa en el pais emisor (ejm: Suiza) es: $"+tasa1+" dolares.");
			Console.WriteLine(" La Tasa en el pais recibidor (Venezuela) es: $"+tasa2+" dolares. ");
			// Calculos
			// Resta de remesa en el pais emisor
			reme1 = (unit-tasa1);
			// Resta de remesa en el pais recibidor
			reme2 = (reme1-tasa2);
			// Resultados - Etapa 2
			Console.WriteLine(" ");
			Console.WriteLine(" Cantidad en dolares en el pais emisor (ejm: Suiza) despues de la Tasa: $"+reme1);
			Console.WriteLine(" Cantidad en dolares en el pais recibidor (Venezuela) despues de la Tasa: $"+reme2);
			Console.ReadKey();
		}

	}

}

