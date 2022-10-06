Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim num As Integer

        For num = 0 To 10 Step 2
            ListBox1.Items.Add(num)
        Next

    End Sub
End Class
