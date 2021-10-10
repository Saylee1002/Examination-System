Public Class Form12

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.CPP' table. You can move, or remove it, as needed.
        Me.CPPTableAdapter.Fill(Me.DatabaseDataSet.CPP)

    End Sub
End Class