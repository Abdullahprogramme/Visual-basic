Module Module1

    Sub Main()
        Dim NumGreat As Integer = 0
        Dim NumLow As Integer = 0
        Dim PNumber As Integer
        Do
            Console.WriteLine("Input Positive Number")
            PNumber = Console.ReadLine
            If PNumber < 1000 Then
                NumLow = NumLow + 1
            ElseIf PNumber > 1000 Then
                NumGreat = NumGreat + 1
            End If
        Loop Until PNumber = -1
        Console.WriteLine("The Number that are greater than 1000 are" & NumGreat)
        Console.WriteLine("The Number that are lower than 1000 are " & NumLow)
        Console.Read()
    End Sub

End Module
