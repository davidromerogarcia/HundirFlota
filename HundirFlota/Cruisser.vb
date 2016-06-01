Public Class Cruisser
    Private x As Integer 'Posicion x del barco
    Private y As Integer 'Posicion y del barco
    Private xc As Integer
    Private yc As Integer

    Public Function getUbicacion()
        Return Me.x
        Return Me.y
    End Function
    Public Sub setUbicacion(ByVal x As Integer, ByVal y As Integer) 'Pasar 2 posiciones
        Me.x = x
        Me.y = y
    End Sub

    Public Function getXc()
        Return Me.xc
    End Function

    Public Function getYc()
        Return Me.yc
    End Function


End Class
