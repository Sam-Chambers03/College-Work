<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.bExitForm2 = New System.Windows.Forms.Button()
        Me.groupBoxDataGridStudentRecords = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_databaseDataSet = New SchoolTrackerApplicationUnit9.student_databaseDataSet()
        Me.groupBoxStudentRecordsControls = New System.Windows.Forms.GroupBox()
        Me.bDeleteRecord = New System.Windows.Forms.Button()
        Me.bNext = New System.Windows.Forms.Button()
        Me.bPrevious = New System.Windows.Forms.Button()
        Me.bNewRecord = New System.Windows.Forms.Button()
        Me.bCloseEditor = New System.Windows.Forms.Button()
        Me.bSaveStudentRecords = New System.Windows.Forms.Button()
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
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.groupBoxContentsEditor = New System.Windows.Forms.GroupBox()
        Me.rtbMedical = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbContactNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rtbAddress = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbSurname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbFirstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbStudentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Student_RecordsTableAdapter = New SchoolTrackerApplicationUnit9.student_databaseDataSetTableAdapters.Student_RecordsTableAdapter()
        Me.cbAttendance = New System.Windows.Forms.ComboBox()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddlenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disability = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicalDetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbDisability = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.groupBoxDataGridStudentRecords.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxStudentRecordsControls.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.groupBoxContentsEditor.SuspendLayout()
        Me.SuspendLayout()
        '
        'bExitForm2
        '
        Me.bExitForm2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bExitForm2.Location = New System.Drawing.Point(11, 154)
        Me.bExitForm2.Name = "bExitForm2"
        Me.bExitForm2.Size = New System.Drawing.Size(164, 52)
        Me.bExitForm2.TabIndex = 1
        Me.bExitForm2.Text = "Back"
        Me.bExitForm2.UseVisualStyleBackColor = False
        '
        'groupBoxDataGridStudentRecords
        '
        Me.groupBoxDataGridStudentRecords.BackColor = System.Drawing.SystemColors.Control
        Me.groupBoxDataGridStudentRecords.Controls.Add(Me.DataGridView1)
        Me.groupBoxDataGridStudentRecords.Location = New System.Drawing.Point(11, 12)
        Me.groupBoxDataGridStudentRecords.Name = "groupBoxDataGridStudentRecords"
        Me.groupBoxDataGridStudentRecords.Size = New System.Drawing.Size(969, 320)
        Me.groupBoxDataGridStudentRecords.TabIndex = 2
        Me.groupBoxDataGridStudentRecords.TabStop = False
        Me.groupBoxDataGridStudentRecords.Text = "Student Records"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.FirstnameDataGridViewTextBoxColumn, Me.MiddlenameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.Disability, Me.MedicalDetailsDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentRecordsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(943, 287)
        Me.DataGridView1.TabIndex = 0
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
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bDeleteRecord)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bNext)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bPrevious)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bNewRecord)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bCloseEditor)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bSaveStudentRecords)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.BindingNavigator1)
        Me.groupBoxStudentRecordsControls.Controls.Add(Me.bExitForm2)
        Me.groupBoxStudentRecordsControls.Location = New System.Drawing.Point(12, 338)
        Me.groupBoxStudentRecordsControls.Name = "groupBoxStudentRecordsControls"
        Me.groupBoxStudentRecordsControls.Size = New System.Drawing.Size(492, 278)
        Me.groupBoxStudentRecordsControls.TabIndex = 3
        Me.groupBoxStudentRecordsControls.TabStop = False
        Me.groupBoxStudentRecordsControls.Text = "Controls"
        '
        'bDeleteRecord
        '
        Me.bDeleteRecord.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bDeleteRecord.Location = New System.Drawing.Point(181, 68)
        Me.bDeleteRecord.Name = "bDeleteRecord"
        Me.bDeleteRecord.Size = New System.Drawing.Size(79, 34)
        Me.bDeleteRecord.TabIndex = 9
        Me.bDeleteRecord.Text = "Delete Record"
        Me.bDeleteRecord.UseVisualStyleBackColor = False
        '
        'bNext
        '
        Me.bNext.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bNext.Location = New System.Drawing.Point(266, 68)
        Me.bNext.Name = "bNext"
        Me.bNext.Size = New System.Drawing.Size(79, 34)
        Me.bNext.TabIndex = 8
        Me.bNext.Text = "Next"
        Me.bNext.UseVisualStyleBackColor = False
        '
        'bPrevious
        '
        Me.bPrevious.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bPrevious.Location = New System.Drawing.Point(11, 68)
        Me.bPrevious.Name = "bPrevious"
        Me.bPrevious.Size = New System.Drawing.Size(79, 34)
        Me.bPrevious.TabIndex = 6
        Me.bPrevious.Text = "Previous"
        Me.bPrevious.UseVisualStyleBackColor = False
        '
        'bNewRecord
        '
        Me.bNewRecord.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bNewRecord.Location = New System.Drawing.Point(96, 68)
        Me.bNewRecord.Name = "bNewRecord"
        Me.bNewRecord.Size = New System.Drawing.Size(79, 34)
        Me.bNewRecord.TabIndex = 5
        Me.bNewRecord.Text = "New Record"
        Me.bNewRecord.UseVisualStyleBackColor = False
        '
        'bCloseEditor
        '
        Me.bCloseEditor.Location = New System.Drawing.Point(181, 113)
        Me.bCloseEditor.Name = "bCloseEditor"
        Me.bCloseEditor.Size = New System.Drawing.Size(164, 30)
        Me.bCloseEditor.TabIndex = 4
        Me.bCloseEditor.Text = "Close Data Sheet"
        Me.bCloseEditor.UseVisualStyleBackColor = True
        '
        'bSaveStudentRecords
        '
        Me.bSaveStudentRecords.Location = New System.Drawing.Point(11, 113)
        Me.bSaveStudentRecords.Name = "bSaveStudentRecords"
        Me.bSaveStudentRecords.Size = New System.Drawing.Size(164, 30)
        Me.bSaveStudentRecords.TabIndex = 3
        Me.bSaveStudentRecords.Text = "Save Data Sheet"
        Me.bSaveStudentRecords.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(486, 25)
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'groupBoxContentsEditor
        '
        Me.groupBoxContentsEditor.BackColor = System.Drawing.SystemColors.Control
        Me.groupBoxContentsEditor.Controls.Add(Me.cbDisability)
        Me.groupBoxContentsEditor.Controls.Add(Me.Label10)
        Me.groupBoxContentsEditor.Controls.Add(Me.cbAttendance)
        Me.groupBoxContentsEditor.Controls.Add(Me.rtbMedical)
        Me.groupBoxContentsEditor.Controls.Add(Me.Label9)
        Me.groupBoxContentsEditor.Controls.Add(Me.tbContactNum)
        Me.groupBoxContentsEditor.Controls.Add(Me.Label8)
        Me.groupBoxContentsEditor.Controls.Add(Me.Label7)
        Me.groupBoxContentsEditor.Controls.Add(Me.rtbAddress)
        Me.groupBoxContentsEditor.Controls.Add(Me.Label6)
        Me.groupBoxContentsEditor.Controls.Add(Me.DateTimePicker1)
        Me.groupBoxContentsEditor.Controls.Add(Me.Label5)
        Me.groupBoxContentsEditor.Controls.Add(Me.TextBox1)
        Me.groupBoxContentsEditor.Controls.Add(Me.Label4)
        Me.groupBoxContentsEditor.Controls.Add(Me.tbSurname)
        Me.groupBoxContentsEditor.Controls.Add(Me.Label3)
        Me.groupBoxContentsEditor.Controls.Add(Me.tbFirstname)
        Me.groupBoxContentsEditor.Controls.Add(Me.Label2)
        Me.groupBoxContentsEditor.Controls.Add(Me.tbStudentID)
        Me.groupBoxContentsEditor.Controls.Add(Me.Label1)
        Me.groupBoxContentsEditor.Location = New System.Drawing.Point(510, 338)
        Me.groupBoxContentsEditor.Name = "groupBoxContentsEditor"
        Me.groupBoxContentsEditor.Size = New System.Drawing.Size(470, 278)
        Me.groupBoxContentsEditor.TabIndex = 4
        Me.groupBoxContentsEditor.TabStop = False
        Me.groupBoxContentsEditor.Text = "Contents Editor"
        '
        'rtbMedical
        '
        Me.rtbMedical.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRecordsBindingSource, "Medical_Details", True))
        Me.rtbMedical.Location = New System.Drawing.Point(295, 148)
        Me.rtbMedical.Name = "rtbMedical"
        Me.rtbMedical.Size = New System.Drawing.Size(161, 107)
        Me.rtbMedical.TabIndex = 17
        Me.rtbMedical.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(292, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Medical Details:"
        '
        'tbContactNum
        '
        Me.tbContactNum.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.StudentRecordsBindingSource, "Contact_Number", True))
        Me.tbContactNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRecordsBindingSource, "Contact_Number", True))
        Me.tbContactNum.Location = New System.Drawing.Point(346, 68)
        Me.tbContactNum.Name = "tbContactNum"
        Me.tbContactNum.Size = New System.Drawing.Size(73, 20)
        Me.tbContactNum.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(253, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Contact Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(295, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Gender:"
        '
        'rtbAddress
        '
        Me.rtbAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRecordsBindingSource, "Address", True))
        Me.rtbAddress.Location = New System.Drawing.Point(84, 177)
        Me.rtbAddress.Name = "rtbAddress"
        Me.rtbAddress.Size = New System.Drawing.Size(143, 78)
        Me.rtbAddress.TabIndex = 11
        Me.rtbAddress.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Address:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRecordsBindingSource, "DOB", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(84, 148)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "DOB:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRecordsBindingSource, "Middlename", True))
        Me.TextBox1.Location = New System.Drawing.Point(84, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(101, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Middle Name:"
        '
        'tbSurname
        '
        Me.tbSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRecordsBindingSource, "Surname", True))
        Me.tbSurname.Location = New System.Drawing.Point(84, 122)
        Me.tbSurname.Name = "tbSurname"
        Me.tbSurname.Size = New System.Drawing.Size(101, 20)
        Me.tbSurname.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Surname:"
        '
        'tbFirstname
        '
        Me.tbFirstname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRecordsBindingSource, "Firstname", True))
        Me.tbFirstname.Location = New System.Drawing.Point(84, 68)
        Me.tbFirstname.Name = "tbFirstname"
        Me.tbFirstname.Size = New System.Drawing.Size(101, 20)
        Me.tbFirstname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Firstname:"
        '
        'tbStudentID
        '
        Me.tbStudentID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRecordsBindingSource, "ID", True))
        Me.tbStudentID.Location = New System.Drawing.Point(84, 42)
        Me.tbStudentID.Name = "tbStudentID"
        Me.tbStudentID.Size = New System.Drawing.Size(101, 20)
        Me.tbStudentID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student ID:"
        '
        'Student_RecordsTableAdapter
        '
        Me.Student_RecordsTableAdapter.ClearBeforeFill = True
        '
        'cbAttendance
        '
        Me.cbAttendance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRecordsBindingSource, "Gender", True))
        Me.cbAttendance.FormattingEnabled = True
        Me.cbAttendance.Items.AddRange(New Object() {"Male ", "Female"})
        Me.cbAttendance.Location = New System.Drawing.Point(346, 41)
        Me.cbAttendance.Name = "cbAttendance"
        Me.cbAttendance.Size = New System.Drawing.Size(73, 21)
        Me.cbAttendance.TabIndex = 18
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
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
        'Disability
        '
        Me.Disability.DataPropertyName = "Disability"
        Me.Disability.HeaderText = "Disability"
        Me.Disability.Name = "Disability"
        '
        'MedicalDetailsDataGridViewTextBoxColumn
        '
        Me.MedicalDetailsDataGridViewTextBoxColumn.DataPropertyName = "Medical_Details"
        Me.MedicalDetailsDataGridViewTextBoxColumn.HeaderText = "Medical_Details"
        Me.MedicalDetailsDataGridViewTextBoxColumn.Name = "MedicalDetailsDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "Contact_Number"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "Contact_Number"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'cbDisability
        '
        Me.cbDisability.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRecordsBindingSource, "Disability", True))
        Me.cbDisability.FormattingEnabled = True
        Me.cbDisability.Items.AddRange(New Object() {"No ", "Yes"})
        Me.cbDisability.Location = New System.Drawing.Point(346, 99)
        Me.cbDisability.Name = "cbDisability"
        Me.cbDisability.Size = New System.Drawing.Size(73, 21)
        Me.cbDisability.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(289, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Disability:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(991, 628)
        Me.Controls.Add(Me.groupBoxContentsEditor)
        Me.Controls.Add(Me.groupBoxStudentRecordsControls)
        Me.Controls.Add(Me.groupBoxDataGridStudentRecords)
        Me.Name = "Form2"
        Me.Text = "Student Profiles Editor"
        Me.groupBoxDataGridStudentRecords.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxStudentRecordsControls.ResumeLayout(False)
        Me.groupBoxStudentRecordsControls.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.groupBoxContentsEditor.ResumeLayout(False)
        Me.groupBoxContentsEditor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bExitForm2 As Button
    Friend WithEvents groupBoxDataGridStudentRecords As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents groupBoxStudentRecordsControls As GroupBox
    Friend WithEvents bCloseEditor As Button
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
    Friend WithEvents groupBoxContentsEditor As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbSurname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbFirstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbStudentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbContactNum As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents rtbAddress As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bDeleteRecord As Button
    Friend WithEvents bNext As Button
    Friend WithEvents bPrevious As Button
    Friend WithEvents bNewRecord As Button
    Friend WithEvents rtbMedical As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Student_databaseDataSet As student_databaseDataSet
    Friend WithEvents Student_RecordsTableAdapter As student_databaseDataSetTableAdapters.Student_RecordsTableAdapter
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentRecordsBindingSource As BindingSource
    Friend WithEvents cbAttendance As ComboBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddlenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Disability As DataGridViewTextBoxColumn
    Friend WithEvents MedicalDetailsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cbDisability As ComboBox
    Friend WithEvents Label10 As Label
End Class
