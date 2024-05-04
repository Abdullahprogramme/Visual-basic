Module Module1

    Sub Main()
        Dim Number As Integer
        Dim Count As Integer
        Dim Sum As Integer
        Dim largest As Integer
        Dim Smallest As Integer
        Dim Average As Single
        Sum = 0
        Smallest = 100
        largest = 0
        Average = 0
        For Count = 1 To 20
            Console.WriteLine("Input Number")
            Number = Console.ReadLine
            If Number < Smallest Then
                Smallest = Number
            ElseIf Number > largest Then
                largest = Number
            End If
            Sum = Sum + Number
        Next Count
        Average = Sum / 20
        Console.WriteLine("The largest Number is " & largest)
        Console.WriteLine("The Smallest Mumber is" & Smallest)
        Console.WriteLine("The Average is" & Average)
        Console.Read()
    End Sub

End Module
