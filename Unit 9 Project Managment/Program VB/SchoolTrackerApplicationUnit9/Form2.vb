Public Class Form3

    'this OleDbDataAdapter serves as bridge to our connection and SQL statements
    Dim da As New OleDb.OleDbDataAdapter
    Dim con As New OleDb.OleDbConnection
    'this is a temporary or imaginary tables in the memory of computer same with the datasets
    Dim dt As New DataTable
    Dim sql As String

    Private Sub bClose_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_databaseDataSet.Student_Records' table. You can move, or remove it, as needed.
        Me.Student_RecordsTableAdapter.Fill(Me.Student_databaseDataSet.Student_Records)

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Student_Database.accdb"

    End Sub

    Private Sub bExitForm2_Click(sender As Object, e As EventArgs) Handles bExitForm2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub bContentsEditor_Click(sender As Object, e As EventArgs) Handles bContentsEditor.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub bNext_Click(sender As Object, e As EventArgs) Handles bNext.Click
        StudentRecordsBindingSource.MoveNext()
    End Sub

    Private Sub bPrevious_Click(sender As Object, e As EventArgs) Handles bPrevious.Click
        StudentRecordsBindingSource.MovePrevious()
    End Sub

    Private Sub bSaveStudentRecords_Click(sender As Object, e As EventArgs) Handles bSaveStudentRecords.Click
        On Error GoTo SaveError
        StudentRecordsBindingSource.EndEdit()
        Student_RecordsTableAdapter.Update(Student_databaseDataSet.Student_Records)
        MessageBox.Show("Student Records Have Been Saved.")
SaveError:
        Exit Sub
    End Sub

    Private Sub bCloseStudentRecords_Click(sender As Object, e As EventArgs) Handles bCloseStudentRecords.Click
        Form1.Show()
        Me.Close()
        MessageBox.Show("Student Records Data Sheet Has Been Closed")
    End Sub

    Private Sub bQuickSearch_Click(sender As Object, e As EventArgs) Handles bQuickSearch.Click
        'we set her our SQL statements
        sql = "Select * from Student_Records where Firstname like '%" & tbQuickSearch.Text & "%' or Surname LIKE '%" & tbQuickSearch.Text & "%'"

        dt = New DataTable
        Try
            'open the connection
            con.Open()
            'bind the SQL and the connection through OleDBDataAdaoter and stored to da
            da = New OleDb.OleDbDataAdapter(sql, con)
            'and whatever the value of da will be fill into dt our imaginary data table
            da.Fill(dt)
            'get the datasource of datagridview from our data table
            dgvSearchResult.DataSource = dt

        Catch ex As Exception
            'will throw an error if something went wrong.
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        'close connection
        con.Close()
    End Sub

    Private Sub groupBoxStudentRecordsControls_Enter(sender As Object, e As EventArgs) Handles groupBoxStudentRecordsControls.Enter

    End Sub
End Class