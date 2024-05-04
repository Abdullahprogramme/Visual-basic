Module Module1
    Sub Grading(ByRef number As Integer)
        Select Case number
            Case Is < 0
                Console.WriteLine("ERROR")
            Case Is < 60
                Grades(Column, 2) = "F"
            Case Is < 70
                Grades(Column, 2) = "D"
            Case Is < 80
                Grades(Column, 2) = "C"
            Case Is < 90
                Grades(Column, 2) = "B"
            Case Is <= 100
                Grades(Column, 2) = "A"
            Case Else
                Console.WriteLine("ERROR")
        End Select
    End Sub
    Dim Grades(4, 2) As String
    Dim Count As Integer
    Dim Column, Rows As Integer
    Sub Main()
        Dim NAME As String
        Dim Column, Rows As Integer
        For Column = 0 To 4
            For Rows = 0 To 2
                Grades(Column, Rows) = " "
            Next Rows
        Next Column
        Console.Write("ENTER THE NAME : ")
        NAME = Console.ReadLine()
        For Column = 0 To 4
            Console.Write("ENTER THE SUBJECT : ")
            Grades(Column, 0) = Console.ReadLine()
            Console.Write("ENTER THE MARKS : ")
            Grades(Column, 1) = Console.ReadLine()
            Grading(Grades(Column, 1))
        Next Column
        For Column = 0 To 4
            Console.WriteLine("NAME IS " & NAME)
            Console.WriteLine("SUBJECT IS " & Grades(Column, 0))
            Console.WriteLine("MARKS ARE " & Grades(Column, 1))
            Console.WriteLine("GRADE IS " & Grades(Column, 2))
        Next Column
        Console.ReadKey()
    End Sub

End Module
