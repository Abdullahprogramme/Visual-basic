Module Module1

    Sub Main()
        Dim Shop As String
        Dim Item As String
        Dim Books As Integer = 0
        Dim Toys As Integer = 0
        Dim Games As Integer = 0
        Dim DVD As Integer = 0
        Dim BooksPrice As Integer = 100
        Dim ToyPrice As Integer = 50
        Dim GamePrice As Integer = 500
        Dim DVDPrice As Integer = 300
        Dim BookSum As Integer = 0
        Dim ToySum As Integer = 0
        Dim GameSUm As Integer = 0
        Dim DVDSum As Integer = 0
        Shop = "start"
        Item = "Start"
        Do
            Console.WriteLine("Type the shop name with number ,if no shop write (No Shop)")
            Shop = Console.ReadLine
            Select Case Shop
                Case "Shop1"
                    While Item <> "END"
                        Console.WriteLine("Input Item :Book or Toy")
                        Item = Console.ReadLine
                        Select Case Item
                            Case "Book"
                                Books = Books + 1
                                BookSum = BookSum + BooksPrice
                            Case "Toy"
                                Toys = Toys + 1
                                ToySum = ToySum + ToyPrice
                        End Select
                    End While
                Case "Shop2"
                    While Item <> "End"
                        Console.WriteLine("Input Item :Game or DVD")
                        Item = Console.ReadLine
                        Select Case Item
                            Case "Game"
                                Games = Games + 1
                                GameSUm = GameSUm + GamePrice
                            Case "DVD"
                                DVD = DVD + 1
                                DVDSum = DVDSum + DVDPrice
                        End Select
                    End While
            End Select
        Loop Until Shop = "No Shop"
        Console.WriteLine("The Books sold were" & Books)
        Console.WriteLine("The overall sale for books was" & BookSum)
        Console.WriteLine("The toys sold were " & Toys)
        Console.WriteLine("The overall sale for toys was " & ToySum)
        Console.WriteLine("The games sold were " & Games)
        Console.WriteLine("The overall sale for games was " & GameSUm)
        Console.WriteLine("The DVD's sold were " & DVD)
        Console.WriteLine("The overall sale for DVD's was " & DVDSum)
        Console.Read()
    End Sub

End Module
