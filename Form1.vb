Public Class Employee
    Public Sub New()
        'Get_PagingDS()
        InitializeComponent()
        'Show Employee grid
        Bind_Employee_Grid()
    End Sub
    Public Sub Employee_Data()
        'loading datasource
        Employee_Grid.DataSource = pagingDS
        Employee_Grid.DataMember = "Employees"
        Page_Label()
    End Sub
    Public Sub Bind_Employee_Grid()
        Try
            Employee_Grid.EnableHeadersVisualStyles = False
            Employee_Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange
            Employee_Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Employee_Grid.ColumnHeadersHeight = 30
            Employee_Grid.RowTemplate.Height = 40
            Keyword.ReadOnly = True
            pagingDS = Get_PagingDS()
            Employee_Data()
            'To display edit and delete link after 7 th position if there is 7 columns then only
            If (Employee_Grid.ColumnCount = 7) Then
                'Creating and inserting link column for edit operation
                Dim LinkEditColumn As DataGridViewLinkColumn = New DataGridViewLinkColumn()
                LinkEditColumn.HeaderText = "Edit Action"
                LinkEditColumn.MinimumWidth = 30
                LinkEditColumn.Name = "buttonEditColumn"
                LinkEditColumn.Text = "Edit"
                LinkEditColumn.UseColumnTextForLinkValue = True
                'position of the linkcolumn
                Employee_Grid.Columns.Insert(7, LinkEditColumn)
                'Creating and inserting link column for delete operation
                Dim LinkDeleteColumn As DataGridViewLinkColumn = New DataGridViewLinkColumn()
                LinkDeleteColumn.HeaderText = "Delete Action"
                LinkDeleteColumn.Name = "buttonDeleteColumn"
                LinkDeleteColumn.Text = "Delete"
                LinkDeleteColumn.MinimumWidth = 30
                LinkDeleteColumn.UseColumnTextForLinkValue = True
                'position of the linkcolumn
                Employee_Grid.Columns.Insert(8, LinkDeleteColumn)
            Else
                'nothing
            End If
        Catch ex As Exception
            'to check error
        End Try
    End Sub
    Public Sub Add_Employee_Click(sender As Object, e As EventArgs) Handles Add_Employee.Click
        'Passing empty data to open insert form otherwise you will get update form.
        Dim pass As String = ""
        Dim frm As New Employee_Form(pass)
        frm.ShowDialog()
        'Once you close the 2nd form Grid will be automatically reloads.
        Bind_Employee_Grid()
    End Sub
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'To show data in combo box
        Key_Date.Format = DateTimePickerFormat.Custom
        Key_Date.CustomFormat = "MM/dd/yyyy"
        load_combobox()
    End Sub

    Public Sub load_combobox()
        'Options for combo box
        Index.Items.Clear()
        Index.Items.Add("Employee_Number")
        Index.Items.Add("First_Name")
        Index.Items.Add("Last_Name")
        Index.Items.Add("Birth_Date")
        Index.Items.Add("Employee_Status")
        Index.Items.Add("Hired_Date")
        Index.Items.Add("Project")
        Page_Label()
        Key_Date.Visible = False
        Select_Status.Visible = False
    End Sub

    Public Sub Employee_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Employee_Grid.CellClick
        Try
            'checking selected cell's row
            Dim row As DataGridViewRow = Employee_Grid.Rows(e.RowIndex)
            'checking selected cell's column
            Dim column As DataGridViewColumn = Employee_Grid.Columns(e.ColumnIndex)
            'Dim employeeNumber As String = row.Cells(2).Value.ToString()
            If e.ColumnIndex = 0 Then
                '0th column/cell is the position of the edit link column
                Dim form As New Employee_Form(row.Cells(2).Value.ToString())
                'function to open 2nd form with edit option
                form.ShowDialog()
                Bind_Employee_Grid()
            End If
            If e.ColumnIndex = 1 Then
                '1 for delete which passes employeeNumber to delete function
                If MessageBox.Show(String.Format("Do you want to delete record for Employee Number: {0}", row.Cells(2).Value.ToString()), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    'Function for delete
                    Dim bool = Delete_Employee(row.Cells(2).Value.ToString())
                    Bind_Employee_Grid()
                    'Deleted success fully or not
                    If (bool) Then
                        MessageBox.Show("Deleted Successfully")
                    Else
                    End If
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub
    'Paggination Forword 10 data row at a time
    Public Sub Next_Page_Click(sender As Object, e As EventArgs) Handles Next_Page.Click
        If (Employee_Grid.RowCount() = 15) Then
            totalPage = Get_Forward_Pagination()
            Page_Label()
        ElseIf (Employee_Grid.RowCount() = 0) Then
            MessageBox.Show("Empty the record")
        Else
            MessageBox.Show("End of the record")
        End If
    End Sub
    'Paggination backword 10 data row at a time
    Public Sub Back_Page_Click(sender As Object, e As EventArgs) Handles Back_Page.Click
        Get_Backward_Pagination()
        Page_Label()
    End Sub

    'Refreshing employee gridview.
    Public Sub Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        Try
            'to refresh Grid view and all other items from the form.
            Index.Text = ""
            Keyword.Text = ""
            Keyword.Visible = True
            Key_Date.Visible = False
            Select_Status.Visible = False
            pagingDS = Get_PagingDS()
            Employee_Data()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub Index_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Index.TextChanged
        'Before selecting index field keyword text box must be read only.
        keywordValue = ""
        Keyword.Text = ""
        If (Index.Text = "") Then
            Keyword.ReadOnly = True
        Else
            'Swtching proper box for choosen option
            Select Case Index.Text
                Case "Employee_Number"
                    Keyword.Visible = True
                    Key_Date.Visible = False
                    Select_Status.Visible = False
                Case "First_Name"
                    Keyword.Visible = True
                    Key_Date.Visible = False
                    Select_Status.Visible = False
                Case "Last_Name"
                    Keyword.Visible = True
                    Key_Date.Visible = False
                    Select_Status.Visible = False
                Case "Birth_Date"
                    Keyword.Visible = False
                    Key_Date.Visible = True
                    Select_Status.Visible = False
                Case "Employee_Status"
                    Keyword.Visible = False
                    Key_Date.Visible = False
                    Select_Status.Visible = True
                Case "Hired_Date"
                    Keyword.Visible = False
                    Key_Date.Visible = True
                    Select_Status.Visible = False
                Case "Project"
                    Keyword.Visible = True
                    Key_Date.Visible = False
                    Select_Status.Visible = False
                Case Else
                    Index.Text = ""
                    Keyword.Visible = True
                    Key_Date.Visible = False
                    Select_Status.Visible = False
            End Select
            Keyword.ReadOnly = False
        End If
    End Sub
    'Search by text and validation.
    Public Sub Keyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Keyword.KeyPress
        If (Index.Text = "Employee_Number") Then
            If (Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar)) Then
                e.Handled = True
            End If
        ElseIf (Index.Text = "First_Name") Then
            If (Not Char.IsControl(e.KeyChar) And Not Char.IsLetter(e.KeyChar)) Then
                e.Handled = True
            End If
        ElseIf (Index.Text = "Last_Name") Then
            If (Not Char.IsControl(e.KeyChar) And Not Char.IsLetter(e.KeyChar)) Then
                e.Handled = True
            End If
        ElseIf (Index.Text = "Project") Then
            If (Not Char.IsControl(e.KeyChar) And Not Char.IsLetter(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar)) Then
                e.Handled = True
                If (Keyword.Text = "" And Char.IsWhiteSpace(e.KeyChar)) Then
                    e.Handled = True
                End If
            End If
        Else
            Keyword.Text = ""
        End If
    End Sub
    Private Sub Keyword_TextChanged(sender As Object, e As EventArgs) Handles Keyword.TextChanged
        Serach(Keyword.Text)
    End Sub
    'Search by date
    Private Sub Key_Date_ValueChanged(sender As Object, e As EventArgs) Handles Key_Date.ValueChanged
        If (Index.Text = "Birth_Date") Then
            Key_Date.MaxDate = Date.Today.AddYears(-10)
            Key_Date.MinDate = Date.Today.AddYears(-50)
        ElseIf (Index.Text = "Hired_Date") Then
            Key_Date.MaxDate = Date.Today()
        Else
        End If
        Serach(Key_Date.Text)
    End Sub
    'search by selecting index active or inactive
    Private Sub Select_Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_Status.SelectedIndexChanged
        If (Select_Status.Text = "Active") Then
            keywordValue = 1
            Serach(keywordValue)
        ElseIf (Select_Status.Text = "Inactive") Then
            keywordValue = 0
            Serach(keywordValue)
        Else
            Select_Status.Text = "Active"
            keywordValue = 1
        End If
    End Sub
    Public Sub Serach(ByVal keywordValue As String)
        Try
            If (String.IsNullOrEmpty(Index.Text)) Then
                'First select index options from combo box(must not empty)
                keywordValue = ""
            Else
                If (String.IsNullOrEmpty(keywordValue)) Then
                    'keyword is empty then show all record
                    pagingDS = Get_PagingDS()
                    Employee_Data()
                Else
                    'from Employees table column is index and value must match keyword to serach similar records
                    pagingDS = Get_PagingDS(Index.Text, keywordValue)
                    Employee_Data()

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    'Dispaying records count and displayed records in label
    Private Sub Page_Label()
        pTotal = 0
        'already displayed record as pTotal and total record as rowCount
        pTotal = Employee_Grid.Rows.Count + scrollVal
        Label_For_Page.Text = pTotal & " out of " & rowCount
    End Sub
End Class
