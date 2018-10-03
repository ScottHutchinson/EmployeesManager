Public Class EmployeeDetailsForm

    Private _empViewModel As EmployeeViewModel

    Public Sub New(ByRef empViewModel As EmployeeViewModel)
        ' This call is required by the designer.
        InitializeComponent()
        _empViewModel = empViewModel
        EmployeesBindingSource.DataSource = _empViewModel
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        _empViewModel.SaveChanges = True
    End Sub

End Class
