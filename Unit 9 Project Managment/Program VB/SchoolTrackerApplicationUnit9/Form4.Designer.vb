<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.bHome = New System.Windows.Forms.Button()
        Me.gbAttandance = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbAttendance = New System.Windows.Forms.ComboBox()
        Me.StudentRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_databaseDataSet = New SchoolTrackerApplicationUnit9.student_databaseDataSet()
        Me.groupBoxStudentRecordsControls = New System.Windows.Forms.GroupBox()
        Me.bNext = New System.Windows.Forms.Button()
        Me.bPrevious = New System.Windows.Forms.Button()
        Me.bSaveStudentRecords = New System.Windows.Forms.Button()
        Me.bCloseStudentRecords = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupBoxDataGridStudentRecords = New System.Windows.Forms.GroupBox()
        Me.dgvSearchResult = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddlenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disability = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Attendance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Student_RecordsTableAdapter = New SchoolTrackerApplicationUnit9.student_databaseDataSetTableAdapters.Student_RecordsTableAdapter()
        Me.gbAttandance.SuspendLayout()
        CType(Me.StudentRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxStudentRecordsControls.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.groupBoxDataGridStudentRecords.SuspendLayout()
        CType(Me.dgvSearchResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bHome
        '
        Me.bHome.Location = New System.Drawing.Point(317, 65)
        Me.bHome.Name = "bHome"
        Me.bHome.Size = New System.Drawing.Size(67, 42)
        Me.bHome.TabIndex = 0
        Me.bHome.Text = "Home"
        Me.bHome.UseVisualStyleBackColor = True
        '
        'gbAttandance
        '
        Me.gbAttandance.BackColor = System.Drawing.SystemColors.Control
        Me.gbAttandance.Controls.Add(Me.Label2)
        Me.gbAttandance.Controls.Add(Me.cbAttendance)
        Me.gbAttandance.Location = New System.Drawing.Point(440, 387)
        Me.gbAttandance.Name = "gbAttandance"
        Me.gbAttandance.Size = New System.Drawing.Size(290, 125)
        Me.gbAttandance.TabIndex = 19
        Me.gbAttandance.TabStop = False
        Me.gbAttandance.Text = "Attendance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Attendance Selecter:"
        '
        'cbAttendance
        '
        Me.cbAttendance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRecordsBindingSource, "Attendance", True))
        Me.cbAttendance.FormattingEnabled = True
        Me.cbAttendance.Items.AddRange(New Object() {"P = Present", "A = Absent", "S = Sick"})
        Me.cbAttendance.Location = New System.Drawing.Point(133, 37)
        Me.cbAttendance.Name = "cbAttendance"
        Me.cbAttendance.Size = New System.Drawing.Size(108, 21)
        Me.cbAttendance.TabIndex = 0
        '
        'StudentRecordsBindingSource
        '
        Me.StudentRecordsBindingSource.DataMember = "Student_Records"
        Me.StudentRecordsBindingSource.DataSource = Me.Student_databaseDataSet
        '
        'Student_databaseDataSet
        '
        Me.Student_databaseDataSet.DataSetName = "student_databaseDataSet"
        Me.Student_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'groupBoxStudentRecordsControls
        '
        Me.groupBoxStudentRecordsControls.BackColor = System.Drawing.SystemColors.Control
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bHome)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bNext)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bPrevious)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bSaveStudentRecords)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bCloseStudentRecords)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.BindingNavigator1)
        Me.groupBoxStudentRecordsControls.Location = New System.Drawing.Point(12, 387)
        Me.groupBoxStudentRecordsControls.Name = "groupBoxStudentRecordsControls"
        Me.groupBoxStudentRecordsControls.Size = New System.Drawing.Size(422, 125)
        Me.groupBoxStudentRecordsControls.TabIndex = 17
        Me.groupBoxStudentRecordsControls.TabStop = False
        Me.groupBoxStudentRecordsControls.Text = "Controls"
        '
        'bNext
        '
        Me.bNext.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bNext.Location = New System.Drawing.Point(244, 65)
        Me.bNext.Name = "bNext"
        Me.bNext.Size = New System.Drawing.Size(67, 42)
        Me.bNext.TabIndex = 8
        Me.bNext.Text = "Next"
        Me.bNext.UseVisualStyleBackColor = False
        '
        'bPrevious
        '
        Me.bPrevious.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bPrevious.Location = New System.Drawing.Point(25, 65)
        Me.bPrevious.Name = "bPrevious"
        Me.bPrevious.Size = New System.Drawing.Size(67, 42)
        Me.bPrevious.TabIndex = 6
        Me.bPrevious.Text = "Previous"
        Me.bPrevious.UseVisualStyleBackColor = False
        '
        'bSaveStudentRecords
        '
        Me.bSaveStudentRecords.Location = New System.Drawing.Point(98, 65)
        Me.bSaveStudentRecords.Name = "bSaveStudentRecords"
        Me.bSaveStudentRecords.Size = New System.Drawing.Size(67, 42)
        Me.bSaveStudentRecords.TabIndex = 3
        Me.bSaveStudentRecords.Text = "Save Data Sheet"
        Me.bSaveStudentRecords.UseVisualStyleBackColor = True
        '
        'bCloseStudentRecords
        '
        Me.bCloseStudentRecords.Location = New System.Drawing.Point(171, 65)
        Me.bCloseStudentRecords.Name = "bCloseStudentRecords"
        Me.bCloseStudentRecords.Size = New System.Drawing.Size(67, 42)
        Me.bCloseStudentRecords.TabIndex = 4
        Me.bCloseStudentRecords.Text = "Close Data Sheet"
        Me.bCloseStudentRecords.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.StudentRecordsBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(416, 25)
        Me.BindingNavigator1.TabIndex = 2
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'groupBoxDataGridStudentRecords
        '
        Me.groupBoxDataGridStudentRecords.BackColor = System.Drawing.SystemColors.Control
        Me.groupBoxDataGridStudentRecords.Controls.Add(Me.dgvSearchResult)
        Me.groupBoxDataGridStudentRecords.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxDataGridStudentRecords.Name = "groupBoxDataGridStudentRecords"
        Me.groupBoxDataGridStudentRecords.Size = New System.Drawing.Size(969, 369)
        Me.groupBoxDataGridStudentRecords.TabIndex = 16
        Me.groupBoxDataGridStudentRecords.TabStop = False
        Me.groupBoxDataGridStudentRecords.Text = "Student Records"
        '
        'dgvSearchResult
        '
        Me.dgvSearchResult.AutoGenerateColumns = False
        Me.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.FirstnameDataGridViewTextBoxColumn, Me.MiddlenameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.Disability, Me.Attendance, Me.DOBDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn})
        Me.dgvSearchResult.DataSource = Me.StudentRecordsBindingSource
        Me.dgvSearchResult.Location = New System.Drawing.Point(6, 19)
        Me.dgvSearchResult.Name = "dgvSearchResult"
        Me.dgvSearchResult.Size = New System.Drawing.Size(943, 344)
        Me.dgvSearchResult.TabIndex = 0
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'MiddlenameDataGridViewTextBoxColumn
        '
        Me.MiddlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.HeaderText = "Middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.Name = "MiddlenameDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'Disability
        '
        Me.Disability.DataPropertyName = "Disability"
        Me.Disability.HeaderText = "Disability"
        Me.Disability.Name = "Disability"
        '
        'Attendance
        '
        Me.Attendance.DataPropertyName = "Attendance"
        Me.Attendance.HeaderText = "Attendance"
        Me.Attendance.Name = "Attendance"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'Student_RecordsTableAdapter
        '
        Me.Student_RecordsTableAdapter.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(986, 528)
        Me.Controls.Add(Me.gbAttandance)
        Me.Controls.Add(Me.groupBoxStudentRecordsControls)
        Me.Controls.Add(Me.groupBoxDataGridStudentRecords)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.gbAttandance.ResumeLayout(False)
        Me.gbAttandance.PerformLayout()
        CType(Me.StudentRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxStudentRecordsControls.ResumeLayout(False)
        Me.groupBoxStudentRecordsControls.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.groupBoxDataGridStudentRecords.ResumeLayout(False)
        CType(Me.dgvSearchResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bHome As Button
    Friend WithEvents gbAttandance As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbAttendance As ComboBox
    Friend WithEvents groupBoxStudentRecordsControls As GroupBox
    Friend WithEvents bNext As Button
    Friend WithEvents bPrevious As Button
    Friend WithEvents bSaveStudentRecords As Button
    Friend WithEvents bCloseStudentRecords As Button
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents groupBoxDataGridStudentRecords As GroupBox
    Friend WithEvents dgvSearchResult As DataGridView
    Friend WithEvents Student_databaseDataSet As student_databaseDataSet
    Friend WithEvents StudentRecordsBindingSource As BindingSource
    Friend WithEvents Student_RecordsTableAdapter As student_databaseDataSetTableAdapters.Student_RecordsTableAdapter
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddlenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Disability As DataGridViewTextBoxColumn
    Friend WithEvents Attendance As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
