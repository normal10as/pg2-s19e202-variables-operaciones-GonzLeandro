Imports System

Module reloj
    Sub Main(args As String())
        Dim fechayhora As Date
        fechayhora = Date.Now
        Console.WriteLine("El dia es: " & fechayhora.Day)
        Console.WriteLine("El mes es: " & fechayhora.Month)
        Console.WriteLine("La fecha y hora es: " & fechayhora.Hour & ":" & fechayhora.Minute)

    End Sub
End Module
