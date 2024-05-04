Module Module1

    Sub Main()
        Dim Num As Integer = 0
        Dim Count As Integer = 0
        For Count = 1 To 10
            Num = Num + 2
            Console.WriteLine(Num)
        Next Count
        Num = 1
        For Count = 1 To 10
            Console.WriteLine(Num)
            Num = Num + 2
        Next Count
        Console.Read()
    End Sub

End Module
