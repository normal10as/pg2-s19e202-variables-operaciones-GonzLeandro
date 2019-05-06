Imports System

Module intereses
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim monto, interes, dias, interes_anual As Integer

        Console.WriteLine("Ingrese monto a invertir: ")
        monto = Console.ReadLine()
        Console.WriteLine("Ingrese interes anuales: ")
        interes_anual = Console.ReadLine()
        Console.WriteLine("Ingrese tiempo en dias: ")
        dias = Console.ReadLine()


        interes = (monto * interes_anual * dias) / (360 * 100)

        Console.WriteLine("los intereses ganados son: " & interes)

    End Sub
End Module
