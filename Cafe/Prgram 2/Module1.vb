Module Module1

    Sub Main()
        Dim sumbun As Integer
        Dim Sumcake As Integer
        Dim Sumtea As Integer
        Dim Sumcoffee As Integer
        Dim Sumsoup As Integer
        Dim Countbun As Integer
        Dim Countcake As Integer
        Dim Counttea As Integer
        Dim Countcoffee As Integer
        Dim Countsoup As Integer
        Dim Totalsum As Integer
        Dim Highesttakings As Integer
        Dim Item As String
        Item = "Start"
        sumbun = 0
        Sumcake = 0
        Sumtea = 0
        Sumcoffee = 0
        Sumsoup = 0
        Countbun = 0
        Countcake = 0
        Counttea = 0
        Countcoffee = 0
        Countsoup = 0
        Highesttakings = 0
        While Item <> "END"
            Console.WriteLine("Input Item")
            Item = Console.ReadLine
            If Item = "Bun" Then
                sumbun = sumbun + 2
                Countbun = Countbun + 1
            ElseIf Item = "Cake" Then
                Sumcake = Sumcake + 5
                Countcake = Countcake + 1
            ElseIf Item = "Tea" Then
                Sumtea = Sumtea + 1
                Counttea = Counttea + 1
            ElseIf Item = "coffee" Then
                Sumcoffee = Sumcoffee + 3
                Countcoffee = Countcoffee + 1
            ElseIf Item = "soup" Then
                Sumsoup = Sumsoup + 6
                Countsoup = Countsoup + 1
            End If
        End While
        Totalsum = sumbun + Sumcake + Sumtea + Sumcoffee + Sumsoup
        Console.WriteLine("The Totalsum is" & Totalsum)
        If Countbun > Highesttakings Then
            Highesttakings = Countbun
        ElseIf Countcake > Highesttakings Then
            Highesttakings = Countcake
        ElseIf Counttea > Highesttakings Then
            Highesttakings = Counttea
        ElseIf Countcoffee > Highesttakings Then
            Highesttakings = Countcoffee
        ElseIf Countsoup > Highesttakings Then
            Highesttakings = Countsoup
        End If
        Console.WriteLine("The Hghesttakings Is" & Highesttakings)
        Console.ReadLine()
    End Sub

End Module
