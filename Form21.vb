Public Class Form21

    Private Sub Form21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.dbms1' table. You can move, or remove it, as needed.
        Me.Dbms1TableAdapter.Fill(Me.DatabaseDataSet.dbms1)

    End Sub
End Class