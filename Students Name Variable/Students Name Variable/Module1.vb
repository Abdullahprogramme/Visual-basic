Module Module1

    Sub Main()
        Dim Students As Integer = 0
        Dim Exams As Integer = 0
        Dim Name As String
        Dim Sum As Integer = 0
        Dim Marks As Integer
        For Students = 1 To 5
            Console.WriteLine("Enter your name here")
            Name = Console.ReadLine
            For Exams = 1 To 2
                Console.WriteLine("Enter your test marks here")
                Marks = Console.ReadLine
                Sum = Sum + Marks
            Next Exams
            Console.WriteLine("The name of the student was " & Name)
            Console.WriteLine("His total was " & Sum & " out of 200")
        Next Students
        Console.Read()
    End Sub

End Module
