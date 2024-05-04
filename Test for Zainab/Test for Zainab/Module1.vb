Module Module1

    Sub Main()
        Dim Answer As Integer
        Dim Score As Integer
        Console.WriteLine("Test for Zainab")
        Console.WriteLine("Zainab your first question is, what is 24-24/8+4")
        Answer = Console.ReadLine
        Do
            If Answer <> 25 Then
                Console.WriteLine("Your answer is wrong, do again")
            End If
        Loop Until Answer = 25
        Score = Score + 1
        Console.WriteLine("Zainab your second question is, what is square of 11")
        Answer = Console.ReadLine
        Do
            If Answer <> 121 Then
                Console.WriteLine("Your answer is wrong, do again")
            End If
        Loop Until Answer = 121
        Score = Score + 1
        Console.WriteLine("Zainab your third question is, what is the area of a triangle whose hight is 2cm and lentgh 4cm")
        Answer = Console.ReadLine
        Do
            If Answer <> 4 Then
                Console.WriteLine("Your answer is wrong, do again")
            End If
        Loop Until Answer = 4
        Score = Score + 1
        Console.WriteLine("Your score is 3 out of 3")
        Console.Read()
    End Sub

End Module
