Imports System.ComponentModel
Public Class Classcollection



    Inherits BindingList(Of ClientesClass)
    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New ClientesClass()
    End Sub
End Class

