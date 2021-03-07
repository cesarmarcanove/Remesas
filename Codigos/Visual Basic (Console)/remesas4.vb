' Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
' Es posible que el codigo generado no sea completamente correcto. Si encuentra
' errores por favor reportelos en el foro (http://pseint.sourceforge.net).

Module REMESAS4

	Sub Main()
		Dim env As Double
		Dim p As Double
		Dim reme1 As Double
		Dim reme2 As Double
		Dim tasa1 As Double
		Dim tasa2 As Double
		Dim unit As Double
		Console.WriteLine("Ingrese monto en dolares a enviar la remesa: $")
		env = Double.Parse(Console.ReadLine())
		Console.WriteLine(" ")
		' Cantidad de personas
		p = 8
		' Tasa pais emisor
		tasa1 = 20
		' Tasa Pais recibidor
		tasa2 = 10
		' Dividiendo la cantidad de remesa por cada 8 personas
		unit = env/p
		Console.WriteLine(" El Monto de la remesa es de: $",env)
		Console.WriteLine(" Tienes ",p," personas para dar la remesa por enviar.")
		Console.WriteLine(" La cantidad unitaria es de: $",unit," dolares por persona.")
		Console.WriteLine(" La Tasa en el pais emisor (ejm: Suiza) es: $",tasa1," dolares.")
		Console.WriteLine(" La Tasa en el pais recibidor (Venezuela) es: $",tasa2," dolares. ")
		' Calculos
		' Resta de remesa en el pais emisorr
		reme1 = (unit-tasa1)
		' Resta de remesa en el pais recibidor
		reme2 = (reme1-tasa2)
		Console.WriteLine(" Cantidad en dolares en el pais emisor (ejm: Suiza) despues de la Tasa: $",reme1)
		Console.WriteLine(" Cantidad en dolares en el pais recibidor (Venezuela) despues de la Tasa: $",reme2)
		Console.ReadKey()
	End Sub

End Module
