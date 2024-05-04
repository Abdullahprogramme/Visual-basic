Module Module1

    Sub Main()
        Dim Count As Integer = 0
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
        For Count = 1 To 5
            If Count = 1 Then
                Console.WriteLine(A & A & A & A & A)
            ElseIf Count = 2 Then
                Console.WriteLine(B & B & B & B & B)
            ElseIf Count = 3 Then
                Console.WriteLine(C & C & C & C & C)
            ElseIf Count = 4 Then
                Console.WriteLine(D & D & D & D & D)
            ElseIf Count = 5 Then
                Console.WriteLine(E & E & E & E & E)
            End If
        Next Count
        Console.Read()
    End Sub

End Module
