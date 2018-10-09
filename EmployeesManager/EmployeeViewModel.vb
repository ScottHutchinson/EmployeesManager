Imports System.ComponentModel
Imports System.Reflection
Imports System.Runtime.CompilerServices

Public Class EmployeeViewModel
    Implements INotifyPropertyChanged
    Implements IEditableObject

    Private _Model As Employee
    Dim _ModelProperties As PropertyInfo()
    Private _Copy As Hashtable

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
            Me.NotifyPropertyChanged()
        End Set
    End Property

    Public Property Title As String
        Get
            Return _Model.Title
        End Get
        Set(value As String)
            _Model.Title = value
            Me.NotifyPropertyChanged()
        End Set
    End Property

    Public Property Manager As Integer?
        Get
            Return _Model.Manager
        End Get
        Set(value As Integer?)
            _Model.Manager = value
            Me.NotifyPropertyChanged()
        End Set
    End Property

    Public Property HireDate As Date?
        Get
            Return _Model.HireDate
        End Get
        Set(value As Date?)
            _Model.HireDate = value
            Me.NotifyPropertyChanged()
        End Set
    End Property

    Public Property Salary As Decimal?
        Get
            Return _Model.Salary
        End Get
        Set(value As Decimal?)
            _Model.Salary = value
            Me.NotifyPropertyChanged()
        End Set
    End Property

    Public Property DepartmentId As Integer?
        Get
            Return _Model.DepartmentId
        End Get
        Set(value As Integer?)
            _Model.DepartmentId = value
            Me.NotifyPropertyChanged()
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(<CallerMemberName> Optional ByVal propertyName As String = "")
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Public Sub BeginEdit() Implements IEditableObject.BeginEdit
        _ModelProperties = _Model.GetType().GetProperties(Reflection.BindingFlags.Public Or Reflection.BindingFlags.Instance)
        _Copy = New Hashtable(_ModelProperties.Length - 1)
        For Each prop In _ModelProperties
            If prop.GetSetMethod() IsNot Nothing Then
                Dim val = prop.GetValue(_Model)
                _Copy.Add(prop.Name, val)
            End If
        Next
    End Sub

    Public Sub EndEdit() Implements IEditableObject.EndEdit
        _Copy = Nothing
    End Sub

    Public Sub CancelEdit() Implements IEditableObject.CancelEdit
        If _Copy Is Nothing Then Return
        For Each prop In _ModelProperties
            If prop.GetSetMethod() IsNot Nothing Then
                Dim val = _Copy(prop.Name)
                prop.SetValue(_Model, val)
            End If
        Next
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
