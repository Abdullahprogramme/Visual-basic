Module Module1

    Sub Main()
        Dim Shop As String
        Dim Shop1Count As Integer = 0
        Dim Shop2Count As Integer = 0
        Dim Shop1Sum As Integer = 0
        Dim Shop2Sum As Integer = 0
        Dim Item As String
        Item = " Start"
        Shop = "Start"
        Do
            Console.WriteLine("Input Shop Name")
            Shop = Console.ReadLine
            If Shop = "Shop1" Then
                Do
                    Console.WriteLine(" Input Item")
                    Item = Console.ReadLine
                    If Item = "Toy" Then
                        Shop1Count = Shop1Count + 1
                        Shop1Sum = Shop1Sum + 2
                    ElseIf Item = " SoftToy" Then
                        Shop1Count = Shop1Count + 1
                        Shop1Sum = Shop1Sum + 4
                    End If
                Loop Until Item = " Empty"
            ElseIf Shop = "Shop2" Then
                Do
                    Console.WriteLine(" Input Item")
                    Item = Console.ReadLine

                    If Item = " Gold" Then
                        Shop2Count = Shop2Count + 1
                        Shop2Sum = Shop2Sum + 50
                    ElseIf Item = "Silver" Then
                        Shop2Count = Shop2Count + 1
                        Shop2Sum = Shop2Sum + 30
                    End If
                Loop Until Item = "Empty"
            End If
        Loop Until Shop = " End"
        Console.WriteLine("The Overall Sell of the day for shop 1 was " & Shop1Sum)
        Console.WriteLine("The Overall Items sold for shop 1  was" & Shop1Count)
        Console.WriteLine("The Overall Sell of the day for shop 2  was " & Shop2Sum)
        Console.WriteLine("The Overall Items sold for shop 2 was" & Shop1Count)
    End Sub

End Module
