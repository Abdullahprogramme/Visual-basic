Module Module1

    Sub Main()
        Dim CD As Integer
        Dim DVD As Integer
        Dim Videos As Integer
        Dim Books As Integer
        Dim Items As Integer
        Dim Code As Integer
        CD = 0
        DVD = 0
        Videos = 0
        Books = 0
        For Items = 1 To 8
            Console.WriteLine("Input Code")
            Code = Console.ReadLine
            If Code >= 1000 & Code < 2000 Then
                CD = CD + 1
            ElseIf Code >= 2000 & Code < 3000 Then
                DVD = DVD + 1
            ElseIf Code >= 3000 & Code < 4000 Then
                Videos = Videos + 1
            ElseIf Code >= 4000 & Code < 5000 Then
                Books = Books + 1
            End If
        Next Items
        Console.WriteLine("The Number Of CD is" & CD)
        Console.WriteLine("The Number Of DVD is" & DVD)
        Console.WriteLine("The Number Of Videos is" & Videos)
        Console.WriteLine("The Number Of Books is" & Books)
        Console.Read()
    End Sub

End Module
