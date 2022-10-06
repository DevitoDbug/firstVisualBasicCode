Imports System.Drawing.Imaging

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer

        number = Val(marks.Text) 'getting values from the text box
        If number >= 70 And number <= 100 Then
            grade.Text = "A"
        ElseIf number >= 60 And number <= 69 Then
            grade.Text = "B"
        ElseIf number >= 50 And number <= 59 Then
            grade.Text = "C"
        ElseIf number >= 40 And number <= 49 Then
            grade.Text = "D"
        ElseIf number >= 1 And number <= 39 Then
            grade.Text = "E"
        Else
            grade.Text = "Invalid input"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        grade.Text = ""
        marks.Text = ""


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
