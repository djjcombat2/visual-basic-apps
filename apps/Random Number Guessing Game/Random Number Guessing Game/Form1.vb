﻿Public Class Form1

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim integerNumber As Integer    ' Declare an integer variable
        Dim randomNumber As New Random  ' Create a Random object

        ' Get an random integer and assign it to integerNumber
        integerNumber = randomNumber.Next()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
