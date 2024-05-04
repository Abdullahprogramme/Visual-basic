Module Module1

    Sub Main()
        Dim Number1 As Integer
        Dim Number2 As Integer
        Dim Count As Integer = 0
        Dim Answer As Integer = 0
        For Count = 1 To 4
            Console.WriteLine("input Number 1")
            Number1 = Console.ReadLine
            Console.WriteLine("Input Number 2")
            Number2 = Console.ReadLine
            Select Case Count
                Case 1
                    Answer = Number1 + Number2
                Case 2
                    Answer = Number1 - Number2
                Case 3
                    Answer = Number1 * Number2
                Case 4
                    Answer = Number1 / Number2
            End Select
            Console.WriteLine("The Answer is" & Answer)
        Next Count
        Console.Read()
    End Sub

End Module
