Public Class Form4
    Private Sub bHome_Click(sender As Object, e As EventArgs) Handles bHome.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_databaseDataSet.Student_Records' table. You can move, or remove it, as needed.
        Me.Student_RecordsTableAdapter.Fill(Me.Student_databaseDataSet.Student_Records)

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

    Private Sub bPrevious_Click(sender As Object, e As EventArgs) Handles bPrevious.Click
        StudentRecordsBindingSource.MovePrevious()
    End Sub

    Private Sub bNext_Click(sender As Object, e As EventArgs) Handles bNext.Click
        StudentRecordsBindingSource.MoveNext()
    End Sub

    Private Sub cbAttendance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAttendance.SelectedIndexChanged

    End Sub
End Class