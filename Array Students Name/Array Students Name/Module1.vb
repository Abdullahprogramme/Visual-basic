Module Module1

    Sub Main()
        Dim Name As String
        Dim Names(5) As String
        Dim Count As Integer = 0
        Dim Test1 As Integer
        Dim Test2 As Integer
        Dim Test1s(5) As Integer
        Dim Test2s(5) As Integer
        For Count = 1 To 5
            Console.WriteLine("Enter your name here")
            Name = Console.ReadLine
            Names(Count) = Name
            Console.WriteLine("Enter first test marks here")
            Test1 = Console.ReadLine
            Test1s(Count) = Test1
            Console.WriteLine("Enter second test marks here")
            Test2 = Console.ReadLine
            Test2s(Count) = Test2
        Next Count
        For Count = 1 To 5
            Console.WriteLine("The students name was" & Names(Count))
            Console.WriteLine("The first test marks was" & Test1s(Count))
            Console.WriteLine("The second test marks was" & Test2s(Count))
        Next Count
        Console.Read()
    End Sub

End Module
