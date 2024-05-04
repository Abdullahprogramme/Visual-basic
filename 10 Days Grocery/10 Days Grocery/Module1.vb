Module Module1

    Sub Main()
        Dim Items As String
        Dim Count As Integer = 0
        Dim Milk As Integer = 0
        Dim Oil As Integer = 0
        Dim Meat As Integer = 0
        Dim Rice As Integer = 0
        Dim Wheat As Integer = 0
        Dim Others As Integer = 0
        Dim MilkCount As Integer = 0
        Dim OilCount As Integer = 0
        Dim WheatCount As Integer = 0
        Dim RiceCount As Integer = 0
        Dim MeatCount As Integer = 0
        Dim Price As Integer
        Dim OtherCount As Integer = 0
        Dim MilkPrice As Integer = 100
        Dim OilPrice As Integer = 500
        Dim MeatPrice As Integer = 1200
        Dim WheatPrice As Integer = 80
        Dim RicePrice As Integer = 200
        For Count = 1 To 10
            Console.WriteLine("Day number is" & Count)
            Do
                Console.WriteLine("Enter the item here: Milk or Oil or Meat or Wheat or Rice")
                Items = Console.ReadLine
                If Items = "Milk" Then
                    Milk = Milk + MilkPrice
                    MilkCount = MeatCount + 1
                ElseIf Items = "Oil" Then
                    Oil = Oil + OilPrice
                    OilCount = OilCount + 1
                ElseIf Items = "Meat" Then
                    Meat = Meat + MeatPrice
                    MeatCount = MeatCount + 1
                ElseIf Items = "Wheat" Then
                    Wheat = Wheat + WheatPrice
                    WheatCount = WheatCount + 1
                ElseIf Items = "Rice" Then
                    Rice = Rice + RicePrice
                    RiceCount = RiceCount + 1
                ElseIf Items = "Others" Then
                    Console.WriteLine("Enter the price here")
                    Price = Console.ReadLine
                    Others = Others + Price
                    OtherCount = OtherCount + 1
                End If
            Loop Until Items = "END"
        Next Count
        Console.WriteLine("The price of milk was" & Milk)
        Console.WriteLine("The price of meat was" & Meat)
        Console.WriteLine("The price of oil was" & Oil)
        Console.WriteLine("The price of wheat was" & Wheat)
        Console.WriteLine("The price of rice was" & Rice)
        Console.WriteLine("The price of other items was" & Others)
        Console.Read()
    End Sub

End Module
