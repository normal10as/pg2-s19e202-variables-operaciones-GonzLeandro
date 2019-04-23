Imports System
'1.4
Module aritmetica
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim valor1 As Short = 10
        Dim valor2 As Short = 5
        Dim valor3 As Single = 2.5
        Dim valor4 As Single = 5.5

        Console.WriteLine("Entero mas entero: " & valor1 + valor2)
        Console.WriteLine("Entero menos entero: " & valor1 - valor2)
        Console.WriteLine("Entero mas float: " & valor1 + valor3)
        Console.WriteLine("Entero menos float: " & valor2 - valor3)
        Console.WriteLine("float mas float: " & valor3 + valor4)


    End Sub
End Module
