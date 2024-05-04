Module Module1

    Sub Main()
        Dim Sunny As Integer = 0
        Dim Foggy As Integer = 0
        Dim Raining As Integer = 0
        Dim Cloudy As Integer = 0
        Dim Weather As String
        Dim Days As Integer = 0
        Weather = "Start"
        For Days = 1 To 8
            Console.WriteLine("input weather")
            Weather = Console.ReadLine
            Select Case Weather
                Case "Sunny"
                    Sunny = Sunny + 1
                Case "Foggy"
                    Foggy = Foggy + 1
                Case "Raining"
                    Raining = Raining + 1
                Case "Cloudy"
                    Cloudy = Cloudy + 1
            End Select
        Next Days
        Console.WriteLine("The number of sunny days are " & Sunny)
        Console.WriteLine("The number of foggy days are " & Foggy)
        Console.WriteLine("The number of raining days are " & Raining)
        Console.WriteLine("The number of cloudy days are " & Cloudy)
        Console.Read()
    End Sub

End Module
