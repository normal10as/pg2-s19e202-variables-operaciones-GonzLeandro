Imports System
'1.3
Module concatenacion
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim nombre_empresa As String = "Pepito Inc."
        Dim nombre_calle As String = "Tripoli"
        Dim altura_calle As UShort = 3329
        Dim fecha_inicio_actividades As Date = #2019-4-22#

        'Conversion implicita
        Console.WriteLine("Empresa: " & nombre_empresa)
        Console.WriteLine("Direccion: " & nombre_calle & " " & altura_calle)
        Console.WriteLine("Inicio de actividades: " & fecha_inicio_actividades)

        'Conversion explicita

        Console.WriteLine("Empresa: " & nombre_empresa)
        Console.WriteLine("Direccion: " & nombre_calle & " " & Convert.ToString(altura_calle))
        Console.WriteLine("Inicio de actividades: " & Convert.ToString(fecha_inicio_actividades))


    End Sub
End Module
