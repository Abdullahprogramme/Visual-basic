Module Module1

    Sub Main()
        Dim Names(4) As String
        Dim Found As Boolean = False
        Dim Count As Integer
        Dim Name As String
        Console.BackgroundColor = ConsoleColor.Cyan
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Red
        For Count = 0 To 4
            Console.Write("Enter a name: ")
            Names(Count) = Console.ReadLine()
        Next
        Console.Write("Enter the name you want to search: ")
        Name = Console.ReadLine()
        For Count = 0 To 4
            If Name = Names(Count) Then
                Console.WriteLine("Name found on " & Count)
                Found = True
            End If
        Next
        If Found = False Then
            Console.WriteLine("Name not found")
        End If
        Console.Read()
    End Sub

End Module
