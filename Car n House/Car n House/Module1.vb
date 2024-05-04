Module Module1

    Sub Main()
        Dim Item As String = "start"
        Dim Cars As String
        Dim Ford As Integer = 0
        Dim DFSK As Integer = 0
        Dim Houses As String
        Dim House1 As Integer = 0
        Dim House2 As Integer = 0
        Do
            Console.WriteLine("Choose Cars or Houses")
            Item = Console.ReadLine
            If Item = "Cars" Then
                Console.WriteLine("Choose Ford or DFSK")
                Cars = Console.ReadLine
                Select Case Cars
                    Case "Ford"
                        Ford = Ford + 1
                    Case "DFSK"
                        DFSK = DFSK + 1
                End Select
            ElseIf Item = "Houses" Then
                Console.WriteLine("Choose House1 or House2")
                Houses = Console.ReadLine
                Select Case Houses
                    Case "House1"
                        House1 = House1 + 1
                    Case "House2"
                        House2 = House2 + 1
                End Select
            End If
        Loop Until Item = "END"
        Console.WriteLine(" Ford are " & Ford)
        Console.WriteLine(" DFSK are " & DFSK)
        Console.WriteLine(" House1 are " & House1)
        Console.WriteLine(" House2 are " & House2)
        Console.Read()
    End Sub

End Module
