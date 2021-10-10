Imports System.Data.OleDb
Public Class Form8
    Dim provider As String
    Dim dataFile As String

    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection


    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.DatabaseDataSet.student)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connection As SqlConnection = New SqlConnection()
        connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\Documents\Visual Studio 2008\Projects\Database\Database.mdb"
        connection.Open()
        Dim adp As SqlDataAdapter = New SqlDataAdapter("Select * from subject ", connection)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        provider = ""
        dataFile = ""
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "update [Items] set [Item] ='" & ItemTxtBox.Text & "',[Cost]='""'"
        Dim 
    End Sub
End Class