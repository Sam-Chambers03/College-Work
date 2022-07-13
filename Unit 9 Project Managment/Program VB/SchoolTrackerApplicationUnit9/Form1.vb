Public Class Form1
    Private Sub bForm2_Click(sender As Object, e As EventArgs) Handles bForm2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bAttendanceForm_Click(sender As Object, e As EventArgs) Handles bAttendanceForm.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class
