Module Module1

    Sub Main()
        Dim Highest As Integer = 0
        Dim Lowest As Integer = 100
        Dim Children As Integer = 0
        Dim Teenagers As Integer = 0
        Dim Elder As Integer = 0
        Dim Overaged As Integer = 0
        Dim Age As Integer
        Dim Peoples As Integer = 0
        For Peoples = 1 To 50
            Console.WriteLine("input Age")
            Age = Console.ReadLine
            If Age < Lowest Then
                Lowest = Age
            ElseIf Age > Highest Then
                Highest = Age
            ElseIf Age > 0 And Age <= 10 Then
                Children = Children + 1
            ElseIf Age > 10 And Age <= 20 Then
                Teenagers = Teenagers + 1
            ElseIf Age > 20 And Age <= 50 Then
                Elder = Elder + 1
            ElseIf Age > 50 Then
                Overaged = Overaged + 1
            End If
        Next
        Console.WriteLine("The Highest Age is" & Highest)
        Console.WriteLine("The Lowest Age is" & Lowest)
        Console.WriteLine("The number of people in age group of children are" & Children)
        Console.WriteLine("The number of people in age group of Teeenagers are" & Teenagers)
        Console.WriteLine("The number of people in age group of Elder are " & Elder)
        Console.WriteLine("The number of people in age group of overAged are " & Overaged)
        Console.Read()
    End Sub

End Module
