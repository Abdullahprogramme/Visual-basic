Module Module1

    Sub Main()
        Dim Number As Integer
        Dim Num As Integer
        Dim Digit As Integer = 0
        Console.WriteLine("Input Number")
        Number = Console.ReadLine
        Num = Number
        Do
            Num = Num / 10
            Digit = Digit + 1
        Loop Until Num < 1
        Console.WriteLine("The Number was" & Number)
        Console.WriteLine("The Digit are" & Digit)
        Console.Read()
    End Sub

End Module
