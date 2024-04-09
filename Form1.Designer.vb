<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Employee_Grid = New System.Windows.Forms.DataGridView()
        Me.Add_Employee = New System.Windows.Forms.Button()
        Me.Btn_Refresh = New System.Windows.Forms.Button()
        Me.Index = New System.Windows.Forms.ComboBox()
        Me.Keyword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Next_Page = New System.Windows.Forms.Button()
        Me.Back_Page = New System.Windows.Forms.Button()
        Me.Label_For_Page = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Key_Date = New System.Windows.Forms.DateTimePicker()
        Me.Select_Status = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.Employee_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Employee_Grid
        '
        Me.Employee_Grid.AllowDrop = True
        Me.Employee_Grid.AllowUserToAddRows = False
        Me.Employee_Grid.AllowUserToDeleteRows = False
        Me.Employee_Grid.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.Employee_Grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.Employee_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Employee_Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Employee_Grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Employee_Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Employee_Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.MediumAquamarine
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Employee_Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.Employee_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Employee_Grid.DefaultCellStyle = DataGridViewCellStyle8
        Me.Employee_Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Employee_Grid.EnableHeadersVisualStyles = False
        Me.Employee_Grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Employee_Grid.Location = New System.Drawing.Point(94, 133)
        Me.Employee_Grid.Name = "Employee_Grid"
        Me.Employee_Grid.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Employee_Grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Employee_Grid.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Employee_Grid.RowTemplate.Height = 40
        Me.Employee_Grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Employee_Grid.Size = New System.Drawing.Size(1188, 367)
        Me.Employee_Grid.TabIndex = 1
        Me.Employee_Grid.VirtualMode = True
        '
        'Add_Employee
        '
        Me.Add_Employee.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Add_Employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Employee.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Add_Employee.Location = New System.Drawing.Point(225, 79)
        Me.Add_Employee.Name = "Add_Employee"
        Me.Add_Employee.Size = New System.Drawing.Size(132, 34)
        Me.Add_Employee.TabIndex = 1
        Me.Add_Employee.Text = "Add_Employee"
        Me.Add_Employee.UseVisualStyleBackColor = False
        '
        'Btn_Refresh
        '
        Me.Btn_Refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Refresh.Location = New System.Drawing.Point(94, 79)
        Me.Btn_Refresh.Name = "Btn_Refresh"
        Me.Btn_Refresh.Size = New System.Drawing.Size(116, 34)
        Me.Btn_Refresh.TabIndex = 2
        Me.Btn_Refresh.Text = "Refresh"
        Me.Btn_Refresh.UseVisualStyleBackColor = False
        '
        'Index
        '
        Me.Index.BackColor = System.Drawing.Color.White
        Me.Index.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Index.ForeColor = System.Drawing.Color.Black
        Me.Index.FormattingEnabled = True
        Me.Index.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Index.IntegralHeight = False
        Me.Index.ItemHeight = 13
        Me.Index.Location = New System.Drawing.Point(524, 82)
        Me.Index.Name = "Index"
        Me.Index.Size = New System.Drawing.Size(258, 21)
        Me.Index.TabIndex = 5
        '
        'Keyword
        '
        Me.Keyword.BackColor = System.Drawing.Color.White
        Me.Keyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keyword.ForeColor = System.Drawing.Color.Black
        Me.Keyword.Location = New System.Drawing.Point(972, 83)
        Me.Keyword.Name = "Keyword"
        Me.Keyword.Size = New System.Drawing.Size(300, 20)
        Me.Keyword.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(377, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select Index for Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(818, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Enter Keyword to Search"
        '
        'Next_Page
        '
        Me.Next_Page.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Next_Page.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Next_Page.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Next_Page.Location = New System.Drawing.Point(25, 17)
        Me.Next_Page.Name = "Next_Page"
        Me.Next_Page.Size = New System.Drawing.Size(79, 34)
        Me.Next_Page.TabIndex = 3
        Me.Next_Page.Text = ">>"
        Me.Next_Page.UseVisualStyleBackColor = False
        '
        'Back_Page
        '
        Me.Back_Page.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Back_Page.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_Page.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Back_Page.Location = New System.Drawing.Point(237, 16)
        Me.Back_Page.Name = "Back_Page"
        Me.Back_Page.Size = New System.Drawing.Size(78, 34)
        Me.Back_Page.TabIndex = 4
        Me.Back_Page.Text = "<<"
        Me.Back_Page.UseVisualStyleBackColor = False
        '
        'Label_For_Page
        '
        Me.Label_For_Page.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_For_Page.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_For_Page.Location = New System.Drawing.Point(119, 16)
        Me.Label_For_Page.Name = "Label_For_Page"
        Me.Label_For_Page.Size = New System.Drawing.Size(101, 34)
        Me.Label_For_Page.TabIndex = 9
        Me.Label_For_Page.Text = "out of"
        Me.Label_For_Page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Next_Page)
        Me.GroupBox1.Controls.Add(Me.Label_For_Page)
        Me.GroupBox1.Controls.Add(Me.Back_Page)
        Me.GroupBox1.Location = New System.Drawing.Point(942, 506)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 57)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Key_Date
        '
        Me.Key_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Key_Date.Location = New System.Drawing.Point(972, 84)
        Me.Key_Date.Name = "Key_Date"
        Me.Key_Date.Size = New System.Drawing.Size(310, 20)
        Me.Key_Date.TabIndex = 11
        '
        'Select_Status
        '
        Me.Select_Status.FormattingEnabled = True
        Me.Select_Status.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.Select_Status.Location = New System.Drawing.Point(972, 83)
        Me.Select_Status.Name = "Select_Status"
        Me.Select_Status.Size = New System.Drawing.Size(310, 21)
        Me.Select_Status.TabIndex = 12
        Me.Select_Status.Text = "Active"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(-5, -1)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1370, 47)
        Me.FlowLayoutPanel1.TabIndex = 13
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 644)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Select_Status)
        Me.Controls.Add(Me.Key_Date)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Keyword)
        Me.Controls.Add(Me.Index)
        Me.Controls.Add(Me.Btn_Refresh)
        Me.Controls.Add(Me.Add_Employee)
        Me.Controls.Add(Me.Employee_Grid)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Employee"
        Me.Text = "Employee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Employee_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Employee_Grid As DataGridView
    Friend WithEvents Add_Employee As Button
    Friend WithEvents Btn_Refresh As Button
    Friend WithEvents Keyword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Next_Page As Button
    Friend WithEvents Back_Page As Button
    Friend WithEvents Label_For_Page As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Key_Date As DateTimePicker
    Friend WithEvents Select_Status As ComboBox
    Friend WithEvents Index As ComboBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
