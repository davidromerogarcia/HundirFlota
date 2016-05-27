Public Class Form1
    Dim g As New Game
    Dim salida As String
    Dim sl As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mostrar_Click(sender As Object, e As EventArgs)
        ' MessageBox.Show(salida)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub beginning_Click(sender As Object, e As EventArgs) Handles beginning.Click


        salida = g.updateArray().ToString

        Label1.Text = salida




        'beginning.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim posicion1 As Integer = InputBox("Introcuce x =")
        Dim posicion2 As Integer = InputBox("Introduce y =")


        sl = g.tirar(posicion1, posicion2)

        Label2.Text = sl

    End Sub
End Class
