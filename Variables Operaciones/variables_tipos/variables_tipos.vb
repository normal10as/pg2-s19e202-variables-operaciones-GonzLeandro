Imports System

Module variables_tipos
    Sub Main(args As String())
        Dim nombre As String
        nombre = "Leandro Gonzalez"
        Dim dni As UInteger
        dni = 41049099
        Dim lugar_nacimiento As String
        lugar_nacimiento = "Posadas"
        Dim fecha_nacimiento As Date
        fecha_nacimiento = #1998/04/16#
        Dim altura_corporal As UShort
        altura_corporal = "174"
        Dim nacionalidad As String
        nacionalidad = "Argentina"
        Dim temperatura As SByte
        temperatura = 22
        Dim calle As String
        calle = "Cabred"
        Dim altura_calle As UInt16
        altura_calle = "2450"
        Dim distancia_P_C As Byte
        distancia_P_C = 40
        Dim profundidad_mar As Int16
        profundidad_mar = 11000
        Dim poblacion As Integer
        poblacion = 44000000
        Dim peso_producto As Byte
        peso_producto = 1
        Dim monto_producto As Byte
        monto_producto = 80


        Console.WriteLine("El nombre es: " & nombre)
        Console.WriteLine("Su DNI es: " & dni)
        Console.WriteLine("Lugar de nacimiento: " & lugar_nacimiento)
        Console.WriteLine("Fecha de nacimiento: " & fecha_nacimiento)
        Console.WriteLine("La altura es: " & altura_corporal & "cm")
        Console.WriteLine("Su nacionalidad es: " & nacionalidad)
        Console.WriteLine("La temperatura ambiente es: " & temperatura & "°")
        Console.WriteLine("Direccion: " & calle & " " & altura_calle)
        Console.WriteLine("La distancia entre Posadas y Candelaria es: " & distancia_P_C)
        Console.WriteLine("La profundidad del mar es: " & profundidad_mar)
        Console.WriteLine("En Argentina la poblacion es: " & poblacion)
        Console.WriteLine("El paquete de yerba Pesa: " & peso_producto & "kg y vale: " & monto_producto & "$")
    End Sub
End Module
