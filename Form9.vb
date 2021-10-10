Public Class Form9
    Dim i As Integer


    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.subject' table. You can move, or remove it, as needed.
        Me.SubjectTableAdapter.Fill(Me.DatabaseDataSet.subject)

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
        Dim i As Integer

        i = DataGridView1.CurrentRow.Index

        Me.txt_id.Text = DataGridView1.Item(0, i).Value

        Me.txt_fname.Text = DataGridView1.Item(1, i).Value

        Me.txt_lname.Text = DataGridView1.Item(2, i).Value

        Me.txt_address.Text = DataGridView1.Item(3, i).Value

        Me.txt_email.Text = DataGridView1.Item(4, i).Value

        Me.txt_contact.Text = DataGridView1.Item(5, i).Value

        Me.DateTimePicker1.Text = DataGridView1.Item(6, i).Value

        Dim sqlquery As String = "UPDATE users SET Firstname = '" & txt_fname.Text & "', Lastname = '" & txt_lname.Text & "', Address = '" & txt_address.Text & "', Email = '" & txt_email.Text & "', Contact = '" & txt_contact.Text & "', Birthday = '" & DateTimePicker1.Text & "' WHERE ID = " & txt_id.Text & ""



        Dim sqlcommand As New OleDbCommand


        With sqlcommand

            .CommandText = sqlquery

            .Connection = con

            .ExecuteNonQuery()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtSearchResult.Text = ""

        Dim vSearch As String = InputBox("Enter Integer number to search name:")

        If vSearch <> "" Then

            cmdOLEDB.CommandText = "SELECT Au_ID,"
            Author FROM Authors WHERE Au_ID=" & CInt(vSearch) 

            cmdOLEDB.Connection = cnnOLEDB

            Dim rdrOLEDB As OleDbDataReader = cmdOLEDB.ExecuteReader

            If rdrOLEDB.Read = True Then

        txtSearchResult.Text &= rdrOLEDB.Item(0).ToString & " " & 
                rdrOLEDB.Item(1).ToString()

                rdrOLEDB.Close()

            Else

                MsgBox(rdrOLEDB.Close())

                MsgBox("Record not found")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtAu_ID.Text <> "" Then

        cmdDelete.CommandText = "DELETE FROM Authors WHERE Au_ID = " &
            txtAu_ID.Text  & ";" 

            'MsgBox(cmdDelete.CommandText)

            cmdDelete.CommandType = CommandType.Text

            cmdDelete.Connection = cnnOLEDB

            cmdDelete.ExecuteNonQuery()

        MsgBox(txtAu_ID.Text = "Record deleted.")"" 

            txtAuthor.Text = ""

            cmdDelete.Dispose()

        Else

            MsgBox("Enter the required values:" & vbNewLine & "1. Au_ID")

        End If

        cmdUpdate.Dispose()

    End Sub
End Class
