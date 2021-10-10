Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Saylee" And TextBox2.Text = "Saylee" Then
            MsgBox("successful")
            Form2.Show()
        Else
            MsgBox("invalid username or password")
        End If
    End Sub
End Class