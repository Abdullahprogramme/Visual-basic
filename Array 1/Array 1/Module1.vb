Module Module1

    Sub Main()
        Dim Name As String
        Dim Count As Integer = 0
        Dim StudentName(0 To 4) As String
        For Count = 1 To 4
            Console.WriteLine("Enter your name here")
            Name = Console.ReadLine
            StudentName(Count) = Name
        Next Count
        Console.WriteLine("The name is " & StudentName(1))
        Console.Read()
    End Sub

End Module
