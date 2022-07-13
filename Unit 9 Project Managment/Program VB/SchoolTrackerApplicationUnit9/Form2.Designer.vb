<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.groupBoxSearch = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbQuickSearch = New System.Windows.Forms.TextBox()
        Me.bQuickSearch = New System.Windows.Forms.Button()
        Me.groupBoxStudentRecordsControls = New System.Windows.Forms.GroupBox()
        Me.bContentsEditor = New System.Windows.Forms.Button()
        Me.bNext = New System.Windows.Forms.Button()
        Me.bPrevious = New System.Windows.Forms.Button()
        Me.bSaveStudentRecords = New System.Windows.Forms.Button()
        Me.bCloseStudentRecords = New System.Windows.Forms.Button()
        Me.bExitForm2 = New System.Windows.Forms.Button()
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
        Me.StudentRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_databaseDataSet = New SchoolTrackerApplicationUnit9.student_databaseDataSet()
        Me.Student_RecordsTableAdapter = New SchoolTrackerApplicationUnit9.student_databaseDataSetTableAdapters.Student_RecordsTableAdapter()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disability = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.groupBoxSearch.SuspendLayout()
        Me.groupBoxStudentRecordsControls.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.groupBoxDataGridStudentRecords.SuspendLayout()
        CType(Me.dgvSearchResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBoxSearch
        '
        Me.groupBoxSearch.BackColor = System.Drawing.SystemColors.Control
        Me.groupBoxSearch.Controls.Add(Me.Label1)
        Me.groupBoxSearch.Controls.Add(Me.Label10)
        Me.groupBoxSearch.Controls.Add(Me.tbQuickSearch)
        Me.groupBoxSearch.Controls.Add(Me.bQuickSearch)
        Me.groupBoxSearch.Location = New System.Drawing.Point(583, 387)
        Me.groupBoxSearch.Name = "groupBoxSearch"
        Me.groupBoxSearch.Size = New System.Drawing.Size(397, 125)
        Me.groupBoxSearch.TabIndex = 14
        Me.groupBoxSearch.TabStop = False
        Me.groupBoxSearch.Text = "Search Database"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Enter the Firstname or Surname you would like to find then click search"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Search:"
        '
        'tbQuickSearch
        '
        Me.tbQuickSearch.Location = New System.Drawing.Point(77, 74)
        Me.tbQuickSearch.Name = "tbQuickSearch"
        Me.tbQuickSearch.Size = New System.Drawing.Size(207, 20)
        Me.tbQuickSearch.TabIndex = 18
        '
        'bQuickSearch
        '
        Me.bQuickSearch.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bQuickSearch.Location = New System.Drawing.Point(290, 74)
        Me.bQuickSearch.Name = "bQuickSearch"
        Me.bQuickSearch.Size = New System.Drawing.Size(57, 20)
        Me.bQuickSearch.TabIndex = 11
        Me.bQuickSearch.Text = "Search"
        Me.bQuickSearch.UseVisualStyleBackColor = False
        '
        'groupBoxStudentRecordsControls
        '
        Me.groupBoxStudentRecordsControls.BackColor = System.Drawing.SystemColors.Control
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bContentsEditor)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bNext)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bPrevious)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bSaveStudentRecords)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bCloseStudentRecords)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bExitForm2)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.BindingNavigator1)
        Me.groupBoxStudentRecordsControls.Location = New System.Drawing.Point(12, 387)
        Me.groupBoxStudentRecordsControls.Name = "groupBoxStudentRecordsControls"
        Me.groupBoxStudentRecordsControls.Size = New System.Drawing.Size(514, 125)
        Me.groupBoxStudentRecordsControls.TabIndex = 13
        Me.groupBoxStudentRecordsControls.TabStop = False
        Me.groupBoxStudentRecordsControls.Text = "Controls"
        '
        'bContentsEditor
        '
        Me.bContentsEditor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bContentsEditor.Location = New System.Drawing.Point(338, 57)
        Me.bContentsEditor.Name = "bContentsEditor"
        Me.bContentsEditor.Size = New System.Drawing.Size(75, 52)
        Me.bContentsEditor.TabIndex = 10
        Me.bContentsEditor.Text = "Edit Contents"
        Me.bContentsEditor.UseVisualStyleBackColor = False
        '
        'bNext
        '
        Me.bNext.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bNext.Location = New System.Drawing.Point(258, 57)
        Me.bNext.Name = "bNext"
        Me.bNext.Size = New System.Drawing.Size(74, 52)
        Me.bNext.TabIndex = 8
        Me.bNext.Text = "Next"
        Me.bNext.UseVisualStyleBackColor = False
        '
        'bPrevious
        '
        Me.bPrevious.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bPrevious.Location = New System.Drawing.Point(6, 57)
        Me.bPrevious.Name = "bPrevious"
        Me.bPrevious.Size = New System.Drawing.Size(76, 52)
        Me.bPrevious.TabIndex = 6
        Me.bPrevious.Text = "Previous"
        Me.bPrevious.UseVisualStyleBackColor = False
        '
        'bSaveStudentRecords
        '
        Me.bSaveStudentRecords.Location = New System.Drawing.Point(88, 57)
        Me.bSaveStudentRecords.Name = "bSaveStudentRecords"
        Me.bSaveStudentRecords.Size = New System.Drawing.Size(80, 52)
        Me.bSaveStudentRecords.TabIndex = 3
        Me.bSaveStudentRecords.Text = "Save Data Sheet"
        Me.bSaveStudentRecords.UseVisualStyleBackColor = True
        '
        'bCloseStudentRecords
        '
        Me.bCloseStudentRecords.Location = New System.Drawing.Point(174, 57)
        Me.bCloseStudentRecords.Name = "bCloseStudentRecords"
        Me.bCloseStudentRecords.Size = New System.Drawing.Size(78, 52)
        Me.bCloseStudentRecords.TabIndex = 4
        Me.bCloseStudentRecords.Text = "Close Data Sheet"
        Me.bCloseStudentRecords.UseVisualStyleBackColor = True
        '
        'bExitForm2
        '
        Me.bExitForm2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bExitForm2.Location = New System.Drawing.Point(419, 57)
        Me.bExitForm2.Name = "bExitForm2"
        Me.bExitForm2.Size = New System.Drawing.Size(76, 52)
        Me.bExitForm2.TabIndex = 1
        Me.bExitForm2.Text = "Home"
        Me.bExitForm2.UseVisualStyleBackColor = False
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
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
        Me.BindingNavigator1.Size = New System.Drawing.Size(508, 25)
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
        Me.groupBoxDataGridStudentRecords.TabIndex = 12
        Me.groupBoxDataGridStudentRecords.TabStop = False
        Me.groupBoxDataGridStudentRecords.Text = "Student Records"
        '
        'dgvSearchResult
        '
        Me.dgvSearchResult.AutoGenerateColumns = False
        Me.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.FirstnameDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.SurnameDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.Disability, Me.GenderDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgvSearchResult.DataSource = Me.StudentRecordsBindingSource
        Me.dgvSearchResult.Location = New System.Drawing.Point(6, 19)
        Me.dgvSearchResult.Name = "dgvSearchResult"
        Me.dgvSearchResult.Size = New System.Drawing.Size(943, 344)
        Me.dgvSearchResult.TabIndex = 0
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
        'Student_RecordsTableAdapter
        '
        Me.Student_RecordsTableAdapter.ClearBeforeFill = True
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Middlename"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Middlename"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'Disability
        '
        Me.Disability.DataPropertyName = "Disability"
        Me.Disability.HeaderText = "Disability"
        Me.Disability.Name = "Disability"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Contact_Number"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Contact_Number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Medical_Details"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Medical_Details"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(988, 518)
        Me.Controls.Add(Me.groupBoxSearch)
        Me.Controls.Add(Me.groupBoxStudentRecordsControls)
        Me.Controls.Add(Me.groupBoxDataGridStudentRecords)
        Me.Name = "Form3"
        Me.Text = "Student Profiles"
        Me.groupBoxSearch.ResumeLayout(False)
        Me.groupBoxSearch.PerformLayout()
        Me.groupBoxStudentRecordsControls.ResumeLayout(False)
        Me.groupBoxStudentRecordsControls.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.groupBoxDataGridStudentRecords.ResumeLayout(False)
        CType(Me.dgvSearchResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupBoxSearch As GroupBox
    Friend WithEvents groupBoxStudentRecordsControls As GroupBox
    Friend WithEvents bNext As Button
    Friend WithEvents bPrevious As Button
    Friend WithEvents bCloseStudentRecords As Button
    Friend WithEvents bSaveStudentRecords As Button
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
    Friend WithEvents bContentsEditor As Button
    Friend WithEvents bExitForm2 As Button
    Friend WithEvents Student_databaseDataSet As student_databaseDataSet
    Friend WithEvents Student_RecordsTableAdapter As student_databaseDataSetTableAdapters.Student_RecordsTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicalDetailsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents bQuickSearch As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents tbQuickSearch As TextBox
    Friend WithEvents StudentRecordsBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Disability As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
