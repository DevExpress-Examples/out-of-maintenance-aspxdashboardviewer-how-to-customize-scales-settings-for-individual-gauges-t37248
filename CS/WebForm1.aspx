<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<%@ Register Assembly="DevExpress.Dashboard.v15.2.Web, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function OnItemWidgetCreated(s, e) {
            if (e.ItemName === "gaugeDashboardItem1") {
                var gauges = e.GetWidget();
                for (var i = 0; i < gauges.length; i++) {
                    var roundValue = Math.round(gauges[i].option("value"));
                    var requideNumberOfDigits = roundValue.toString().length;
                    var endValue = Math.pow(10, requideNumberOfDigits);
                    var tickInterval = endValue / 10;

                    gauges[i].option("scale", {
                        startValue: 0,
                        endValue: endValue,
                        majorTick: {
                            tickInterval: tickInterval
                        }
                    });
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxDashboardViewer ClientInstanceName="viewer" ID="ASPxDashboardViewer1" runat="server" DashboardSource="WebApplication1.Dashboard1" Height="600px" OnDataLoading="ASPxDashboardViewer1_DataLoading" Width="800px">
            <ClientSideEvents ItemWidgetCreated="OnItemWidgetCreated" />
        </dx:ASPxDashboardViewer>
    </div>
    </form>
</body>
</html>
