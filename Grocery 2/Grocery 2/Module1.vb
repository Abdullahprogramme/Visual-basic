Module Module1

    Sub Main()
        Dim Item As String = "Start"
        Dim Quantity As String
        Dim Days As Integer = 0
        Dim OneLCount As Integer = 0
        Dim OneLsum As Integer = 0
        Dim TwoLCount As Integer = 0
        Dim TwoLSum As Integer = 0
        Dim Piece As String
        Dim Othersum As Integer = 0
        Dim OtherCount As Integer = 0
        Dim Price As Integer
        Dim LegPCount As Integer = 0
        Dim LegSum As Integer = 0
        Dim BreastPCount As Integer = 0
        Dim BreastSum As Integer = 0
        Dim OneLCounts(3) As Integer
        Dim TwoLCounts(3) As Integer
        Dim LegPCounts(3) As Integer
        Dim BreastPCounts(3) As Integer
        Dim OthersCount(3) As Integer
        For Days = 1 To 3
            Console.WriteLine("This is Day" & Days)
            Do
                Console.WriteLine("Enter the item here: Milk or Meat or Others")
                Item = Console.ReadLine
                If Item = "Milk" Then
                    Console.WriteLine("Enter the quantity of milk here: Onelitre or Twolitre")
                    Quantity = Console.ReadLine
                    Select Case Quantity
                        Case "Onelitre"
                            OneLCount = OneLCount + 1
                            OneLsum = OneLsum + 120
                        Case "Twolitre"
                            TwoLCount = TwoLCount + 1
                            TwoLSum = TwoLSum + 240
                    End Select
                ElseIf Item = "Meat" Then
                    Console.WriteLine("Enter which type of piece you want: Legpiece or Breastpiece")
                    Piece = Console.ReadLine
                    Select Case Piece
                        Case "Legpiece"
                            LegPCount = LegPCount + 1
                            LegSum = LegSum + 1000
                        Case "Breastpiece"
                            BreastPCount = BreastPCount + 1
                            BreastSum = BreastSum + 1300
                    End Select
                ElseIf Item = "Others" Then
                    Console.WriteLine("Enter the price of the item")
                    Price = Console.ReadLine
                    OtherCount = OtherCount + 1
                    Othersum = Othersum + Price
                End If
            Loop Until Item = "END"
            OneLCounts(Days) = OneLCount
            TwoLCounts(Days) = TwoLCount
            LegPCounts(Days) = LegPCount
            BreastPCounts(Days) = BreastPCount
            OthersCount(Days) = OtherCount
        Next Days
        Console.WriteLine("The sale for milk of 1 litre is" & OneLsum)
        Console.WriteLine("The 1 litre milk sold on day 1 was" & OneLCounts(1))
        Console.WriteLine("The sale for milk of 2 litre is" & TwoLSum)
        Console.WriteLine("The 2 litre milk sold on day 3 was" & OneLCounts(3))
        Console.WriteLine("The sale for leg piece of meat is" & LegSum)
        Console.WriteLine("The leg pieces sold on day 2 were" & LegPCounts(2))
        Console.WriteLine("The sale for Breast piece of meat is" & BreastSum)
        Console.WriteLine("The Breast pieces sold on day 2 were" & BreastPCounts(2))
        Console.Read()
    End Sub

End Module
