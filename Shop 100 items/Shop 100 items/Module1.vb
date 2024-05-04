Module Module1

    Sub Main()
        Dim SpoonsSCount As Integer = 100
        Dim PlatesSCount As Integer = 100
        Dim MugsSCount As Integer = 100
        Dim SpoonsCount As Integer = 0
        Dim PlatesCount As Integer = 0
        Dim MugsCount As Integer = 0
        Dim SpoonSum As Integer = 0
        Dim PlateSum As Integer = 0
        Dim MugSum As Integer = 0
        Dim Items As String = "Start"
        Dim Days As Integer = 0
        Dim ProfitSpoon As Integer = 0
        Dim ProfitPlate As Integer = 0
        Dim ProfitMug As Integer = 0
        Dim SpoonOldP As Integer = 0
        Dim PlateOldP As Integer = 0
        Dim MugOldP As Integer = 0
        For Days = 1 To 3
            Console.WriteLine("This is day " & Days)
            Do
                Console.WriteLine("Enter the name of item here : Spoon or Plate or Mug")
                Items = Console.ReadLine
                Select Case Items
                    Case "Spoon"
                        SpoonsCount = SpoonsCount + 1
                        SpoonsSCount = SpoonsSCount - 1
                        SpoonSum = SpoonSum + 20
                        SpoonOldP = SpoonOldP + 10
                        If SpoonsSCount < 20 Then
                            SpoonsSCount = SpoonsSCount + 100
                        End If
                    Case "Plate"
                        PlatesCount = PlatesCount + 1
                        PlatesSCount = PlatesSCount - 1
                        PlateSum = PlateSum + 50
                        PlateOldP = PlateOldP + 25
                        If PlatesSCount < 20 Then
                            PlatesSCount = PlatesSCount + 100
                        End If
                    Case "Mug"
                        MugsCount = MugsCount + 1
                        MugsSCount = MugsSCount - 1
                        MugSum = MugSum + 100
                        MugOldP = MugOldP + 50
                        If MugsSCount < 20 Then
                            MugsSCount = MugsSCount + 100
                        End If
                End Select
            Loop Until Items = "END"
            If SpoonsSCount < 20 Then
                SpoonsSCount = SpoonsSCount + 100
            End If
            If PlatesSCount < 20 Then
                PlatesSCount = PlatesSCount + 100
            End If
            If MugsSCount < 20 Then
                MugsSCount = MugsSCount + 100
            End If
            ProfitSpoon = SpoonSum - SpoonOldP
            ProfitPlate = PlateSum - PlateOldP
            ProfitMug = MugSum - MugOldP
            Console.WriteLine("The number of spoons sold on day " & Days & " are " & SpoonsCount)
            Console.WriteLine("The Sale for day " & Days & " for spoons are " & SpoonSum)
            Console.WriteLine("The profit on spoons for " & SpoonsCount & " spoons is " & ProfitSpoon)
            Console.WriteLine("The number of plates sold on day " & Days & " are " & PlatesCount)
            Console.WriteLine("The Sale for day " & Days & " for plates are " & PlateSum)
            Console.WriteLine("The profit on plates for " & PlatesCount & " plates is " & ProfitPlate)
            Console.WriteLine("The number of mugs sold on day " & Days & " are " & MugsCount)
            Console.WriteLine("The Sale for day " & Days & " for mugs are " & MugSum)
            Console.WriteLine("The profit on mugs for " & MugsCount & " mugs is " & ProfitMug)
            SpoonsCount = 0
            PlatesCount = 0
            MugsCount = 0
            SpoonSum = 0
            PlateSum = 0
            MugSum = 0
            ProfitSpoon = 0
            ProfitPlate = 0
            ProfitMug = 0
        Next Days
        Console.Read()
    End Sub

End Module
