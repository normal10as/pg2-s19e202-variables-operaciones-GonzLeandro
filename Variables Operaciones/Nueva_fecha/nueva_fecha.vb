Imports System

Module nueva_fecha
    Sub Main(args As String())
        Dim fecha As Date
        Dim diasagregar As Int16
        Console.WriteLine("Ingrese fecha (año/mes/dia): ")
        fecha = Console.ReadLine
        Console.WriteLine("Ingrese la cantidad de dias que desea agregar: ")
        diasagregar = Console.ReadLine

        Console.WriteLine("La nueva fecha es: " & fecha.AddDays(diasagregar))


    End Sub
End Module
