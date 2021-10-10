Public Class Form18

    Private Sub Form18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.question' table. You can move, or remove it, as needed.
        Me.QuestionTableAdapter.Fill(Me.DatabaseDataSet.question)

    End Sub
End Class