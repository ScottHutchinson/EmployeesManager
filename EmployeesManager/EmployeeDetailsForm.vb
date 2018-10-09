Imports System.ComponentModel

Public Class EmployeeDetailsForm

    Private WithEvents _empViewModel As EmployeeViewModel

    Public Sub New(ByRef empViewModel As EmployeeViewModel)
        ' This call is required by the designer.
        InitializeComponent()
        _empViewModel = empViewModel
        EmployeesBindingSource.DataSource = _empViewModel
        _empViewModel.BeginEdit()
        Me.OkButton.Enabled = False
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        _empViewModel.SaveChanges = True
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        _empViewModel.CancelEdit()
    End Sub

    Private Sub OnPropertyChanged(sender As Object, e As PropertyChangedEventArgs) Handles _empViewModel.PropertyChanged
        Me.OkButton.Enabled = True
    End Sub

End Class
