﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btncerrar1.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncerrar2.Click
        Me.Close()

    End Sub
End Class
