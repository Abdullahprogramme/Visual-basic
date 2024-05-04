Module Module1

    Sub Main()
        Dim Numbers As Integer = 0
        Dim Number As Integer
        Dim Num As Single
        Dim Digit As Integer = 0
        For Numbers = 1 To 10
            Console.WriteLine("Input Number")
2:          Number = Console.ReadLine
            Num = Number
            Do
                Num = Num / 10
                Digit = Digit + 1
            Loop Until Num < 1
            Console.WriteLine("Number is " & Number & "And Digits are " & Digit)
            Digit = 0
        Next Numbers
        Console.Read()
    End Sub

End Module
