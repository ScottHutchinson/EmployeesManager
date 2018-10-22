Imports System.ComponentModel
Imports System.Data.Entity

Partial Public Class EmployeesForm
    Inherits Form

    Private _context As EmployeesDatabaseEntities
    Private WithEvents _empViewModel As EmployeeViewModel

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        _context = New EmployeesDatabaseEntities()
        _context.Departments.Load()
        Me.DepartmentBindingSource.DataSource = _context.Departments.Local.ToBindingList()
        With DepartmentDataGridView
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End With
        With EmployeesDataGridView
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End With
        'Me.DepartmentBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub SaveChanges()
        Me.Validate()

        For Each employee In _context.Employees.Local.ToList()
            If employee.Department Is Nothing Then
                _context.Employees.Remove(employee)
            End If
        Next

        'Me._context.SaveChanges()
        ' This is just practice using ADO.NET without Entity Framework.
        _empViewModel.Update()
        Me.DepartmentDataGridView.Refresh()
        Me.EmployeesDataGridView.Refresh()
        _empViewModel.EndEdit()
        'Me.DepartmentBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub DepartmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DepartmentBindingNavigatorSaveItem.Click
        Me.SaveChanges()
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
        MyBase.OnClosing(e)
        Me._context.Dispose()
    End Sub

    Private Sub OnCellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeesDataGridView.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim employee As Employee = DirectCast(EmployeesDataGridView.Rows(e.RowIndex).DataBoundItem, Employee)
            If employee IsNot Nothing Then
                _empViewModel = New EmployeeViewModel(employee)
                Dim empDetailsForm As New EmployeeDetailsForm(_empViewModel)
                empDetailsForm.ShowDialog(Me)
                If _empViewModel.SaveChanges Then
                    Me.SaveChanges()
                End If
            End If
        End If
    End Sub

End Class
