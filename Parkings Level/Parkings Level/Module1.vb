Module Module1

    Sub Main()
        Dim Parkings As Integer = 0
        Dim Carcolour As String = "Start"
        Dim RedCount1 As Integer = 0
        Dim BlueCount1 As Integer = 0
        Dim RedCount2 As Integer = 0
        Dim BlueCount2 As Integer = 0
        Dim Parking As Integer = 0
        Dim ParkingLvl As String
        For Parking = 1 To 2
            Console.WriteLine("Enter the parking level:Lvl1 or Lvl2")
            ParkingLvl = Console.ReadLine
            Select Case ParkingLvl
                Case "Lvl1"
                    For Parkings = 1 To 200
                        Console.WriteLine("Enter the colour of the car")
                        Carcolour = Console.ReadLine
                        If Carcolour = "Red" Then
                            RedCount1 = RedCount1 + 1
                        ElseIf Carcolour = "Blue" Then
                            BlueCount1 = BlueCount1 + 1
                        End If
                    Next Parkings
                Case "Lvl2"
                    For Parkings = 1 To 200
                        Console.WriteLine("Enter the colour of the car")
                        Carcolour = Console.ReadLine
                        If Carcolour = "Red" Then
                            RedCount2 = RedCount2 + 1
                        ElseIf Carcolour = "Blue" Then
                            BlueCount2 = BlueCount2 + 1
                        End If
                    Next Parkings
            End Select
        Next Parking
        Console.WriteLine("The number of red cars in parking 1 are out of 200 " & RedCount1)
        Console.WriteLine("The number of blue cars in parking 1 are out of 200 " & BlueCount1)
        Console.WriteLine("The number of red cars in parking 2 are out of 200 " & RedCount2)
        Console.WriteLine("The number of blue cars in parking 2 are out of 200 " & BlueCount2)
        Console.Read()
    End Sub

End Module
