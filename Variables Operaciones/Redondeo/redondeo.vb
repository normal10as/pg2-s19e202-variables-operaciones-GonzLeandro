Imports System

Module redondeo
    Sub Main(args As String())

        Dim entero As Double
        Console.WriteLine("Ingrese un valor entero: ")
        entero = Console.ReadLine()

        Console.WriteLine("Valor aproximado por exceso: " & Math.Ceiling(entero))
        Console.WriteLine("Valor aproximado por defecto: " & Math.Floor(entero))
        Console.WriteLine("Valor redondeado: " & Math.Round(entero))



    End Sub
End Module
