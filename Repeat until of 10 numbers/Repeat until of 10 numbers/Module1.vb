Module Module1

    Sub Main()
        Dim Number As Integer
        Dim Sum As Integer = 0
        Dim Count As Integer = 0
        Do
            Do
                Console.WriteLine("Enter the number")
                Number = Console.ReadLine
            Loop Until Number > 0
            Sum = Sum + Number
            Count = Count + 1
        Loop Until Count = 10
        Console.WriteLine("The sum of the 10 numbers is" & Sum)
        Console.Read()
    End Sub

End Module
