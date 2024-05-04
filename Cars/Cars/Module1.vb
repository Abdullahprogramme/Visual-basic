Module Module1

    Sub Main()
        Dim Car As String
        Dim HondaSum As Integer = 0
        Dim FordSum As Integer = 0
        Dim ToyotaSum As Integer = 0
        Dim SuzukiSum As Integer = 0
        Dim TotalSum As Integer = 0
        Dim Average As Single = 0
        Dim TotalCars As Integer = 0
        Dim Honda As Integer = 0
        Dim Ford As Integer = 0
        Dim Toyota As Integer = 0
        Dim Suzuki As Integer = 0
        Do
            Console.WriteLine("Input Car")
            Car = Console.ReadLine
            If Car = "Honda" Then
                Honda = Honda + 1
                HondaSum = HondaSum + 20000
            ElseIf Car = "Ford" Then
                Ford = Ford + 1
                FordSum = FordSum + 50000
            ElseIf Car = "Toyota" Then
                Toyota = Toyota + 1
                ToyotaSum = ToyotaSum + 30000
            ElseIf Car = "Suzuki" Then
                Suzuki = Suzuki + 1
                SuzukiSum = SuzukiSum + 35000
            End If
            TotalCars = Honda + Ford + Toyota + Suzuki
            TotalSum = HondaSum + FordSum + ToyotaSum + SuzukiSum
        Loop Until Car = "END"
        Average = TotalSum / TotalCars
        Console.WriteLine("The Honda was sold " & Honda & " times")
        Console.WriteLine("The Honda was sold " & Ford & " times")
        Console.WriteLine("The Honda was sold " & Toyota & " times")
        Console.WriteLine("The Honda was sold " & Suzuki & " times")
        Console.WriteLine("The Total Cars Sold were " & TotalCars)
        Console.WriteLine("The Average price was " & Average)
        Console.Read()
    End Sub

End Module
