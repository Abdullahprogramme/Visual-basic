Module Module1

    Sub Main()
        Dim Item As String
        Dim Days As Integer = 0
        Dim Count As Integer = 0
        Dim Price As Integer
        Dim Sum As Integer = 0
        Price = 120
        For Days = 1 To 31
            Console.WriteLine("Input Item")
            Item = Console.ReadLine
            If Item = "Milk" Then
                Count = Count + 1
                Sum = Sum + Price
            ElseIf Item = "Empty" Then
            End If
        Next Days
        Console.WriteLine("The number of days milk bought was" & Count)
        Console.WriteLine("The total price was" & Sum)
        Console.Read()
    End Sub

End Module
