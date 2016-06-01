Public Class Game
    Private x, y As Integer
    Private terreno(9, 9) As Integer
    Private salida As String
    Private c As Cruisser

    Public Function crearArray() As String
        For x = 0 To 9
            For y = 0 To 9
                salida = salida + "|     "
            Next
            salida = salida + vbNewLine
        Next
        Return Me.salida
    End Function

    Public Sub setCruisser(ByVal x As Integer, ByVal y As Integer)
        Me.x = x
        Me.y = y
    End Sub

    Public Function updateArray() As String
        salida = ""
        Dim posicion1 As New Random
        Dim posicion2 As New Random
        Dim posicion3 As New Random
        Dim posicion4 As New Random
        ' Dim c2pos1 As Integer = InputBox("Introduce X del crucero número 2")
        ' Dim c2pos2 As Integer = InputBox("Introduce Y del crucero número 2")
        For x = 0 To 9
            For y = 0 To 9
                If x = posicion1.Next(1, 8) And y = posicion2.Next(1, 8) Or x = posicion3.Next(1, 8) And y = posicion4.Next(1.8) Then
                    terreno(x, y) = 2
                Else
                    terreno(x, y) = 1
                End If
                salida = salida + terreno(x, y).ToString + "    "
            Next
            salida = salida + vbNewLine
        Next
        Return Me.salida
    End Function

    Public Function mapaReal() As String
        salida = ""

        ' Dim c2pos1 As Integer = InputBox("Introduce X del crucero número 2")
        ' Dim c2pos2 As Integer = InputBox("Introduce Y del crucero número 2")
        For x = 0 To 9
            For y = 0 To 9

                terreno(x, y) = 1

                salida = salida + terreno(x, y).ToString + "    "
            Next
            salida = salida + vbNewLine
        Next
        Return Me.salida
    End Function


    Public Function tirar(ByVal n1 As Integer, ByVal n2 As Integer)
        Dim s As String
        If Me.terreno(n1, n2) = 2 Then
            s = ("Tocado")
        Else
            s = ("Agua")
        End If
        Return s.ToString

    End Function

End Class
