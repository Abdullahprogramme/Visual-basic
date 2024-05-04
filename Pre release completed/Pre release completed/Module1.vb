Module Module1

    Sub Main()
        Dim Name As String = "Start"
        Dim StudentName(3) As String
        Dim Test1Mark As Integer
        Dim Test1Marks(3) As Integer
        Dim Test2Mark As Integer
        Dim Test2Marks(3) As Integer
        Dim Test3Mark As Integer
        Dim Test3Marks(3) As Integer
        Dim Highest As Integer = 0
        Dim TotalMark As Integer
        Dim TotalMarks(3) As Integer
        Dim TotalScore As Integer
        Dim Students As Integer = 0
        Dim AverageTotalScore As Integer = 0
        For Students = 1 To 3
            Console.WriteLine("Enter the name of student")
            Name = Console.ReadLine
            Do
                Console.WriteLine("Enter the marks of test 1 for student " & Name)
                Test1Mark = Console.ReadLine
                If Test1Mark < 0 Or Test1Mark > 20 Then
                    Console.WriteLine("Enter the marks again, from 0 to 20")
                End If
            Loop Until Test1Mark >= 0 And Test1Mark <= 20
            Do
                Console.WriteLine("Enter the marks of test 2 for student " & Name)
                Test2Mark = Console.ReadLine
                If Test2Mark < 0 Or Test2Mark > 25 Then
                    Console.WriteLine("Enter the marks again, from 0 to 25")
                End If
            Loop Until Test2Mark >= 0 And Test2Mark <= 25
            Do
                Console.WriteLine("Enter the marks of test 3 for student " & Name)
                Test3Mark = Console.ReadLine
                If Test3Mark < 0 Or Test3Mark > 35 Then
                    Console.WriteLine("Enter the marks again, from 0 to 35")
                End If
            Loop Until Test3Mark >= 0 And Test3Mark <= 35
            TotalMark = Test1Mark + Test2Mark + Test3Mark
            If TotalMark > Highest Then
                Highest = TotalMark
            End If
            StudentName(Students) = Name
            Test1Marks(Students) = Test1Mark
            Test1Marks(Students) = Test2Mark
            Test1Marks(Students) = Test3Mark
            TotalMarks(Students) = TotalMark
        Next Students
        TotalScore = TotalMarks(1) + TotalMarks(2) + TotalMarks(3)
        AverageTotalScore = TotalScore / 3
        For Students = 1 To 3
            Console.WriteLine("The students name is " & StudentName(Students) & "and his total marks are " & TotalMarks(Students))
        Next Students
        Console.WriteLine("The average marks of all the students is" & AverageTotalScore)
        If Highest = TotalMarks(1) Then
            Console.WriteLine("The highest marks are " & TotalMarks(1) & " and are of " & StudentName(1))
        ElseIf Highest = TotalMarks(2) Then
            Console.WriteLine("The highest marks are " & TotalMarks(2) & " and are of " & StudentName(2))
        ElseIf Highest = TotalMarks(3) Then
            Console.WriteLine("The highest marks are " & TotalMarks(3) & " and are of " & StudentName(3))
        End If
        Console.Read()
    End Sub

End Module
