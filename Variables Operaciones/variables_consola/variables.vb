Imports System
'1.1
Module variables
    Sub Main(args As String())

        Dim nombre As String
        Console.WriteLine("Ingrese nombre: ")
        nombre = Console.ReadLine()

        Dim apellido As String
        Console.WriteLine("Ingrese Apellido: ")
        apellido = Console.ReadLine()

        Dim fecha_de_nacimiento As Date
        Console.WriteLine("Ingrese fecha de nacimiento(año-mes-dia): ")
        fecha_de_nacimiento = Console.ReadLine()

        Console.WriteLine()

        Console.WriteLine(nombre + " " + apellido + ", Nacio el dia: " + fecha_de_nacimiento)
    End Sub
End Module
