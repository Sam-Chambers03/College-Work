<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bForm2 = New System.Windows.Forms.Button()
        Me.groupBoxFormSelection = New System.Windows.Forms.GroupBox()
        Me.bAttendanceForm = New System.Windows.Forms.Button()
        Me.bExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupBoxFormSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'bForm2
        '
        Me.bForm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bForm2.Location = New System.Drawing.Point(17, 29)
        Me.bForm2.Name = "bForm2"
        Me.bForm2.Size = New System.Drawing.Size(197, 47)
        Me.bForm2.TabIndex = 0
        Me.bForm2.Text = "Student Records"
        Me.bForm2.UseVisualStyleBackColor = True
        '
        'groupBoxFormSelection
        '
        Me.groupBoxFormSelection.BackColor = System.Drawing.SystemColors.Control
        Me.groupBoxFormSelection.Controls.Add(Me.bAttendanceForm)
        Me.groupBoxFormSelection.Controls.Add(Me.bExit)
        Me.groupBoxFormSelection.Controls.Add(Me.bForm2)
        Me.groupBoxFormSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxFormSelection.Location = New System.Drawing.Point(12, 117)
        Me.groupBoxFormSelection.Name = "groupBoxFormSelection"
        Me.groupBoxFormSelection.Size = New System.Drawing.Size(399, 146)
        Me.groupBoxFormSelection.TabIndex = 1
        Me.groupBoxFormSelection.TabStop = False
        Me.groupBoxFormSelection.Text = "Window Selection Panel"
        '
        'bAttendanceForm
        '
        Me.bAttendanceForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAttendanceForm.Location = New System.Drawing.Point(17, 82)
        Me.bAttendanceForm.Name = "bAttendanceForm"
        Me.bAttendanceForm.Size = New System.Drawing.Size(197, 47)
        Me.bAttendanceForm.TabIndex = 2
        Me.bAttendanceForm.Text = "Student Attendance"
        Me.bAttendanceForm.UseVisualStyleBackColor = True
        '
        'bExit
        '
        Me.bExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bExit.Location = New System.Drawing.Point(315, 82)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(78, 47)
        Me.bExit.TabIndex = 1
        Me.bExit.Text = "Exit"
        Me.bExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome to the Student Record database"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(423, 275)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.groupBoxFormSelection)
        Me.Name = "Form1"
        Me.Text = "Home"
        Me.groupBoxFormSelection.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bForm2 As Button
    Friend WithEvents groupBoxFormSelection As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bExit As Button
    Friend WithEvents bAttendanceForm As Button
End Class
