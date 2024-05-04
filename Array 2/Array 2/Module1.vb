Module Module1

    Sub Main()
        Dim Number1 As Integer
        Dim Number2 As Integer
        Dim Answer As Integer
        Dim Count As Integer = 0
        Dim Answers(0 To 4) As Integer
        For Count = 1 To 4
            Console.WriteLine("Enter first number here")
            Number1 = Console.ReadLine
            Console.WriteLine("Enter second number here")
            Number2 = Console.ReadLine
            Select Case Count
                Case 1
                    Answer = Number1 * Number2
                Case 2
                    Answer = Number1 / Number2
                Case 3
                    Answer = Number1 + Number2
                Case 4
                    Answer = Number1 - Number2
            End Select
            Answers(Count) = Answer
        Next Count
        For Count = 1 To 4
            Console.WriteLine("The answer is " & Answers(Count))
        Next Count
        Console.Read()
    End Sub

End Module
