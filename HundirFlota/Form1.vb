Public Class Form1

    Dim g As New Game

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mostrar_Click(sender As Object, e As EventArgs) 
        ' MessageBox.Show(salida)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub beginning_Click(sender As Object, e As EventArgs) Handles beginning.Click
        ' For x = 0 To 9
        '  For y = 0 To 9
        '    salida = salida + "1    "

        '  Next
        '      salida = salida + vbNewLine
        ' Next
        ' MessageBox.Show(salida)





        Label1.Text = g.crearArray().ToString
        beginning.Enabled = False
    End Sub



End Class
