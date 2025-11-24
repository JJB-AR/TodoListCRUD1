<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalProject
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinalProject))
        ParentPnl = New Panel()
        Panel3 = New Panel()
        Label10 = New Label()
        tbSearch = New TextBox()
        btnCancel = New Button()
        btnSave = New Button()
        dgvTask = New DataGridView()
        taskID = New DataGridViewTextBoxColumn()
        taskName = New DataGridViewTextBoxColumn()
        taskDescription = New DataGridViewTextBoxColumn()
        taskDueDate = New DataGridViewTextBoxColumn()
        taskPriority = New DataGridViewTextBoxColumn()
        taskStatus = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        Panel2 = New Panel()
        pnlFields = New Panel()
        cbStatus = New ComboBox()
        Label8 = New Label()
        cbPriority = New ComboBox()
        Label7 = New Label()
        dateDueDate = New DateTimePicker()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtDescription = New TextBox()
        txtTaskName = New TextBox()
        Label3 = New Label()
        btnClear = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
        Header = New Panel()
        btnClose = New Button()
        Label9 = New Label()
        Label1 = New Label()
        ParentPnl.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvTask, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        pnlFields.SuspendLayout()
        Header.SuspendLayout()
        SuspendLayout()
        ' 
        ' ParentPnl
        ' 
        ParentPnl.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        ParentPnl.Controls.Add(Panel3)
        ParentPnl.Controls.Add(Panel2)
        ParentPnl.Controls.Add(Header)
        ParentPnl.Dock = DockStyle.Fill
        ParentPnl.Location = New Point(0, 0)
        ParentPnl.Margin = New Padding(4)
        ParentPnl.Name = "ParentPnl"
        ParentPnl.Size = New Size(1582, 887)
        ParentPnl.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(tbSearch)
        Panel3.Controls.Add(btnCancel)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(dgvTask)
        Panel3.Controls.Add(Label2)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(308, 104)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1274, 783)
        Panel3.TabIndex = 2
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        Label10.Location = New Point(815, 24)
        Label10.Name = "Label10"
        Label10.Size = New Size(117, 25)
        Label10.TabIndex = 8
        Label10.Text = "Search name"
        ' 
        ' tbSearch
        ' 
        tbSearch.BackColor = Color.White
        tbSearch.BorderStyle = BorderStyle.FixedSingle
        tbSearch.ForeColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        tbSearch.Location = New Point(941, 21)
        tbSearch.Name = "tbSearch"
        tbSearch.Size = New Size(260, 31)
        tbSearch.TabIndex = 7
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(149), CByte(165), CByte(166))
        btnCancel.Enabled = False
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(989, 687)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(258, 49)
        btnCancel.TabIndex = 6
        btnCancel.Text = "&Cancel"
        btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        btnSave.Enabled = False
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(716, 687)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(258, 49)
        btnSave.TabIndex = 6
        btnSave.Text = "&Save"
        btnSave.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' dgvTask
        ' 
        dgvTask.AllowUserToAddRows = False
        dgvTask.AllowUserToDeleteRows = False
        dgvTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTask.BackgroundColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        dgvTask.BorderStyle = BorderStyle.None
        dgvTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTask.Columns.AddRange(New DataGridViewColumn() {taskID, taskName, taskDescription, taskDueDate, taskPriority, taskStatus})
        dgvTask.GridColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        dgvTask.Location = New Point(61, 74)
        dgvTask.Name = "dgvTask"
        dgvTask.ReadOnly = True
        dgvTask.RowHeadersWidth = 51
        dgvTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTask.Size = New Size(1186, 607)
        dgvTask.TabIndex = 1
        ' 
        ' taskID
        ' 
        taskID.DataPropertyName = "taskID"
        taskID.FillWeight = 77.6346054F
        taskID.HeaderText = "ID"
        taskID.MinimumWidth = 6
        taskID.Name = "taskID"
        taskID.ReadOnly = True
        ' 
        ' taskName
        ' 
        taskName.DataPropertyName = "taskName"
        taskName.FillWeight = 77.6346054F
        taskName.HeaderText = "Name"
        taskName.MinimumWidth = 6
        taskName.Name = "taskName"
        taskName.ReadOnly = True
        ' 
        ' taskDescription
        ' 
        taskDescription.DataPropertyName = "taskDescription"
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        taskDescription.DefaultCellStyle = DataGridViewCellStyle1
        taskDescription.FillWeight = 211.826981F
        taskDescription.HeaderText = "Description"
        taskDescription.MinimumWidth = 6
        taskDescription.Name = "taskDescription"
        taskDescription.ReadOnly = True
        ' 
        ' taskDueDate
        ' 
        taskDueDate.DataPropertyName = "taskDueDate"
        taskDueDate.FillWeight = 77.6346054F
        taskDueDate.HeaderText = "Due Date"
        taskDueDate.MinimumWidth = 6
        taskDueDate.Name = "taskDueDate"
        taskDueDate.ReadOnly = True
        ' 
        ' taskPriority
        ' 
        taskPriority.DataPropertyName = "taskPriority"
        taskPriority.FillWeight = 77.6346054F
        taskPriority.HeaderText = "Priority"
        taskPriority.MinimumWidth = 6
        taskPriority.Name = "taskPriority"
        taskPriority.ReadOnly = True
        ' 
        ' taskStatus
        ' 
        taskStatus.DataPropertyName = "taskStatus"
        taskStatus.FillWeight = 77.6346054F
        taskStatus.HeaderText = "Status"
        taskStatus.MinimumWidth = 6
        taskStatus.Name = "taskStatus"
        taskStatus.ReadOnly = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label2.Location = New Point(61, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 37)
        Label2.TabIndex = 0
        Label2.Text = "All Task"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        Panel2.Controls.Add(pnlFields)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(btnUpdate)
        Panel2.Controls.Add(btnAdd)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 104)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(308, 783)
        Panel2.TabIndex = 1
        ' 
        ' pnlFields
        ' 
        pnlFields.BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        pnlFields.Controls.Add(cbStatus)
        pnlFields.Controls.Add(Label8)
        pnlFields.Controls.Add(cbPriority)
        pnlFields.Controls.Add(Label7)
        pnlFields.Controls.Add(dateDueDate)
        pnlFields.Controls.Add(Label6)
        pnlFields.Controls.Add(Label5)
        pnlFields.Controls.Add(Label4)
        pnlFields.Controls.Add(txtDescription)
        pnlFields.Controls.Add(txtTaskName)
        pnlFields.Controls.Add(Label3)
        pnlFields.Enabled = False
        pnlFields.Location = New Point(1, 0)
        pnlFields.Name = "pnlFields"
        pnlFields.Size = New Size(304, 549)
        pnlFields.TabIndex = 6
        ' 
        ' cbStatus
        ' 
        cbStatus.BackColor = Color.White
        cbStatus.FlatStyle = FlatStyle.Flat
        cbStatus.ForeColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Pending", "Done"})
        cbStatus.Location = New Point(15, 488)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(286, 33)
        cbStatus.TabIndex = 4
        cbStatus.Text = "Select Status"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        Label8.Location = New Point(15, 460)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 25)
        Label8.TabIndex = 2
        Label8.Text = "Status"
        ' 
        ' cbPriority
        ' 
        cbPriority.BackColor = Color.White
        cbPriority.FlatStyle = FlatStyle.Flat
        cbPriority.ForeColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        cbPriority.FormattingEnabled = True
        cbPriority.Items.AddRange(New Object() {"Low", "Medium", "High"})
        cbPriority.Location = New Point(15, 408)
        cbPriority.Name = "cbPriority"
        cbPriority.Size = New Size(286, 33)
        cbPriority.TabIndex = 4
        cbPriority.Text = "Select Priority"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        Label7.Location = New Point(15, 380)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 25)
        Label7.TabIndex = 2
        Label7.Text = "Priority"
        ' 
        ' dateDueDate
        ' 
        dateDueDate.CalendarForeColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        dateDueDate.CalendarMonthBackground = Color.White
        dateDueDate.Format = DateTimePickerFormat.Short
        dateDueDate.Location = New Point(15, 330)
        dateDueDate.Name = "dateDueDate"
        dateDueDate.Size = New Size(286, 31)
        dateDueDate.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        Label6.Location = New Point(15, 302)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 25)
        Label6.TabIndex = 2
        Label6.Text = "Due Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        Label5.Location = New Point(15, 201)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 25)
        Label5.TabIndex = 2
        Label5.Text = "Description"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        Label4.Location = New Point(15, 103)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 25)
        Label4.TabIndex = 2
        Label4.Text = "Task Name"
        ' 
        ' txtDescription
        ' 
        txtDescription.BackColor = Color.White
        txtDescription.BorderStyle = BorderStyle.FixedSingle
        txtDescription.ForeColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        txtDescription.Location = New Point(15, 229)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(286, 53)
        txtDescription.TabIndex = 1
        ' 
        ' txtTaskName
        ' 
        txtTaskName.BackColor = Color.White
        txtTaskName.BorderStyle = BorderStyle.FixedSingle
        txtTaskName.ForeColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        txtTaskName.Location = New Point(15, 131)
        txtTaskName.Multiline = True
        txtTaskName.Name = "txtTaskName"
        txtTaskName.Size = New Size(286, 53)
        txtTaskName.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label3.Location = New Point(15, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(184, 37)
        Label3.TabIndex = 0
        Label3.Text = "Add/Edit Task"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        btnClear.Enabled = False
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Arial", 10.8F, FontStyle.Bold)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(16, 720)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(286, 49)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear Fields"
        btnClear.TextImageRelation = TextImageRelation.ImageBeforeText
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Arial", 10.8F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.Location = New Point(16, 665)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(286, 49)
        btnDelete.TabIndex = 5
        btnDelete.Text = "&Delete Task"
        btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Arial", 10.8F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), Image)
        btnUpdate.Location = New Point(16, 610)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(286, 49)
        btnUpdate.TabIndex = 5
        btnUpdate.Text = "&Update Task"
        btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.White
        btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), Image)
        btnAdd.Location = New Point(16, 555)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(286, 49)
        btnAdd.TabIndex = 5
        btnAdd.Text = "&Add Task"
        btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Header
        ' 
        Header.BackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        Header.Controls.Add(btnClose)
        Header.Controls.Add(Label9)
        Header.Controls.Add(Label1)
        Header.Dock = DockStyle.Top
        Header.Location = New Point(0, 0)
        Header.Name = "Header"
        Header.Size = New Size(1582, 104)
        Header.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(1297, 30)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(258, 49)
        btnClose.TabIndex = 7
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 8.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        Label9.Location = New Point(39, 25)
        Label9.Name = "Label9"
        Label9.Size = New Size(112, 16)
        Label9.TabIndex = 0
        Label9.Text = "Made by Jonas"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(35, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 40)
        Label1.TabIndex = 0
        Label1.Text = "To-do List Crud"
        ' 
        ' FinalProject
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1582, 887)
        Controls.Add(ParentPnl)
        Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(0)
        Name = "FinalProject"
        StartPosition = FormStartPosition.CenterScreen
        ParentPnl.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvTask, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        pnlFields.ResumeLayout(False)
        pnlFields.PerformLayout()
        Header.ResumeLayout(False)
        Header.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ParentPnl As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Header As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTaskName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbPriority As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dateDueDate As DateTimePicker
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvTask As DataGridView
    Friend WithEvents taskID As DataGridViewTextBoxColumn
    Friend WithEvents taskName As DataGridViewTextBoxColumn
    Friend WithEvents taskDescription As DataGridViewTextBoxColumn
    Friend WithEvents taskDueDate As DataGridViewTextBoxColumn
    Friend WithEvents taskPriority As DataGridViewTextBoxColumn
    Friend WithEvents taskStatus As DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlFields As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents Label10 As Label

End Class
