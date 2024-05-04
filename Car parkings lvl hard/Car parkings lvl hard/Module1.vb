Module Module1

    Sub Main()
        Dim Time As Integer
        Dim Count As Integer = 0
        Dim Times(300) As Integer
        Dim Stay As Integer
        Dim Stays(300) As Integer
        Dim CarNum As Integer
        Dim CarNums(300) As Integer
        Dim Code As Integer
        Dim Payment As Integer
        Do
            Count = Count + 1
            Console.WriteLine("Enter the car number")
            CarNum = Console.ReadLine
            CarNums(Count) = CarNum
            Console.WriteLine("Enter the time here")
            Time = Console.ReadLine
            Times(Count) = Time
            Console.WriteLine("For stay of 1 to 5 hours the payment will be 50 rupees and for more than 6 hours it will 150 rupees, if you enter the code correct for discount you will get a discount upto 50 %")
            Console.WriteLine("Enter the hours of stay here")
            Stay = Console.ReadLine
            Stays(Count) = Stay
            If Stay < 6 Then
                Console.WriteLine("Your payment is 50 rupees")
            ElseIf Stay > 6 Then
                Console.WriteLine("Enter the code for discount here if any")
                Code = Console.ReadLine
                If Code = 1234 Then
                    Payment = 80 / 100 * 150
                    Console.WriteLine("You got a 20% discount and your payment is " & Payment & " rupees")
                ElseIf Code = 2345 Then
                    Payment = 60 / 150 * 150
                    Console.WriteLine("You got a 40% dicount and your payment is " & Payment & " rupees")
                ElseIf Code = 3456 Then
                    Payment = 50 / 100 * 150
                    Console.WriteLine("You got 50% discount and your payment is " & Payment & " rupees")
                End If
            End If
        Loop Until CarNum = 0
        Count = Count - 1
        For Count = 1 To Count
            Console.WriteLine("The car of number " & CarNums(Count) & " came at " & Times(Count) & " and stayed for " & Stays(Count))
        Next Count
        Console.Read()
    End Sub

End Module
