<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.beginning = New System.Windows.Forms.Button()
        Me.mostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'beginning
        '
        Me.beginning.Location = New System.Drawing.Point(3, 12)
        Me.beginning.Name = "beginning"
        Me.beginning.Size = New System.Drawing.Size(126, 33)
        Me.beginning.TabIndex = 0
        Me.beginning.Text = "Generar Mapa"
        Me.beginning.UseVisualStyleBackColor = True
        '
        'mostrar
        '
        Me.mostrar.Location = New System.Drawing.Point(164, 17)
        Me.mostrar.Name = "mostrar"
        Me.mostrar.Size = New System.Drawing.Size(75, 23)
        Me.mostrar.TabIndex = 1
        Me.mostrar.Text = "Mostrar"
        Me.mostrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.mostrar)
        Me.Controls.Add(Me.beginning)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents beginning As Button
    Friend WithEvents mostrar As Button
End Class
