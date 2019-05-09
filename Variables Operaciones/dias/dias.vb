Imports System

Enum diasdelasemana
    domingo = 1
    lunes
    martes
    miercoles
    jueves
    viernes
    sabado
End Enum

Module dias
    Sub Main(args As String())
        Dim dia As diasdelasemana
        Console.WriteLine("Ingrese un numero del 1 al 7: ")
        dia = Console.ReadLine

        Console.WriteLine("El dia ingresado es: " & dia.ToString)


    End Sub
End Module
