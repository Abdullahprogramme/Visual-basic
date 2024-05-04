Module Module1

    Sub Main()
        Dim Details(4, 2) As String
        Dim Column, Rows As Integer
        For Column = 0 To 4
            For Rows = 0 To 2
                Details(Column, Rows) = " "
            Next
        Next
        For Column = 0 To 4
            Console.Write("Enter the subject: ")
            Details(Column, 0) = Console.ReadLine()
            Console.Write("Enter the marks: ")
            Details(Column, 1) = Console.ReadLine()
            Select Case Int(Details(Column, 1))
                Case Is < 0
                    Console.WriteLine("ERROR")
                Case Is < 60
                    Details(Column, 2) = "F"
                Case Is < 70
                    Details(Column, 2) = "C"
                Case Is < 80
                    Details(Column, 2) = "B"
                Case Is < 90
                    Details(Column, 2) = "A"
                Case Is <= 100
                    Details(Column, 2) = "A*"
                Case Else
                    Console.WriteLine("ERROR")
            End Select
        Next
        For Column = 0 To 4
            Console.WriteLine(Details(Column, 0))
            Console.WriteLine(Details(Column, 1))
            Console.WriteLine(Details(Column, 2))
        Next
        Console.Read()
    End Sub

End Module
