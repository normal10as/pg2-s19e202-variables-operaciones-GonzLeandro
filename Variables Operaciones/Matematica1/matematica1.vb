Imports System

Module matematica1
    Sub Main(args As String())

        Dim valor As Integer
        Console.WriteLine("Ingrese un valor: ")
        valor = Console.ReadLine()

        Console.WriteLine("Valor absoluto: " & Math.Abs(valor))
        Console.WriteLine("Valor elevado a su decima potencia: " & Math.Pow(valor, 10))
        Console.WriteLine("La raiz cuadrada del valor: " & Math.Sqrt(valor))



    End Sub
End Module
