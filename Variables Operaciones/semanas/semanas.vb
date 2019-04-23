Imports System
'1.7
Module semanas
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Const año As UShort = 365
        Const laboral As UShort = 265
        Const semanas As Byte = 7
        Console.WriteLine("el año tiene " & año / semanas & " semanas")
        Console.WriteLine("de las cuales " & laboral / semanas & " son laborables")

    End Sub
End Module
