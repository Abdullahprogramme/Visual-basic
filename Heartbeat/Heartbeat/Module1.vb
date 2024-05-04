Module Module1

    Sub Main()
        Dim Heartbeat As Integer
        Do
            Console.WriteLine("Input the heartbeat")
            Heartbeat = Console.ReadLine
            Select Case Heartbeat
                Case Is > 140
                    Console.WriteLine("Heartbeat is high")
                Case Is >= 100 And Heartbeat <= 140
                    Console.WriteLine("Heartbeat is normal")
                Case Is < 100
                    Console.WriteLine("Heartbeat is low")
            End Select
        Loop Until Heartbeat = -1
        Console.Read()
    End Sub

End Module
