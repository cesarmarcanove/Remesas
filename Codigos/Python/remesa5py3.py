#! /usr/bin/env python
# -*- coding: utf-8 -*-

if __name__ == '__main__':
	print("Ingrese monto en dolares a enviar la remesa: $")
	env = float(input())
	print("Cuantas personas desea enviar: ")
	p = float(input())
	print("") # no hay forma directa de borrar la pantalla con Python estandar
	print(" ")
	# Cantidad de personas
	# backup: p <- 8;
	# Tasa pais emisor
	tasa1 = 20
	# Tasa Pais recibidor
	tasa2 = 10
	# Dividiendo la cantidad de remesa por cada 8 personas
	unit = env/p
	print(" El Monto de la remesa es de: $",env)
	print(" Tienes ",p," personas para dar la remesa por enviar.")
	print(" La cantidad unitaria es de: $",unit," dolares por persona.")
	print(" ")
	print(" La Tasa en el pais emisor (ejm: Suiza) es: $",tasa1," dolares.")
	print(" La Tasa en el pais recibidor (Venezuela) es: $",tasa2," dolares. ")
	# Calculos
	# Resta de remesa en el pais emisor
	reme1 = (unit-tasa1)
	# Resta de remesa en el pais recibidor
	reme2 = (reme1-tasa2)
	print(" ")
	print(" Cantidad en dolares en el pais emisor (ejm: Suiza) despues de la Tasa: $",reme1)
	print(" Cantidad en dolares en el pais recibidor (Venezuela) despues de la Tasa: $",reme2)
	input() # a diferencia del pseudoc󤩧o, espera un Enter, no cualquier tecla

