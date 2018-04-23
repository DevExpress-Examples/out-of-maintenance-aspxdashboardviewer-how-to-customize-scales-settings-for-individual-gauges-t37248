Imports System
Imports NewProject
Imports System.Linq
Imports System.Collections.Generic

Namespace WebApplication1
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub ASPxDashboardViewer1_DataLoading(ByVal sender As Object, ByVal e As DevExpress.DashboardWeb.DataLoadingWebEventArgs)
            Dim list As List(Of MyDataClass) = CreateDataSource()
            e.Data = list
        End Sub

        Private Shared Function CreateDataSource() As List(Of MyDataClass)
            Dim list As New List(Of MyDataClass)(10)
            Dim _r As New Random()
            For i As Integer = 0 To 9
                list.Add(New MyDataClass() With {.ID = i, .Name = "Name1", .Sales = CSng(_r.NextDouble()), .Date = Date.Now.AddDays(i)})
                list.Add(New MyDataClass() With {.ID = i, .Name = "Name2", .Sales = 10 * CSng(_r.NextDouble()), .Date = Date.Now.AddDays(i)})
                list.Add(New MyDataClass() With {.ID = i, .Name = "Name3", .Sales = 100 * CSng(_r.NextDouble()), .Date = Date.Now.AddDays(i)})
                list.Add(New MyDataClass() With {.ID = i, .Name = "Name4", .Sales = 1000 * CSng(_r.NextDouble()), .Date = Date.Now.AddDays(i)})
            Next i
            Return list
        End Function
    End Class
End Namespace