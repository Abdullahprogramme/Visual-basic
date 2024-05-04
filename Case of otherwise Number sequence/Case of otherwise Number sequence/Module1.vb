Module Module1

    Sub Main()
        Dim A As Integer
        Dim B As Integer
        Dim C As Integer
        Dim D As Integer
        Dim E As Integer
        A = 1
        B = 2
        C = 3
        D = 4
        E = 5
        Dim Count As Integer = 0
        For Count = 1 To 5
            If Count = 1 Then
                Console.WriteLine(A & B & C & D & E)
            ElseIf Count = 2 Then
                Console.WriteLine(E & D & C & B & A)
            End If
            Select Case Count
                Case 3
                    Console.WriteLine(A & A & A & A & A)
                Case 4
                    Console.WriteLine(D & D & D & D & D)
                Case 5
                    Console.WriteLine(E & E & E & E & E)
            End Select
        Next Count
        Console.Read()
    End Sub

End Module
