Module Module1
    Function ADD(ByVal A As Integer, ByVal B As Integer) As Integer
        ADD = A + B
    End Function
    Function Subtract(ByVal A As Integer, ByVal B As Integer) As Integer
        Subtract = A - B
    End Function
    Function Mul(ByVal A As Integer, ByVal B As Integer) As Integer
        Mul = A * B
    End Function
    Function DIV(ByVal A As Integer, ByVal B As Integer) As Single
        DIV = A / B
    End Function
    Function Modulus(ByVal A As Integer, ByVal B As Integer) As Integer
        Modulus = A Mod B
    End Function
    Dim C, D As Integer
    Dim Count As Integer
    Sub Main()
        Dim X As Single
        Dim Sign As Char
        Console.Write("ENTER A NUMBER : ")
        C = Console.ReadLine()
        Console.Write("ENTER A NUMBER : ")
        D = Console.ReadLine()
        Console.Write("ENTER A SIGN : ")
        Sign = Console.ReadLine()
            If Sign = "+" Then
                X = ADD(C, D)
            ElseIf Sign = "-" Then
                X = Subtract(C, D)
            ElseIf Sign = "*" Then
                X = Mul(C, D)
            ElseIf Sign = "/" Then
                X = DIV(C, D)
            ElseIf Sign = "#" Then
                X = Modulus(C, D)
            Else
            Console.WriteLine("ERROR")
            End If
        Console.WriteLine(X)
        Console.ReadKey()
    End Sub

End Module
