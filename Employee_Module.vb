Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Net
Imports System.Configuration

Module Employee_Module
    'Variable lists
    'Database connection
    Public connectionString As String = "Persist Security Info=True;initial Catalog=" & My.Settings.gStrDatabase_Name & ";User ID=" & My.Settings.gStrUSER & ";Password=" & My.Settings.gStrPW & ";Data Source=" & My.Settings.gStrDatabase_Server
    Public connection As New SqlConnection(connectionString)
    'variable to pass values to search
    Public keywordValue As String
    Public KeyDateValue As DateTime
    'employee id
    Public empid As String = ""
    'acceptable strings
    Public employeeStatus As String
    Public singleEmployee As String = ""
    'global selection string
    Public gSelection As New StringBuilder
    Public projectTitlePattern As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ."
    'pagination
    Public pTotal As Integer
    Public totalPage As Integer
    Public rowCount As Integer = 0
    'To create gridview
    Public pagingAdapter As SqlDataAdapter
    Public pagingDS As DataSet = New DataSet()
    Public scrollVal As Integer
    Public employeeTable As New Data.DataTable
    Public employeeRow As Data.DataRow

    'connection string
    Public Function Get_ConnectionString()
        Return connectionString
    End Function
    'Query list
    'load all records
    Public Function Get_PagingDS()
        pagingDS.Clear()
        gSelection.Clear()
        gSelection.Append(" SELECT ")
        gSelection.Append(" CAST([Employee_Number] As INT) AS [Employee Number], ")
        gSelection.Append(" [First_Name] AS [First Name], ")
        gSelection.Append(" [Last_Name] AS [Last Name], ")
        gSelection.Append("  CONVERT(VARCHAR,[Birth_Date],101) AS [Birth Date], ")
        gSelection.Append(" [Employee_Status] AS [Employee Status], ")
        gSelection.Append("  CONVERT(VARCHAR,[Hired_Date],101) AS [Hired Date], ")
        gSelection.Append(" [Project] AS [Project] ")
        gSelection.Append(" FROM ")
        gSelection.Append(" dbo.[Employees] WITH (NOLOCK) ")
        gSelection.Append(" ORDER BY  CAST(Employee_Number AS INT) ASC ")
        Return Run_Select_Query(gSelection.ToString())
    End Function
    'search record
    Public Function Get_PagingDS(ByVal Index As String, ByVal Keyword As String)
        scrollVal = 0
        pagingDS.Clear()
        If (Index = "Birth_Date" Or Index = "Hired_Date") Then
            gSelection.Clear()
            gSelection.Append(" SELECT ")
            gSelection.Append(" CAST([Employee_Number] As INT) AS [Employee Number], ")
            gSelection.Append(" [First_Name] AS [First Name], ")
            gSelection.Append(" [Last_Name] AS [Last Name], ")
            gSelection.Append("  CONVERT(VARCHAR,[Birth_Date],101) AS [Birth Date], ")
            gSelection.Append(" [Employee_Status] AS [Employee Status], ")
            gSelection.Append("  CONVERT(VARCHAR,[Hired_Date],101) AS [Hired Date], ")
            gSelection.Append(" [Project] AS [Project] ")
            gSelection.Append(" FROM ")
            gSelection.Append(" dbo.[Employees] WITH (NOLOCK) ")
            gSelection.Append(" WHERE CONVERT(VARCHAR,[").Append(Index).Append("],101) ")
            gSelection.Append("like CONVERT(VARCHAR,'%").Append(Keyword).Append("%',101) ")
            gSelection.Append(" ORDER BY  CAST([Employee_Number] AS INT) ASC ")
            Return Run_Select_Query(gSelection.ToString())
        Else
            gSelection.Clear()
            gSelection.Append(" SELECT ")
            gSelection.Append(" CAST([Employee_Number] As INT) AS [Employee Number], ")
            gSelection.Append(" [First_Name] AS [First Name], ")
            gSelection.Append(" [Last_Name] AS [Last Name], ")
            gSelection.Append(" CONVERT(VARCHAR,[Birth_Date],101) AS [Birth Date], ")
            gSelection.Append(" [Employee_Status] AS [Employee Status], ")
            gSelection.Append(" CONVERT(VARCHAR,[Hired_Date],101) AS [Hired Date], ")
            gSelection.Append(" [Project] AS [Project] ")
            gSelection.Append(" FROM ")
            gSelection.Append(" dbo.[Employees] WITH (NOLOCK) ")
            gSelection.Append(" WHERE [").Append(Index).Append("] ")
            gSelection.Append(" Like '").Append(Keyword).Append("%' ")
            gSelection.Append(" ORDER BY  CAST([Employee_Number] AS INT) ASC ")
            Return Run_Select_Query(gSelection.ToString())
        End If
    End Function
    'delete single record
    Public Function Delete_Employee(ByVal employeeNumber As String)
        gSelection.Clear()
        gSelection.Append(" DELETE ")
        gSelection.Append(" FROM ")
        gSelection.Append(" dbo.[Employees] ")
        gSelection.Append(" WHERE ")
        gSelection.Append(" [Employee_Number] = '").Append(employeeNumber).Append("' ")
        Return Run_Query(gSelection.ToString)
    End Function
    'delete single record
    Public Function Employee_Count(ByVal employeeNumber As String)
        gSelection.Clear()
        gSelection.Append(" SELECT ")
        gSelection.Append(" COUNT(*) AS COUNT ")
        gSelection.Append(" FROM ")
        gSelection.Append(" dbo.[Employees] ")
        gSelection.Append(" WHERE ")
        gSelection.Append(" [Employee_Number] = '").Append(employeeNumber).Append("' ")
        Return Get_Row_Count(gSelection.ToString)
    End Function
    'single record retriew
    Public Function Single_Employee_Select(ByVal employeeNumber As String)
        gSelection.Clear()
        gSelection.Append(" SELECT ")
        gSelection.Append(" [Employee_Number], ")
        gSelection.Append(" [First_Name], ")
        gSelection.Append(" [Last_Name], ")
        gSelection.Append(" CONVERT(VARCHAR(10),[Birth_Date],101) AS Birth_Date, ")
        gSelection.Append(" [Employee_Status], ")
        gSelection.Append(" CONVERT(VARCHAR(10),[Hired_Date],101) AS Hired_Date, ")
        gSelection.Append(" [Project] ")
        gSelection.Append(" FROM ")
        gSelection.Append(" dbo.[Employees] ")
        gSelection.Append(" WHERE ")
        gSelection.Append(" [Employee_Number] = '").Append(employeeNumber).Append("' ")
        Return gSelection.ToString()
    End Function
    'insert record
    Public Function Add_Employee(ByVal employeeNumber As String, ByVal firstName As String, ByVal lastName As String, ByVal employeeStatus As String, ByVal birthDate As String, ByVal hiredDate As String, ByVal project As String)
        gSelection.Clear()
        gSelection.Append(" INSERT ")
        gSelection.Append(" INTO ")
        gSelection.Append(" dbo.[Employees] (")
        gSelection.Append(" [Employee_Number], ")
        gSelection.Append(" [First_Name], ")
        gSelection.Append(" [Last_Name], ")
        gSelection.Append(" [Birth_Date], ")
        gSelection.Append(" [Employee_Status], ")
        gSelection.Append(" [Hired_Date], ")
        gSelection.Append(" [Project]) ")
        gSelection.Append(" VALUES(")
        gSelection.Append(" '").Append(employeeNumber).Append("', ")
        gSelection.Append(" '").Append(firstName).Append("', ")
        gSelection.Append(" '").Append(lastName).Append("', ")
        gSelection.Append("  CONVERT(VARCHAR(10),'").Append(birthDate).Append("',101), ")
        gSelection.Append(" '").Append(employeeStatus).Append("', ")
        gSelection.Append("  CONVERT(VARCHAR(10),'").Append(hiredDate).Append("',101), ")
        gSelection.Append(" '").Append(project).Append("') ")
        Return Run_Query(gSelection.ToString)
    End Function
    'update record
    Public Function Update_Employee(ByVal employeeNumber As String, ByVal firstName As String, ByVal lastName As String, ByVal employeeStatus As String, ByVal birthDate As String, ByVal hiredDate As String, ByVal project As String)
        gSelection.Clear()
        gSelection.Append(" UPDATE ")
        gSelection.Append(" dbo.[Employees] ")
        gSelection.Append(" SET ")
        gSelection.Append(" [First_Name] = '").Append(firstName).Append("', ")
        gSelection.Append(" [Last_Name] = '").Append(lastName).Append("', ")
        gSelection.Append(" [Birth_Date] = CONVERT(VARCHAR(10),'").Append(birthDate).Append("',101), ")
        gSelection.Append(" [Employee_Status] = '").Append(employeeStatus).Append("', ")
        gSelection.Append(" [Hired_Date] = CONVERT(VARCHAR(10),'").Append(hiredDate).Append("',101), ")
        gSelection.Append(" [Project] = '").Append(project).Append("' ")
        gSelection.Append(" WHERE ")
        gSelection.Append(" [Employee_Number] = '").Append(employeeNumber).Append("' ")
        Return Run_Query(gSelection.ToString)
    End Function
    'Executing query list
    'Run the query to retrieve data by passingquery
    Public Function Run_Select_Query(ByVal sqlQuery As String)
        employeeTable.Clear()
        pagingDS.Clear()
        scrollVal = 0
        Try
            pagingAdapter = New SqlDataAdapter(sqlQuery, connection)
            connection.Open()
            pagingAdapter.Fill(pagingDS, scrollVal, 15, "Employees")
            pagingAdapter.Fill(employeeTable)
            Connection_Close()
            rowCount = employeeTable.Rows.Count
            Return pagingDS
        Catch ex As Exception
            Connection_Close()
            Return "Fail"
        End Try
    End Function
    'just to run query and get boolean value
    Public Function Run_Query(ByVal sqlQuery As String)
        Try
            Dim runCommand As New SqlCommand(sqlQuery, connection)
            runCommand.CommandType = CommandType.Text
            runCommand.Connection = connection
            connection.Open()
            runCommand.ExecuteNonQuery()
            Connection_Close()
            Return True
        Catch ex As Exception
            Connection_Close()
            Return False
        End Try
    End Function
    'To retriev all counts, sum or average
    Public Function Get_Row_Count(ByVal sqlQuery As String)
        Dim SqlCommand As New SqlCommand(sqlQuery, connection)
        connection.Open()
        Dim employeeDataReader As SqlDataReader
        employeeDataReader = SqlCommand.ExecuteReader()
        employeeDataReader.Read()
        Dim employeeRowData As String = employeeDataReader.Item(0).ToString()
        employeeDataReader.Close()
        SqlCommand.Dispose()
        connection.Close()
        Return employeeRowData
    End Function
    'Pagination related
    'forword pagination
    Public Function Get_Forward_Pagination()
        pagingDS.Clear()
        'Display records limit
        If scrollVal <= rowCount - 15 Then
            'go to next page
            scrollVal = scrollVal + 15
        Else
            MessageBox.Show("End of the record")
        End If
        'Display 15 records
        pagingAdapter.Fill(pagingDS, scrollVal, 15, "Employees")
        rowCount = employeeTable.Rows.Count
        Return scrollVal
    End Function
    'backword pagination
    Public Function Get_Backward_Pagination()
        pagingDS.Clear()
        If scrollVal <= 0 Then
            'first page then stop
            scrollVal = 0
        Else
            'go to back page
            scrollVal = scrollVal - 15
        End If
        'Display 15 records
        pagingAdapter.Fill(pagingDS, scrollVal, 15, "Employees")
        Return scrollVal
    End Function
    'form related task
    'retriew single record among table
    Public Function Get_Single_Employee(ByRef employeeNumber As String)
        Try
            Dim slQuery = Single_Employee_Select(employeeNumber)
            Dim sqlCommand As New SqlCommand(slQuery, connection)
            connection.Open()
            Dim employeeDataReader As SqlDataReader = sqlCommand.ExecuteReader()
            employeeDataReader.Read()
            Dim employeeRowData As String = employeeDataReader("Employee_Number").ToString() + "-" + employeeDataReader("First_Name").ToString() + "-" + employeeDataReader("Last_Name").ToString() + "-" + employeeDataReader("Employee_Status").ToString() + "-" + employeeDataReader("Birth_Date").ToString() + "-" + employeeDataReader("Hired_Date").ToString() + "-" + employeeDataReader("Project").ToString()
            employeeDataReader.Close()
            sqlCommand.Dispose()
            connection.Close()
            Return employeeRowData
        Catch ex As Exception
            connection.Close()
            Return employeeNumber
        End Try
    End Function
    Public Sub Connection_Close()
        connection.Close()
    End Sub
End Module
