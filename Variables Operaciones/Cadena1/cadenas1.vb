Imports System

'1.14. Crear un proyecto y un módulo llamado “palabras1” que ingrese una palabra por teclado
'e informar : 
'? En que posición aparece la primer “a”.
'? En que posición aparece la primer “o”.
'? La palabra invertida


Module palabras1
    Sub Main(args As String())

        Dim palabra As String

        Console.Write("Ingrese una palabra: ")
        palabra = Console.ReadLine

        Console.WriteLine("La primer 'a' aparece en la pocision : " & InStr(palabra, "a"))
        Console.WriteLine("La primer 'o' aparece en la pocision : " & InStr(palabra, "o"))
        Console.WriteLine("La palabra invertida es: " & StrReverse(palabra))

    End Sub
End Module
