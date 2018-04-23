Namespace WebApplication1
    Partial Public Class Dashboard1
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim measure1 As New DevExpress.DashboardCommon.Measure()
            Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
            Dim gauge1 As New DevExpress.DashboardCommon.Gauge()
            Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.dashboardObjectDataSource1 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
            Me.gaugeDashboardItem1 = New DevExpress.DashboardCommon.GaugeDashboardItem()
            DirectCast(Me.dashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gaugeDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' dashboardObjectDataSource1
            ' 
            Me.dashboardObjectDataSource1.ComponentName = "dashboardObjectDataSource1"
            Me.dashboardObjectDataSource1.DataSource = GetType(NewProject.MyDataClass)
            Me.dashboardObjectDataSource1.Name = "Object Data Source 1"
            ' 
            ' gaugeDashboardItem1
            ' 
            Me.gaugeDashboardItem1.ComponentName = "gaugeDashboardItem1"
            measure1.DataMember = "Sales"
            dimension1.DataMember = "Name"
            Me.gaugeDashboardItem1.DataItemRepository.Clear()
            Me.gaugeDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
            Me.gaugeDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
            Me.gaugeDashboardItem1.DataSource = Me.dashboardObjectDataSource1
            gauge1.AddDataItem("ActualValue", measure1)
            Me.gaugeDashboardItem1.Gauges.AddRange(New DevExpress.DashboardCommon.Gauge() { gauge1})
            Me.gaugeDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.gaugeDashboardItem1.Name = "Gauges 1"
            Me.gaugeDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
            Me.gaugeDashboardItem1.ShowCaption = True
            Me.gaugeDashboardItem1.ShowGaugeCaptions = False
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardObjectDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.gaugeDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.gaugeDashboardItem1
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1})
            dashboardLayoutGroup1.DashboardItem = Nothing
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            DirectCast(Me.dashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gaugeDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region
        Private dashboardObjectDataSource1 As DevExpress.DashboardCommon.DashboardObjectDataSource
        Private gaugeDashboardItem1 As DevExpress.DashboardCommon.GaugeDashboardItem
    End Class
End Namespace
