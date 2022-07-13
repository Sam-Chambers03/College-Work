Imports System.ComponentModel

Public Class Form2
    Private Sub bExitForm2_Click(sender As Object, e As EventArgs) Handles bExitForm2.Click
        Me.Close()
        Form3.Show()
        MessageBox.Show("Student Records Data Sheet Has Been Closed")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_databaseDataSet.Student_Records' table. You can move, or remove it, as needed.
        Me.Student_RecordsTableAdapter.Fill(Me.Student_databaseDataSet.Student_Records)

    End Sub

    Private Sub bPrevious_Click(sender As Object, e As EventArgs) Handles bPrevious.Click
        StudentRecordsBindingSource.MovePrevious()
    End Sub

    Private Sub bNewRecord_Click(sender As Object, e As EventArgs) Handles bNewRecord.Click
        StudentRecordsBindingSource.AddNew()
    End Sub

    Private Sub bNext_Click(sender As Object, e As EventArgs) Handles bNext.Click
        StudentRecordsBindingSource.MoveNext()
    End Sub

    Private Sub bSaveStudentRecords_Click(sender As Object, e As EventArgs) Handles bSaveStudentRecords.Click
        On Error GoTo SaveError
        StudentRecordsBindingSource.EndEdit()
        Student_RecordsTableAdapter.Update(Student_databaseDataSet.Student_Records)
        MessageBox.Show("Student Records Have Been Saved.")
SaveError:
        Exit Sub
    End Sub

    Private Sub bDeleteRecord_Click(sender As Object, e As EventArgs) Handles bDeleteRecord.Click
        StudentRecordsBindingSource.RemoveCurrent()
    End Sub

    Private Sub bCloseEditor_Click(sender As Object, e As EventArgs) Handles bCloseEditor.Click
        Form3.Show()
        Me.Close()
        MessageBox.Show("Student Records Data Sheet Editor Has Been Closed")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        On Error GoTo SaveError
        StudentRecordsBindingSource.EndEdit()
        Student_RecordsTableAdapter.Update(Student_databaseDataSet.Student_Records)
        MessageBox.Show("Student Records Have Been Saved.")
SaveError:
        Exit Sub
    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Me.Validate()
            StudentRecordsBindingSource.EndEdit()
            Student_RecordsTableAdapter.Update(Me.Student_databaseDataSet.Student_Records)
            Student_databaseDataSet.Tables("Student_Records").AcceptChanges()
            'MessageBox.Show("data saved")'
        Catch ex As Exception
            'MessageBox.Show("Error while saving data")'
        End Try
    End Sub

    Private Sub bContentsEditor_Click(sender As Object, e As EventArgs)
        Form3.Show()
        Me.Close()
    End Sub
End Class