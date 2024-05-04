Module Module1

    Sub Main()
        Dim Name As String
        Dim Count As Integer = 0
        Dim Names(0 To 4) As String
        For Count = 1 To 4
            Console.WriteLine("Enter your name here")
            Name = Console.ReadLine
            Names(Count) = Name
        Next Count
        For Count = 1 To 4
            Console.WriteLine("The name is " & Names(Count))
        Next Count
        Console.Read()
    End Sub

End Module
