<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee_Form
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
        Me.EmployeeBox = New System.Windows.Forms.GroupBox()
        Me.Employee_Status = New System.Windows.Forms.ComboBox()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.Btn_Insert = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Project = New System.Windows.Forms.RichTextBox()
        Me.Hired_Date = New System.Windows.Forms.DateTimePicker()
        Me.Birth_Date = New System.Windows.Forms.DateTimePicker()
        Me.Last_Name = New System.Windows.Forms.TextBox()
        Me.First_Name = New System.Windows.Forms.TextBox()
        Me.Employee_Number = New System.Windows.Forms.TextBox()
        Me.EmployeeBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmployeeBox
        '
        Me.EmployeeBox.AutoSize = True
        Me.EmployeeBox.BackColor = System.Drawing.Color.Transparent
        Me.EmployeeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EmployeeBox.Controls.Add(Me.Employee_Status)
        Me.EmployeeBox.Controls.Add(Me.Btn_Update)
        Me.EmployeeBox.Controls.Add(Me.Btn_Insert)
        Me.EmployeeBox.Controls.Add(Me.Label7)
        Me.EmployeeBox.Controls.Add(Me.Label6)
        Me.EmployeeBox.Controls.Add(Me.Label5)
        Me.EmployeeBox.Controls.Add(Me.Label4)
        Me.EmployeeBox.Controls.Add(Me.Label3)
        Me.EmployeeBox.Controls.Add(Me.Label2)
        Me.EmployeeBox.Controls.Add(Me.Label1)
        Me.EmployeeBox.Controls.Add(Me.Project)
        Me.EmployeeBox.Controls.Add(Me.Hired_Date)
        Me.EmployeeBox.Controls.Add(Me.Birth_Date)
        Me.EmployeeBox.Controls.Add(Me.Last_Name)
        Me.EmployeeBox.Controls.Add(Me.First_Name)
        Me.EmployeeBox.Controls.Add(Me.Employee_Number)
        Me.EmployeeBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.EmployeeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EmployeeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmployeeBox.Location = New System.Drawing.Point(110, 35)
        Me.EmployeeBox.Name = "EmployeeBox"
        Me.EmployeeBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EmployeeBox.Size = New System.Drawing.Size(603, 502)
        Me.EmployeeBox.TabIndex = 0
        Me.EmployeeBox.TabStop = False
        Me.EmployeeBox.Text = "Employee Form"
        '
        'Employee_Status
        '
        Me.Employee_Status.FormattingEnabled = True
        Me.Employee_Status.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.Employee_Status.Location = New System.Drawing.Point(173, 192)
        Me.Employee_Status.MaxDropDownItems = 2
        Me.Employee_Status.Name = "Employee_Status"
        Me.Employee_Status.Size = New System.Drawing.Size(364, 21)
        Me.Employee_Status.TabIndex = 2
        Me.Employee_Status.Text = "Active"
        '
        'Btn_Update
        '
        Me.Btn_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Update.Location = New System.Drawing.Point(368, 452)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(169, 31)
        Me.Btn_Update.TabIndex = 29
        Me.Btn_Update.Text = "Update"
        Me.Btn_Update.UseVisualStyleBackColor = False
        '
        'Btn_Insert
        '
        Me.Btn_Insert.BackColor = System.Drawing.Color.Olive
        Me.Btn_Insert.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Insert.Location = New System.Drawing.Point(63, 452)
        Me.Btn_Insert.Name = "Btn_Insert"
        Me.Btn_Insert.Size = New System.Drawing.Size(170, 31)
        Me.Btn_Insert.TabIndex = 28
        Me.Btn_Insert.Text = "Insert"
        Me.Btn_Insert.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Project"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Hired Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Employee Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Birth Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Employee Number"
        '
        'Project
        '
        Me.Project.BackColor = System.Drawing.Color.White
        Me.Project.ForeColor = System.Drawing.Color.Black
        Me.Project.Location = New System.Drawing.Point(173, 279)
        Me.Project.MaxLength = 50
        Me.Project.Name = "Project"
        Me.Project.Size = New System.Drawing.Size(364, 146)
        Me.Project.TabIndex = 20
        Me.Project.Text = ""
        '
        'Hired_Date
        '
        Me.Hired_Date.CalendarForeColor = System.Drawing.Color.Silver
        Me.Hired_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Hired_Date.Location = New System.Drawing.Point(173, 234)
        Me.Hired_Date.Name = "Hired_Date"
        Me.Hired_Date.Size = New System.Drawing.Size(364, 20)
        Me.Hired_Date.TabIndex = 19
        '
        'Birth_Date
        '
        Me.Birth_Date.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Birth_Date.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Birth_Date.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Birth_Date.CalendarTitleBackColor = System.Drawing.Color.Maroon
        Me.Birth_Date.CalendarTitleForeColor = System.Drawing.Color.White
        Me.Birth_Date.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.Birth_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Birth_Date.Location = New System.Drawing.Point(173, 155)
        Me.Birth_Date.Name = "Birth_Date"
        Me.Birth_Date.Size = New System.Drawing.Size(364, 20)
        Me.Birth_Date.TabIndex = 18
        '
        'Last_Name
        '
        Me.Last_Name.AcceptsReturn = True
        Me.Last_Name.BackColor = System.Drawing.Color.White
        Me.Last_Name.ForeColor = System.Drawing.Color.Black
        Me.Last_Name.Location = New System.Drawing.Point(173, 116)
        Me.Last_Name.MaxLength = 15
        Me.Last_Name.Name = "Last_Name"
        Me.Last_Name.Size = New System.Drawing.Size(364, 20)
        Me.Last_Name.TabIndex = 16
        '
        'First_Name
        '
        Me.First_Name.AcceptsReturn = True
        Me.First_Name.BackColor = System.Drawing.Color.White
        Me.First_Name.ForeColor = System.Drawing.Color.Black
        Me.First_Name.Location = New System.Drawing.Point(173, 79)
        Me.First_Name.MaxLength = 15
        Me.First_Name.Name = "First_Name"
        Me.First_Name.Size = New System.Drawing.Size(364, 20)
        Me.First_Name.TabIndex = 15
        '
        'Employee_Number
        '
        Me.Employee_Number.AcceptsReturn = True
        Me.Employee_Number.AllowDrop = True
        Me.Employee_Number.BackColor = System.Drawing.Color.White
        Me.Employee_Number.ForeColor = System.Drawing.Color.Black
        Me.Employee_Number.Location = New System.Drawing.Point(173, 40)
        Me.Employee_Number.MaxLength = 10
        Me.Employee_Number.Name = "Employee_Number"
        Me.Employee_Number.Size = New System.Drawing.Size(364, 20)
        Me.Employee_Number.TabIndex = 14
        '
        'Employee_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(831, 549)
        Me.Controls.Add(Me.EmployeeBox)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(847, 588)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(847, 588)
        Me.Name = "Employee_Form"
        Me.Text = "Employee_Form"
        Me.EmployeeBox.ResumeLayout(False)
        Me.EmployeeBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmployeeBox As GroupBox
    Friend WithEvents Btn_Update As Button
    Friend WithEvents Btn_Insert As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Project As RichTextBox
    Friend WithEvents Hired_Date As DateTimePicker
    Friend WithEvents Birth_Date As DateTimePicker
    Friend WithEvents Last_Name As TextBox
    Friend WithEvents First_Name As TextBox
    Friend WithEvents Employee_Number As TextBox
    Friend WithEvents Employee_Status As ComboBox
End Class
