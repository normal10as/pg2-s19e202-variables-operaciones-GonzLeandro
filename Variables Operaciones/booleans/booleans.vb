Imports System
Module booleans
    Sub Main(args As String())

        Const verdad As Boolean = True
        Const falso As Boolean = False

        ' AND
        Console.WriteLine("'OPERADOR LOGICO AND'")
        Console.WriteLine()
        Console.WriteLine("EXP1 - EXP2 - EXP1 AND EXP2")
        Console.WriteLine(verdad & " - " & verdad & " - " & (verdad And verdad))
        Console.WriteLine(verdad & " - " & falso & " - " & (verdad And falso))
        Console.WriteLine(falso & " - " & verdad & " - " & (falso And verdad))
        Console.WriteLine(falso & " - " & falso & " - " & (falso And falso))
        Console.WriteLine()
        Console.WriteLine("'OPERADOR LOGICO OR'")
        Console.WriteLine()
        Console.WriteLine("EXP1 - EXP2 - EXP1 OR EXP2")
        Console.WriteLine(verdad & " - " & verdad & " - " & (verdad Or verdad))
        Console.WriteLine(verdad & " - " & falso & " - " & (verdad Or falso))
        Console.WriteLine(falso & " - " & verdad & " - " & (falso Or verdad))
        Console.WriteLine(falso & " - " & falso & " - " & (falso Or falso))
        Console.WriteLine()
        Console.WriteLine("'OPERADOR LOGICO XOR'")
        Console.WriteLine()
        Console.WriteLine("EXP1 - EXP2 - EXP1 XOR EXP2")
        Console.WriteLine(verdad & " - " & verdad & " - " & (verdad Xor verdad))
        Console.WriteLine(verdad & " - " & falso & " - " & (verdad Xor falso))
        Console.WriteLine(falso & " - " & verdad & " - " & (falso Xor verdad))
        Console.WriteLine(falso & " - " & falso & " - " & (falso Xor falso))
        Console.WriteLine()
        Console.WriteLine("'OPERADOR LOGICO NOT'")
        Console.WriteLine()
        Console.WriteLine("EXP1 - NO EXP1")
        Console.WriteLine(verdad & " - " & (Not (verdad)))
        Console.WriteLine(falso & " - " & (Not (falso)))

    End Sub
End Module
