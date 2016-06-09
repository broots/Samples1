<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<script type="text/javascript">
    google.load("visualization", "1", { packages: ["corechart"] });
    google.setOnLoadCallback(drawVisitorChart);
    function drawVisitorChart() {
        var data = new google.visualization.DataTable();
        data.addColumn('string', 'Year');
        data.addColumn('number', 'New Visitors');
        data.addColumn('number', 'Return Visitors');
        data.addRows([
          ['Monday', 1000, 400],
          ['Tuesday', 1170, 460],
          ['Wednesday', 860, 580],
          ['Thursday', 1030, 540]
        ]);

        var options = {
            title: 'Site Visitors'
        };

        var chart = new google.visualization.LineChart(document.getElementById('chartVisitors'));
        chart.draw(data, options);
    }
</script>
<div class="dashboardItem">
    <div class="dashboardItemHeader">Site Visitors</div>
    <div class="dashboardItemBody">
         <div id="chartVisitors" style=""></div>
    </div>
</div>