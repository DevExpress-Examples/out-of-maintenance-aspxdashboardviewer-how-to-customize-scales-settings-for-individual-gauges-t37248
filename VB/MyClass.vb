Imports System
Imports System.Linq
Imports System.Collections.Generic

Namespace NewProject
    Public Class MyDataClass
        Public Sub New()

        End Sub
        ' Fields...
        Private _Date As Date
        Private _Sales As Single
        Private _ID As Integer
        Private _Name As String
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                _Name = value
            End Set
        End Property
        Public Property Sales() As Single
            Get
                Return _Sales
            End Get
            Set(ByVal value As Single)
                _Sales = value
            End Set
        End Property
        Public Property [Date]() As Date
            Get
                Return _Date
            End Get
            Set(ByVal value As Date)
                _Date = value
            End Set
        End Property
    End Class
End Namespace
