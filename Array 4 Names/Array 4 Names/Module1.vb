Module Module1

    Sub Main()
        Dim Name As String
        Dim FatherName As String
        Dim MotherName As String
        Dim Age As Integer
        Dim Count As Integer = 0
        Dim Names(0 To 3) As String
        Dim FatherNames(0 To 3) As String
        Dim MotherNames(0 To 3) As String
        Dim Ages(0 To 3) As Integer
        For Count = 1 To 3
            Console.WriteLine("Enter your name here")
            Name = Console.ReadLine
            Console.WriteLine("Enter your age here")
            Age = Console.ReadLine
            Console.WriteLine("Enter your  father's name here")
            FatherName = Console.ReadLine
            Console.WriteLine("Enter your mother's name here")
            MotherName = Console.ReadLine
            Names(Count) = Name
            Ages(Count) = Age
            FatherNames(Count) = FatherName
            MotherNames(Count) = MotherName
        Next Count
        For Count = 1 To 3
            Console.WriteLine("The Name is " & Names(Count))
            Console.WriteLine("The Age is " & Ages(Count))
            Console.WriteLine("The Father's name is " & FatherNames(Count))
            Console.WriteLine("The Mother's Name is " & MotherNames(Count))
        Next Count
        Console.Read()
    End Sub

End Module
