Imports System.ComponentModel

Public Class EmployeeViewModel
    Implements INotifyPropertyChanged

    Private _Model As Employee
    Private _SaveChanges As Boolean

    Public Sub New(ByRef employee As Employee)
        _Model = employee
        _SaveChanges = False
    End Sub

    Public ReadOnly Property Id As Integer
        Get
            Return _Model.Id
        End Get
    End Property

    Public Property Name As String
        Get
            Return _Model.Name
        End Get
        Set(value As String)
            _Model.Name = value
            Me.NotifyPropertyChanged("Name")
        End Set
    End Property

    Public Property Title As String
        Get
            Return _Model.Title
        End Get
        Set(value As String)
            _Model.Title = value
            Me.NotifyPropertyChanged("Title")
        End Set
    End Property

    Public Property Manager As Integer?
        Get
            Return _Model.Manager
        End Get
        Set(value As Integer?)
            _Model.Manager = value
            Me.NotifyPropertyChanged("Manager")
        End Set
    End Property

    Public Property HireDate As Date?
        Get
            Return _Model.HireDate
        End Get
        Set(value As Date?)
            _Model.HireDate = value
            Me.NotifyPropertyChanged("HireDate")
        End Set
    End Property

    Public Property Salary As Decimal?
        Get
            Return _Model.Salary
        End Get
        Set(value As Decimal?)
            _Model.Salary = value
            Me.NotifyPropertyChanged("Salary")
        End Set
    End Property

    Public Property DepartmentId As Integer?
        Get
            Return _Model.DepartmentId
        End Get
        Set(value As Integer?)
            _Model.DepartmentId = value
            Me.NotifyPropertyChanged("DepartmentId")
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(ByVal info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
    End Sub

    Public Property SaveChanges As Boolean
        Get
            Return _SaveChanges
        End Get
        Set(value As Boolean)
            _SaveChanges = value
        End Set
    End Property

End Class
