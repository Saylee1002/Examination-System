Public Class Form11

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.java' table. You can move, or remove it, as needed.
        Me.JavaTableAdapter.Fill(Me.DatabaseDataSet.java)

    End Sub
End Class