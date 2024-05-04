Module Module1

    Sub Main()
        Dim Names(4) As String
        Dim UB As Integer = 4
        Dim Found As Boolean = False
        Dim LB As Integer = 0
        Dim Count As Integer
        Dim Index As Integer
        Dim Name As String
        Console.BackgroundColor = ConsoleColor.Cyan
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Red
        Index = LB
        For Count = 0 To 4
            Console.Write("Enter a name: ")
            Names(Count) = Console.ReadLine()
        Next
        Console.Write("Enter the name you want to search: ")
        Name = Console.ReadLine()
        Do
            If Name = Names(Index) Then
                Found = True
            End If
            Index = Index + 1
        Loop Until Found = True Or Index > UB
        If Found = True Then
            Console.WriteLine("Name found on " & Index - 1)
        ElseIf Found = False Then
            Console.WriteLine("Name not found")
        End If
        Console.Read()
    End Sub

End Module
