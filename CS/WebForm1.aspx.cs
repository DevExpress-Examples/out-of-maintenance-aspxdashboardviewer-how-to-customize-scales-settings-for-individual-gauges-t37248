using System;
using NewProject;
using System.Linq;
using System.Collections.Generic;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void ASPxDashboardViewer1_DataLoading(object sender, DevExpress.DashboardWeb.DataLoadingWebEventArgs e)
        {
            List<MyDataClass> list = CreateDataSource();
            e.Data = list;
        }

        private static List<MyDataClass> CreateDataSource()
        {
            List<MyDataClass> list = new List<MyDataClass>(10);
            Random _r = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new MyDataClass() { ID = i, Name = "Name1", Sales = (float)_r.NextDouble(), Date = DateTime.Now.AddDays(i) });
                list.Add(new MyDataClass() { ID = i, Name = "Name2", Sales = 10 * (float)_r.NextDouble(), Date = DateTime.Now.AddDays(i) });
                list.Add(new MyDataClass() { ID = i, Name = "Name3", Sales = 100 * (float)_r.NextDouble(), Date = DateTime.Now.AddDays(i) });
                list.Add(new MyDataClass() { ID = i, Name = "Name4", Sales = 1000 * (float)_r.NextDouble(), Date = DateTime.Now.AddDays(i) });
            }
            return list;
        }
    }
}