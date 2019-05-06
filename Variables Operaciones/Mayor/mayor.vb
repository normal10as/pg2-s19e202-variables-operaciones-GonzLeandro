Imports System

Module mayor
    Sub Main(args As String())
        Dim valor1, valor2, mayor As Integer
        Console.WriteLine("Ingrese un valor")
        valor1 = Console.ReadLine
        Console.WriteLine("Ingrese un valor")
        valor2 = Console.ReadLine
        mayor = Math.Max(valor1, valor2)
        Console.WriteLine("Ingrese un valor")
        valor2 = Console.ReadLine
        mayor = Math.Max(mayor, valor2)


        Console.WriteLine("El valor mayor es: " & mayor)


    End Sub
End Module
