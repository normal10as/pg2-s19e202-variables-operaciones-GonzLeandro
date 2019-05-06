Imports System

Module resto_division
    Sub Main(args As String())

        Dim entero As Integer

        Console.WriteLine("Ingrese un numero entero: ")
        entero = Console.ReadLine()

        entero = entero Mod 2

        Console.WriteLine("el resto del entero dividido en 2 es: " & entero)

    End Sub
End Module
