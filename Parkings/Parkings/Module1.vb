Module Module1

    Sub Main()
        Dim Cars As Integer = 0
        Dim PL1Count As Integer = 0
        Dim PL2Count As Integer = 0
        Dim ParkingLvl As String
        Dim Carcolour As String
        Dim Red1Count As Integer = 0
        Dim Blue1Count As Integer = 0
        Dim Red2Count As Integer = 0
        Dim Blue2Count As Integer = 0
        For Cars = 1 To 4
            Console.WriteLine("Enter the lvl of parking here: Lvl1 or Lvl2")
            ParkingLvl = Console.ReadLine
            Select Case ParkingLvl
                Case "Lvl1"
                    Console.WriteLine("Enter the colour of the car")
                    Carcolour = Console.ReadLine
                    If Carcolour = "Red" Then
                        Red1Count = Red1Count + 1
                    ElseIf Carcolour = "Blue" Then
                        Blue1Count = Blue1Count + 1
                    End If
                    PL1Count = PL1Count + 1
                    If PL1Count = 2 Then
                        Console.WriteLine("No parking left here")
                    End If
                Case "Lvl2"
                    Console.WriteLine("Enter the colour of the car")
                    Carcolour = Console.ReadLine
                    If Carcolour = "Red" Then
                        Red2Count = Red2Count + 1
                    ElseIf Carcolour = "Blue" Then
                        Blue2Count = Blue2Count + 1
                    End If
                    PL2Count = PL2Count + 1
                    If PL2Count = 2 Then
                        Console.WriteLine("No parking left here")
                    End If
            End Select
        Next Cars
        Console.WriteLine("The red cars in level 1 were " & Red1Count)
        Console.WriteLine("The Blue cars in level 1 were " & Blue1Count)
        Console.WriteLine("The red cars in level 2 were " & Red2Count)
        Console.WriteLine("The Blue cars in level 2 were " & Blue2Count)
        Console.Read()
    End Sub

End Module
