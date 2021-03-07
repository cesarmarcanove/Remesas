' Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
' Es posible que el codigo generado no sea completamente correcto. Si encuentra
' errores por favor reportelos en el foro (http://pseint.sourceforge.net).


DIM env AS DOUBLE
DIM p AS DOUBLE
DIM reme1 AS DOUBLE
DIM reme2 AS DOUBLE
DIM tasa1 AS DOUBLE
DIM tasa2 AS DOUBLE
DIM unit AS DOUBLE
PRINT "Ingrese monto en dolares a enviar la remesa: $"
INPUT env
PRINT "Cuantas personas desea enviar: "
INPUT p
CLS
PRINT " "
' Cantidad de personas
' backup: p <- 8;
' Tasa pais emisor
tasa1 = 20
' Tasa Pais recibidor
tasa2 = 10
' Dividiendo la cantidad de remesa por cada 8 personas
unit = env/p
PRINT " El Monto de la remesa es de: $";env
PRINT " Tienes ";p;" personas para dar la remesa por enviar."
PRINT " La cantidad unitaria es de: $";unit;" dolares por persona."
PRINT " "
PRINT " La Tasa en el pais emisor (ejm: Suiza) es: $";tasa1;" dolares."
PRINT " La Tasa en el pais recibidor (Venezuela) es: $";tasa2;" dolares. "
' Calculos
' Resta de remesa en el pais emisor
reme1 = (unit-tasa1)
' Resta de remesa en el pais recibidor
reme2 = (reme1-tasa2)
PRINT " "
PRINT " Cantidad en dolares en el pais emisor (ejm: Suiza) despues de la Tasa: $";reme1
PRINT " Cantidad en dolares en el pais recibidor (Venezuela) despues de la Tasa: $";reme2
'WHILE INKEY$<>"": WEND

