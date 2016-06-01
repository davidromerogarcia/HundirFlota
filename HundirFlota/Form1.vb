Public Class Form1
    Dim mapa1 As New Game 'Array del mapa1
    Dim salida As String 'Enseñar el array 1
    Dim mostrar As String 'Mostrar array 2

    Private Sub mostrar_Click(sender As Object, e As EventArgs)
        ' MessageBox.Show(salida)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub beginning_Click(sender As Object, e As EventArgs) Handles beginning.Click
        Dim mapaJugador As New Game
        Dim salida2 As String


        salida2 = mapaJugador.mapaReal().ToString()

        salida = mapa1.updateArray().ToString

        Label1.Text = salida

        L.Text = salida2


        'beginning.Enabled = False 'Ocultar pulsar el boton.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim posicion1 As Integer = InputBox("Introcuce x =")
        Dim posicion2 As Integer = InputBox("Introduce y =")

        mostrar = mapa1.tirar(posicion1, posicion2)

        Label2.Text = mostrar

    End Sub


End Class
