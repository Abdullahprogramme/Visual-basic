Module Module1

    Sub Main()
        Dim Gender As Char
        Dim Count As Integer = 0
        Dim Answer As Integer
        For Count = 1 To 2
            Console.WriteLine("Enter your gender here:M or F")
            Gender = Console.ReadLine
            If Gender = "M" Then
                Console.WriteLine("Your first question is, what is 23 + 45")
                Answer = Console.ReadLine
                If Answer = 68 Then
                    Console.WriteLine("Your answer is correct")
                Else
                    Console.WriteLine("Your answer is wrong")
                End If
                Console.WriteLine("Your second question is, what is 950 - 390")
                Answer = Console.ReadLine
                If Answer = 540 Then
                    Console.WriteLine("Your answer is correct")
                Else
                    Console.WriteLine("Your answer is wrong")
                End If
            ElseIf Gender = "F" Then
                Console.WriteLine("Your first question is, what is 56 +45")
                Answer = Console.ReadLine
                If Answer = 101 Then
                    Console.WriteLine("Your answer is correct")
                Else
                    Console.WriteLine("Your answer is wrong")
                End If
                Console.WriteLine("Your second question is, what is 345 - 299")
                Answer = Console.ReadLine
                If Answer = 46 Then
                    Console.WriteLine("Your answer is correct")
                Else
                    Console.WriteLine("Your answer is wrong")
                End If
            End If
        Next Count
        Console.Read()
    End Sub

End Module
