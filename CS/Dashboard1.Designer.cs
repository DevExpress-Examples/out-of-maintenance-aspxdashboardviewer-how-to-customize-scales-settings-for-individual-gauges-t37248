namespace WebApplication1
{
    partial class Dashboard1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Gauge gauge1 = new DevExpress.DashboardCommon.Gauge();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.dashboardObjectDataSource1 = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.gaugeDashboardItem1 = new DevExpress.DashboardCommon.GaugeDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardObjectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // dashboardObjectDataSource1
            // 
            this.dashboardObjectDataSource1.ComponentName = "dashboardObjectDataSource1";
            this.dashboardObjectDataSource1.DataSource = typeof(NewProject.MyDataClass);
            this.dashboardObjectDataSource1.Name = "Object Data Source 1";
            // 
            // gaugeDashboardItem1
            // 
            this.gaugeDashboardItem1.ComponentName = "gaugeDashboardItem1";
            measure1.DataMember = "Sales";
            dimension1.DataMember = "Name";
            this.gaugeDashboardItem1.DataItemRepository.Clear();
            this.gaugeDashboardItem1.DataItemRepository.Add(measure1, "DataItem1");
            this.gaugeDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.gaugeDashboardItem1.DataSource = this.dashboardObjectDataSource1;
            gauge1.AddDataItem("ActualValue", measure1);
            this.gaugeDashboardItem1.Gauges.AddRange(new DevExpress.DashboardCommon.Gauge[] {
            gauge1});
            this.gaugeDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.gaugeDashboardItem1.Name = "Gauges 1";
            this.gaugeDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.gaugeDashboardItem1.ShowCaption = true;
            this.gaugeDashboardItem1.ShowGaugeCaptions = false;
            // 
            // Dashboard1
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardObjectDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.gaugeDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.gaugeDashboardItem1;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dashboardObjectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion
        private DevExpress.DashboardCommon.DashboardObjectDataSource dashboardObjectDataSource1;
        private DevExpress.DashboardCommon.GaugeDashboardItem gaugeDashboardItem1;
    }
}
