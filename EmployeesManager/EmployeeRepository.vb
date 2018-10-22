Imports System.Data.SqlClient

Module EmployeeRepository

    Sub SaveChanges(ByVal empViewModel As EmployeeViewModel)
        Dim connectionString = My.Settings.EmployeesDatabaseConnectionString
        Dim conn = New SqlConnection(connectionString)
        conn.Open()
        Try
            Dim updateCmd = New SqlCommand("dbo.uspEmployeeUpdate", conn)
            With updateCmd
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .AddWithValue("@Id", empViewModel.Id)
                    .AddWithValue("@Name", empViewModel.Name)
                    .AddWithValue("@Title", empViewModel.Title)
                    .AddWithValue("@Manager", empViewModel.Manager)
                    .AddWithValue("@HireDate", empViewModel.HireDate)
                    .AddWithValue("@Salary", empViewModel.Salary)
                    .AddWithValue("@DepartmentId", empViewModel.DepartmentId)
                End With ' Parameters
                .ExecuteNonQuery()
            End With ' updateCmd
        Finally
            conn.Close()
        End Try
    End Sub

End Module
