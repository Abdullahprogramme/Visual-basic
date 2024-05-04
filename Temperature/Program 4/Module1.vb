Module Module1

    Sub Main()
        Dim Tabove20 As Integer = 0
        Dim Tbelow10 As Integer = 0
        Dim LowestT As Integer = 100
        Dim Count As Integer
        Dim Temperature As Integer
        For Count = 1 To 10
            Console.WriteLine("Input Temperature")
            Temperature = Console.ReadLine
            If Temperature < LowestT Then
                LowestT = Temperature
            End If
            If Temperature > 20 Then
                Tabove20 = Tabove20 + 1
            ElseIf Temperature < 10 Then
                Tbelow10 = Tbelow10 + 1
            End If
        Next Count
        Console.WriteLine("Temperature above 20 is " & Tabove20)
        Console.WriteLine("Temperature below 10 is" & Tbelow10)
        Console.WriteLine("The Lowest Temperature is" & LowestT)
        Console.Read()
    End Sub

End Module
