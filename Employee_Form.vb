Public Class Employee_Form
    'to catch variable passed from form1
    Public Sub New(ByVal empid As String)
        InitializeComponent()
        If (empid = "") Then
            'if value is not passed means insert form
            Btn_Update.Visible = False
        Else
            Dim employeeNumber As String = empid
            Employee_Number.ReadOnly = True
            Employee_Number.Enabled = False
            Employee_Number.BackColor = Color.AntiqueWhite
            Open_Form(employeeNumber)
            'if value is passed means update form
            Btn_Insert.Visible = False
        End If
    End Sub
    'global selection string
    Private Sub Employee_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Birth_Date.MaxDate = Date.Today.AddYears(-10)
        Birth_Date.MinDate = Date.Today.AddYears(-50)
        Hired_Date.MaxDate = Date.Today
    End Sub
    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Btn_Insert.Click
        'empty fields not acceptable
        Dim insertData As Boolean

        If (Employee_Number.Text = "" Or First_Name.Text = "" Or Last_Name.Text = "" Or Birth_Date.Text = "" Or Employee_Status.Text = "" Or Birth_Date.Text = "" Or Project.Text = "") Then
            MessageBox.Show("Some fields are Empty!!")
        Else
            'inserting data from form to database
            If (Employee_Count(Employee_Number.Text).ToString() > 0) Then
                MessageBox.Show("Try again with another Employee_Number.This Employee_Number has been already used!!.")
            Else
                insertData = Add_Employee(Employee_Number.Text.ToString().Trim(), First_Name.Text.ToString().Trim(), Last_Name.Text.ToString().Trim(), employeeStatus.Trim(), Birth_Date.Text.ToString().Trim(), Hired_Date.Text.ToString().Trim(), Project.Text.ToString().Trim())
                If (insertData) Then
                    'success
                    MessageBox.Show("Success fully inserted Employee Record!!.")
                    Me.Close()
                Else
                    MessageBox.Show("Failed to insert Employee Record!! Please try again!")
                    'failed because already empno used
                End If
            End If
        End If
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        'empty fields not acceptable
        If (Employee_Number.Text = "" Or First_Name.Text = "" Or Last_Name.Text = "" Or Birth_Date.Text = "" Or Employee_Status.Text = "" Or Birth_Date.Text = "" Or Project.Text = "") Then
            MessageBox.Show("Some fields are empty!!")
        Else
            'using data from update from to update database.
            Dim updatetData As Boolean = Update_Employee(Employee_Number.Text.ToString().Trim(), First_Name.Text.ToString().Trim(), Last_Name.Text.ToString().Trim(), employeeStatus, Birth_Date.Text.ToString().Trim(), Hired_Date.Text.ToString().Trim(), Project.Text.ToString().Trim())
            'MessageBox.Show(updatetData)
            If (updatetData) Then
                'success
                MessageBox.Show("Success fully updated Employee Record!!.")
                Me.Close()
            Else
                'incase error in coding
                MessageBox.Show("Oofs Something went wrong.Please try again!!.")
            End If
        End If
    End Sub

    Public Sub Open_Form(ByVal empid As String)
        'Before editing data must be shown in form
        singleEmployee = Get_Single_Employee(empid)
        Dim employeeData = singleEmployee.Split("-")
        Employee_Number.Text = employeeData(0).ToString()
        First_Name.Text = employeeData(1).ToString()
        Last_Name.Text = employeeData(2).ToString()
        Birth_Date.Text = employeeData(4).ToString()
        Hired_Date.Text = employeeData(5).ToString()
        Project.Text = employeeData(6).ToString()
        If (employeeData(3).ToString() = "1") Then
            Employee_Status.SelectedIndex = 0
        ElseIf (employeeData(3).ToString() = "0") Then
            Employee_Status.SelectedIndex = 1
        Else
        End If
    End Sub

    Private Sub Birth_Date_ValueChanged(sender As Object, e As EventArgs) Handles Birth_Date.ValueChanged
    End Sub

    Private Sub Hired_Date_ValueChanged(sender As Object, e As EventArgs) Handles Hired_Date.ValueChanged
    End Sub

    Private Sub Employee_Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Employee_Status.TextChanged
        If (Employee_Status.Text = "Active") Then
            employeeStatus = "1"
        ElseIf (Employee_Status.Text = "Inactive") Then
            employeeStatus = "0"
        Else
            Employee_Status.Text = "Active"
            employeeStatus = "1"
        End If
    End Sub
    'allow only numbers
    Private Sub Employee_Number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Employee_Number.KeyPress
        If (Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
    'allow only letters
    Private Sub First_Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles First_Name.KeyPress
        If (Not Char.IsControl(e.KeyChar) And Not Char.IsLetter(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
    'allow only letters
    Private Sub Last_Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Last_Name.KeyPress
        If (Not Char.IsControl(e.KeyChar) And Not Char.IsLetter(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
    'allow only letters and spaces.

    Private Sub Project_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Project.KeyPress
        If (Not Char.IsControl(e.KeyChar) And Not projectTitlePattern.Contains(e.KeyChar)) Then
            e.Handled = True
        End If
        If (Project.Text = "" And (" .").Contains(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class