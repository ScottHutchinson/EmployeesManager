Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Diagnostics.CodeAnalysis
Imports System.Data.Entity

Public Class ObservableListSource(Of T As Class)
    Inherits ObservableCollection(Of T)
    Implements IListSource

    Private _bindingList As IBindingList

    Private ReadOnly Property IListSource_ContainsListCollection() As Boolean Implements IListSource.ContainsListCollection
        Get
            Return False
        End Get
    End Property

    Private Function IListSource_GetList() As IList Implements IListSource.GetList
        If _bindingList Is Nothing Then
            _bindingList = Me.ToBindingList()
        End If
        Return _bindingList
    End Function
End Class
