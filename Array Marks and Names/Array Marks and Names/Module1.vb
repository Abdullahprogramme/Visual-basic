Module Module1

    Sub Main()
        Dim Name As String
        Dim Names(5) As String
        Dim Mark As Integer
        Dim Marks(5) As Integer
        Dim Count As Integer = 0
        For Count = 1 To 5
            Console.WriteLine("Enter the name of the student here")
            Name = Console.ReadLine
            Console.WriteLine("Enter the marks for the student")
            Mark = Console.ReadLine
            Names(Count) = Name
            Marks(Count) = Mark
        Next Count
        For Count = 1 To 5
            Console.WriteLine("The students name is " & Names(Count) & "and his marks are" & Marks(Count))
        Next Count
        Console.Read()
    End Sub

End Module
