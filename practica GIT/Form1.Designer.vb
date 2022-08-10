<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btncerrar2 = New System.Windows.Forms.Button()
        Me.btncerrar1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncerrar2
        '
        Me.btncerrar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar2.Location = New System.Drawing.Point(113, 259)
        Me.btncerrar2.Name = "btncerrar2"
        Me.btncerrar2.Size = New System.Drawing.Size(89, 38)
        Me.btncerrar2.TabIndex = 0
        Me.btncerrar2.Text = "Cerrar"
        Me.btncerrar2.UseVisualStyleBackColor = True
        '
        'btncerrar1
        '
        Me.btncerrar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar1.Location = New System.Drawing.Point(113, 122)
        Me.btncerrar1.Name = "btncerrar1"
        Me.btncerrar1.Size = New System.Drawing.Size(89, 40)
        Me.btncerrar1.TabIndex = 1
        Me.btncerrar1.Text = "Cerrar"
        Me.btncerrar1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cerrar los 2 formularios " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y salir de la aplicacion "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 46)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cerrar solamente " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  este formulario "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 386)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncerrar1)
        Me.Controls.Add(Me.btncerrar2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncerrar2 As Button
    Friend WithEvents btncerrar1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
