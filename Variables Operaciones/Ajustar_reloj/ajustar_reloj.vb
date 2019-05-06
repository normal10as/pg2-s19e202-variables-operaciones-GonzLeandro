Imports System

Module ajustar_reloj
    Sub Main(args As String())
        Dim hora, dia As UShort
        Dim fecha As Date = Date.Now
        Console.WriteLine("ingrese hora(0 a 23)")
        hora = Console.ReadLine
        Console.WriteLine("ingrese dia(1 a 31)")
        dia = Console.ReadLine

        Console.WriteLine("La fecha es: " & dia & "/" & fecha.Month & "/" & fecha.Year & " " & hora & ":" & fecha.Minute)



    End Sub
End Module
