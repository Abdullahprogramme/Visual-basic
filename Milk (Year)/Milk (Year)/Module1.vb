Module Module1

    Sub Main()
        Dim Item As String
        Dim JanDays As Integer = 0
        Dim FebDays As Integer = 0
        Dim MarDays As Integer = 0
        Dim AprDays As Integer = 0
        Dim MayDays As Integer = 0
        Dim JuneDays As Integer = 0
        Dim JulyDays As Integer = 0
        Dim AugDays As Integer = 0
        Dim SeptDays As Integer = 0
        Dim OctDays As Integer = 0
        Dim NovDays As Integer = 0
        Dim DecDays As Integer = 0
        Dim JanSum As Integer = 0
        Dim FebSum As Integer = 0
        Dim MarSum As Integer = 0
        Dim AprSum As Integer = 0
        Dim MaySum As Integer = 0
        Dim JuneSum As Integer = 0
        Dim JulySum As Integer = 0
        Dim AugSum As Integer = 0
        Dim SeptSum As Integer = 0
        Dim OctSum As Integer = 0
        Dim NovSum As Integer = 0
        Dim DecSum As Integer = 0
        Dim JanCount As Integer = 0
        Dim FebCount As Integer = 0
        Dim MarCount As Integer = 0
        Dim AprCount As Integer = 0
        Dim MayCount As Integer = 0
        Dim JuneCount As Integer = 0
        Dim JulyCount As Integer = 0
        Dim AugCount As Integer = 0
        Dim SeptCount As Integer = 0
        Dim OctCount As Integer = 0
        Dim NovCount As Integer = 0
        Dim DecCount As Integer = 0
        Dim Month As String
        Dim Price As Integer
        Dim Months As Integer = 0
        Price = 120
        For Months = 1 To 12
            Console.WriteLine("Input Month")
            Month = Console.ReadLine
            If Month = "January" Then
                For JanDays = 1 To 31
                    Console.WriteLine("Input Item")
                    Item = Console.ReadLine
                    If Item = "Milk" Then
                        JanCount = JanCount + 1
                        JanSum = JanSum + Price
                    ElseIf Item = "Empty" Then
                    End If
                Next JanDays
            ElseIf Month = "February" Then
                For FebDays = 1 To 28
                    Console.WriteLine("Input Item")
                    Item = Console.ReadLine
                    If Item = "Milk" Then
                        FebCount = FebCount + 1
                        FebSum = FebSum + Price
                    ElseIf Item = "Empty" Then
                    End If
                Next FebDays
            ElseIf Month = "March" Then
                For MarDays = 1 To 31
                    Console.WriteLine("Input Item")
                    Item = Console.ReadLine
                    If Item = "Milk" Then
                        MarCount = MarCount + 1
                        MarSum = MarSum + Price
                    ElseIf Item = "Empty" Then
                    End If
                Next MarDays
            ElseIf Month = "April" Then
                For AprDays = 1 To 30
                    Console.WriteLine("Input Item")
                    Item = Console.ReadLine
                    If Item = "Milk" Then
                        AprCount = AprCount + 1
                        AprSum = AprSum + Price
                    ElseIf Item = "Empty" Then
                    End If
                Next AprDays
            ElseIf Month = "May" Then
                For MayDays = 1 To 31
                    Console.WriteLine("Input Item")
                    Item = Console.ReadLine
                    If Item = "Milk" Then
                        MayCount = MayCount + 1
                        MaySum = MaySum + Price
                    ElseIf Item = "Empty" Then
                    End If
                Next MayDays
            ElseIf Month = "June" Then
                For JuneDays = 1 To 30
                    Console.WriteLine("Input Item")
                    Item = Console.ReadLine
                    If Item = "Milk" Then
                        JuneCount = JuneCount + 1
                        JuneSum = JuneSum + Price
                    ElseIf Item = "Empty" Then
                    End If
                Next JuneDays
            ElseIf Month = "July" Then
                For JulyDays = 1 To 31
                    Console.WriteLine("Input Item")
                    Item = Console.ReadLine
                    If Item = "Milk" Then
                        JulyCount = JulyCount + 1
                        JulySum = JulySum + Price
                    ElseIf Item = "Empty" Then
                    End If
                Next JulyDays
            ElseIf Month = "August" Then
                For AugDays = 1 To 30
                    Console.WriteLine("Input Item")
                    Item = Console.ReadLine
                    If Item = "Milk" Then
                        AugCount = AugCount + 1
                        AugSum = AugSum + Price
                    ElseIf Item = "Empty" Then
                    End If
                Next AugDays
            ElseIf Month = "September" Then
                For SeptDays = 1 To 31
                    Console.WriteLine("Input Item")
                    Item = Console.ReadLine
                    If Item = "Milk" Then
                        SeptCount = SeptCount + 1
                        SeptSum = SeptSum + Price
                    ElseIf Item = "Empty" Then
                    End If
                Next SeptDays
            ElseIf Month = "October" Then
                For OctDays = 1 To 30
                    Console.WriteLine("Input Item")
                    Item = Console.ReadLine
                    If Item = "Milk" Then
                        OctCount = OctCount + 1
                        OctSum = OctSum + Price
                    ElseIf Item = "Empty" Then
                    End If
                Next OctDays
            ElseIf Month = "November" Then
                For NovDays = 1 To 31
                    Console.WriteLine("Input Item")
                    Item = Console.ReadLine
                    If Item = "Milk" Then
                        NovCount = NovCount + 1
                        NovSum = NovSum + Price
                    ElseIf Item = "Empty" Then
                    End If
                Next NovDays
            ElseIf Month = " December" Then
                For DecDays = 1 To 30
                    Console.WriteLine("Input Item")
                    Item = Console.ReadLine
                    If Item = "Milk" Then
                        DecCount = DecCount + 1
                        DecSum = DecSum + Price
                    ElseIf Item = "Empty" Then
                    End If
                Next DecDays
            End If
                Next Months
        Console.WriteLine("The number of days milk bought in January is" & JanCount)
        Console.WriteLine("The Overall price in January is" & JanSum)
        Console.WriteLine("The number of days milk bought in February is" & FebCount)
        Console.WriteLine("The Overall price in February is" & FebSum)
        Console.WriteLine("The number of days milk bought in March is" & MarCount)
        Console.WriteLine("The Overall price in March is" & MarSum)
        Console.WriteLine("The number of days milk bought in April is" & AprCount)
        Console.WriteLine("The Overall price in April is" & AprSum)
        Console.WriteLine("The number of days milk bought in May is" & MayCount)
        Console.WriteLine("The Overall price in May is" & MaySum)
        Console.WriteLine("The number of days milk bought in June is" & JuneCount)
        Console.WriteLine("The Overall price in June is" & JuneSum)
        Console.WriteLine("The number of days milk bought in July is" & JulyCount)
        Console.WriteLine("The Overall price in July is" & JulySum)
        Console.WriteLine("The number of days milk bought in August is" & AugCount)
        Console.WriteLine("The Overall price in August is" & AugSum)
        Console.WriteLine("The number of days milk bought in September is" & SeptCount)
        Console.WriteLine("The Overall price in September is" & SeptSum)
        Console.WriteLine("The number of days milk bought in October is" & OctCount)
        Console.WriteLine("The Overall price in October is" & OctSum)
        Console.WriteLine("The number of days milk bought in November is" & NovCount)
        Console.WriteLine("The Overall price in November is" & NovSum)
        Console.WriteLine("The number of days milk bought in December is" & DecCount)
        Console.WriteLine("The Overall price in December is" & DecSum)
        Console.Read()
    End Sub

End Module
