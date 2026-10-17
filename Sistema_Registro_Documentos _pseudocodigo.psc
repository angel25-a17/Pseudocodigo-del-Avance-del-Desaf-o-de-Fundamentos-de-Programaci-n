Algoritmo Sistema_Registro_Documentos

	Definir op_menu, sel_tipo, sel_estado, cantidad, pos, i, j Como Entero
	Definir codigo, aux Como Cadena
	Definir codigos, nombres, dnis, tipos, asuntos, fechas, contactos, estados Como Cadena
	
	Dimension codigos[100], nombres[100], dnis[100], tipos[100]
	Dimension asuntos[100], fechas[100], contactos[100], estados[100]
	
	cantidad <- 0
	
	Repetir
		Escribir ""
		Escribir "=========================================="
		Escribir " SISTEMA DE MESA DE PARTES DIGITAL"
		Escribir " MUNICIPALIDAD DISTRITAL DE LOS OLIVOS"
		Escribir "=========================================="
		Escribir "1. Registrar documento"
		Escribir "2. Consultar documento"
		Escribir "3. Actualizar estado"
		Escribir "4. Ordenar documentos por codigo"
		Escribir "5. Salir"
		op_menu <- LeerEntero("Seleccione una opcion (1-5):", 1, 5)
		
		Segun op_menu Hacer
			
			// ---------------------------------------------------
			1:
				Escribir ""
				Escribir "REGISTRO DE DOCUMENTO"
				Si cantidad >= 100 Entonces
					Escribir "Error: se alcanzo el limite de 100 documentos."
				SiNo
					cantidad <- cantidad + 1
					
					nombres[cantidad] <- LeerNombre("Ingrese nombres y apellidos:")
					dnis[cantidad] <- LeerDigitos("Ingrese DNI de 8 digitos:", 8, "el DNI")
					
					Escribir "Tipo de documento:"
					Escribir "1. Solicitud"
					Escribir "2. Reclamo"
					Escribir "3. Consulta"
					Escribir "4. Otro"
					tipo_op_menu <- LeerEntero("Seleccione el tipo (1-4):", 1, 4)
					Segun sel_tipo Hacer
						1: tipos[cantidad] <- "Solicitud"
						2: tipos[cantidad] <- "Reclamo"
						3: tipos[cantidad] <- "Consulta"
						4: tipos[cantidad] <- "Otro"
					FinSegun
					
					asuntos[cantidad] <- LeerAsunto("Ingrese el asunto:")
					fechas[cantidad] <- LeerFecha("Ingrese la fecha (DD/MM/AAAA):")
					contactos[cantidad] <- LeerDigitos("Ingrese telefono de 9 digitos:", 9, "el telefono")
					
					codigos[cantidad] <- GenerarCodigo(cantidad)
					estados[cantidad] <- "Pendiente"
					
					Escribir ""
					Escribir "DOCUMENTO REGISTRADO"
					MostrarDocumento(codigos[cantidad], nombres[cantidad], dnis[cantidad], tipos[cantidad], asuntos[cantidad], fechas[cantidad], contactos[cantidad], estados[cantidad])
				FinSi
				
				// ---------------------------------------------------
			2:
				Escribir ""
				Escribir "CONSULTA DE DOCUMENTO"
				Si cantidad = 0 Entonces
					Escribir "No hay documentos registrados."
				SiNo
					Escribir "Ingrese el codigo (ejemplo: DOC001):"
					Leer codigo
					codigo <- Mayusculas(codigo)
					pos <- 0
					Para i <- 1 Hasta cantidad Hacer
						Si codigos[i] = codigo Entonces
							pos <- i
						FinSi
					FinPara
					Si pos = 0 Entonces
						Escribir "Error: documento no encontrado."
					SiNo
						Escribir "Documento encontrado"
						MostrarDocumento(codigos[pos], nombres[pos], dnis[pos], tipos[pos], asuntos[pos], fechas[pos], contactos[pos], estados[pos])
					FinSi
				FinSi
				
				// ---------------------------------------------------
			3:
				Escribir ""
				Escribir "ACTUALIZACION DE ESTADO"
				Si cantidad = 0 Entonces
					Escribir "No hay documentos registrados."
				SiNo
					Escribir "Ingrese el codigo (ejemplo: DOC001):"
					Leer codigo
					codigo <- Mayusculas(codigo)
					pos <- 0
					Para i <- 1 Hasta cantidad Hacer
						Si codigos[i] = codigo Entonces
							pos <- i
						FinSi
					FinPara
					Si pos = 0 Entonces
						Escribir "Error: documento no encontrado."
					SiNo
						Escribir "Estado actual: ", estados[pos]
						Escribir "1. Pendiente"
						Escribir "2. En proceso"
						Escribir "3. Atendido"
						estado_op_menu <- LeerEntero("Seleccione el nuevo estado (1-3):", 1, 3)
						Segun sel_estado Hacer
							1: estados[pos] <- "Pendiente"
							2: estados[pos] <- "En proceso"
							3: estados[pos] <- "Atendido"
						FinSegun
						Escribir "Estado actualizado: ", estados[pos]
					FinSi
				FinSi
				
				// ---------------------------------------------------
			4:
				Escribir ""
				Escribir "ORDENAR DOCUMENTOS POR CODIGO"
				Si cantidad = 0 Entonces
					Escribir "No hay documentos registrados."
				SiNo
					// Ordenamiento burbuja ascendente segun la parte numerica del codigo
					Para i <- 1 Hasta cantidad - 1 Hacer
						Para j <- 1 Hasta cantidad - i Hacer
							Si NumeroDeCodigo(codigos[j]) > NumeroDeCodigo(codigos[j + 1]) Entonces
								aux <- codigos[j]
								codigos[j] <- codigos[j + 1]
								codigos[j + 1] <- aux
								aux <- nombres[j]
								nombres[j] <- nombres[j + 1]
								nombres[j + 1] <- aux
								aux <- dnis[j]
								dnis[j] <- dnis[j + 1]
								dnis[j + 1] <- aux
								aux <- tipos[j]
								tipos[j] <- tipos[j + 1]
								tipos[j + 1] <- aux
								aux <- asuntos[j]
								asuntos[j] <- asuntos[j + 1]
								asuntos[j + 1] <- aux
								aux <- fechas[j]
								fechas[j] <- fechas[j + 1]
								fechas[j + 1] <- aux
								aux <- contactos[j]
								contactos[j] <- contactos[j + 1]
								contactos[j + 1] <- aux
								aux <- estados[j]
								estados[j] <- estados[j + 1]
								estados[j + 1] <- aux
							FinSi
						FinPara
					FinPara
					
					Escribir "Documentos ordenados por codigo:"
					Para i <- 1 Hasta cantidad Hacer
						Escribir "------------------------------------------"
						MostrarDocumento(codigos[i], nombres[i], dnis[i], tipos[i], asuntos[i], fechas[i], contactos[i], estados[i])
					FinPara
				FinSi
				
				// ---------------------------------------------------
			5:
				Escribir ""
				Escribir "Gracias por utilizar el sistema."
				
		FinSegun
	Hasta Que op_menu = 5
	
FinAlgoritmo


// ============================================================
// FUNCIONES DE LECTURA CON VALIDACION (repiten hasta ser validas)
// ============================================================

Funcion n <- LeerEntero(mensaje, minimo, maximo)
	Definir n Como Entero
	Definir texto Como Cadena
	Definir valido Como Logico
	
	valido <- Falso
	n <- 0
	Repetir
		Escribir mensaje
		Leer texto
		Si Longitud(texto) >= 1 Y Longitud(texto) <= 3 Entonces
			Si SoloDigitos(texto) Entonces
				n <- ConvertirANumero(texto)
				Si n >= minimo Y n <= maximo Entonces
					valido <- Verdadero
				FinSi
			FinSi
		FinSi
		Si valido = Falso Entonces
			Escribir "Error: ingrese un numero entre ", minimo, " y ", maximo, "."
		FinSi
	Hasta Que valido
FinFuncion


Funcion texto <- LeerNombre(mensaje)
	Definir texto Como Cadena
	Definir valido Como Logico
	
	valido <- Falso
	Repetir
		Escribir mensaje
		Leer texto
		Si HayContenido(texto) Y SoloLetras(texto) Entonces
			valido <- Verdadero
		SiNo
			Escribir "Error: el nombre no puede estar vacio y solo admite letras y espacios."
		FinSi
	Hasta Que valido
FinFuncion


Funcion texto <- LeerDigitos(mensaje, cantidad_digitos, etiqueta)
	Definir texto Como Cadena
	Definir valido Como Logico
	
	valido <- Falso
	Repetir
		Escribir mensaje
		Leer texto
		Si Longitud(texto) <> cantidad_digitos Entonces
			Escribir "Error: ", etiqueta, " debe tener exactamente ", cantidad_digitos, " digitos."
		SiNo
			Si SoloDigitos(texto) = Falso Entonces
				Escribir "Error: ", etiqueta, " solo acepta numeros."
			SiNo
				valido <- Verdadero
			FinSi
		FinSi
	Hasta Que valido
FinFuncion


Funcion texto <- LeerAsunto(mensaje)
	Definir texto Como Cadena
	Definir valido Como Logico
	
	valido <- Falso
	Repetir
		Escribir mensaje
		Leer texto
		Si HayContenido(texto) Entonces
			valido <- Verdadero
		SiNo
			Escribir "Error: el asunto no puede estar vacio."
		FinSi
	Hasta Que valido
FinFuncion


Funcion texto <- LeerFecha(mensaje)
	Definir texto Como Cadena
	Definir valido Como Logico
	
	valido <- Falso
	Repetir
		Escribir mensaje
		Leer texto
		Si EsFechaValida(texto) Entonces
			valido <- Verdadero
		SiNo
			Escribir "Error: fecha invalida. Use el formato DD/MM/AAAA (ejemplo: 14/10/2026)."
		FinSi
	Hasta Que valido
FinFuncion


// ============================================================
// FUNCIONES DE VALIDACION
// ============================================================

Funcion resultado <- SoloDigitos(cadena)
	Definir resultado Como Logico
	Definir i, k Como Entero
	Definir caracter Como Cadena
	Definir permitidos Como Cadena
	Definir encontrado Como Logico
	
	permitidos <- "0123456789"
	resultado <- Verdadero
	
	Para i <- 1 Hasta Longitud(cadena) Hacer
		caracter <- SubCadena(cadena, i, i)
		encontrado <- Falso
		Para k <- 1 Hasta Longitud(permitidos) Hacer
			Si caracter = SubCadena(permitidos, k, k) Entonces
				encontrado <- Verdadero
			FinSi
		FinPara
		Si encontrado = Falso Entonces
			resultado <- Falso
		FinSi
	FinPara
FinFuncion


Funcion resultado <- SoloLetras(cadena)
	Definir resultado Como Logico
	Definir i, k Como Entero
	Definir caracter Como Cadena
	Definir permitidos Como Cadena
	Definir encontrado Como Logico
	
	permitidos <- "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ÁÉÍÓÚÑáéíóúñ"
	resultado <- Verdadero
	
	Para i <- 1 Hasta Longitud(cadena) Hacer
		caracter <- SubCadena(cadena, i, i)
		encontrado <- Falso
		Para k <- 1 Hasta Longitud(permitidos) Hacer
			Si caracter = SubCadena(permitidos, k, k) Entonces
				encontrado <- Verdadero
			FinSi
		FinPara
		Si encontrado = Falso Entonces
			resultado <- Falso
		FinSi
	FinPara
FinFuncion


// Devuelve Verdadero si la cadena tiene al menos un caracter que no sea espacio
Funcion resultado <- HayContenido(cadena)
	Definir resultado Como Logico
	Definir i Como Entero
	
	resultado <- Falso
	Para i <- 1 Hasta Longitud(cadena) Hacer
		Si SubCadena(cadena, i, i) <> " " Entonces
			resultado <- Verdadero
		FinSi
	FinPara
FinFuncion


// Valida formato DD/MM/AAAA, rango de mes, dias por mes y años bisiestos
Funcion resultado <- EsFechaValida(fecha)
	Definir resultado Como Logico
	Definir dd, mm, aaaa Como Cadena
	Definir d, m, a, max_dias Como Entero
	Definir bisiesto Como Logico
	
	resultado <- Falso
	
	Si Longitud(fecha) = 10 Entonces
		Si SubCadena(fecha, 3, 3) = "/" Y SubCadena(fecha, 6, 6) = "/" Entonces
			dd <- SubCadena(fecha, 1, 2)
			mm <- SubCadena(fecha, 4, 5)
			aaaa <- SubCadena(fecha, 7, 10)
			Si SoloDigitos(dd) Y SoloDigitos(mm) Y SoloDigitos(aaaa) Entonces
				d <- ConvertirANumero(dd)
				m <- ConvertirANumero(mm)
				a <- ConvertirANumero(aaaa)
				Si a >= 2000 Y a <= 2100 Y m >= 1 Y m <= 12 Entonces
					bisiesto <- (a MOD 4 = 0 Y a MOD 100 <> 0) O (a MOD 400 = 0)
					Si m = 2 Entonces
						Si bisiesto Entonces
							max_dias <- 29
						SiNo
							max_dias <- 28
						FinSi
					SiNo
						Si m = 4 O m = 6 O m = 9 O m = 11 Entonces
							max_dias <- 30
						SiNo
							max_dias <- 31
						FinSi
					FinSi
					Si d >= 1 Y d <= max_dias Entonces
						resultado <- Verdadero
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi
FinFuncion


// ============================================================
// FUNCIONES AUXILIARES
// ============================================================

// Genera codigos correlativos: DOC001, DOC002, ..., DOC100
Funcion cod <- GenerarCodigo(numero)
	Definir cod Como Cadena
	
	Si numero < 10 Entonces
		cod <- Concatenar("DOC00", ConvertirATexto(numero))
	SiNo
		Si numero < 100 Entonces
			cod <- Concatenar("DOC0", ConvertirATexto(numero))
		SiNo
			cod <- Concatenar("DOC", ConvertirATexto(numero))
		FinSi
	FinSi
FinFuncion


// Extrae la parte numerica de un codigo (DOC012 -> 12)
Funcion n <- NumeroDeCodigo(cod)
	Definir n Como Entero
	n <- ConvertirANumero(SubCadena(cod, 4, 6))
FinFuncion


Funcion MostrarDocumento(cod, nom, doc_id, tipo_doc, asu, fec, tel, est)
	Escribir "Codigo: ", cod
	Escribir "Nombre: ", nom
	Escribir "DNI: ", doc_id
	Escribir "Tipo: ", tipo_doc
	Escribir "Asunto: ", asu
	Escribir "Fecha: ", fec
	Escribir "Telefono: ", tel
	Escribir "Estado: ", est
FinFuncion
