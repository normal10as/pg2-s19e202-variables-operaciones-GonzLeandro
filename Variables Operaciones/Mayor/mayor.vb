Imports System

Module mayor
    Sub Main(args As String())
        Dim valor1, mayor As Integer
        Console.WriteLine("Ingrese un valor")
        valor1 = Console.ReadLine
        Console.WriteLine("Ingrese un valor")
        mayor = Console.ReadLine
        mayor = Math.Max(valor1, mayor)
        Console.WriteLine("Ingrese un valor")
        valor1 = Console.ReadLine
        mayor = Math.Max(mayor, valor1)


        Console.WriteLine("El valor mayor es: " & mayor)


    End Sub
End Module
