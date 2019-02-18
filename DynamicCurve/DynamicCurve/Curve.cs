using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DynamicCurve.DynamicCurve
{
    public partial class Curve : UserControl
    {
        public Curve()
        {
            CreateChart();
            createSeries();
            InitializeComponent();
        }

        private void CreateChart()
        {
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "FirstArea";

            chartArea.CursorX.IsUserEnabled = true;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.CursorX.SelectionColor = Color.SkyBlue;
            chartArea.CursorY.IsUserEnabled = true;
            chartArea.CursorY.AutoScroll = true;
            chartArea.CursorY.IsUserSelectionEnabled = true;
            chartArea.CursorY.SelectionColor = Color.SkyBlue;

            chartArea.CursorX.IntervalType = DateTimeIntervalType.Auto;
            chartArea.AxisX.ScaleView.Zoomable = false;
            chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;//启用X轴滚动条按钮

            chartArea.BackColor = Color.AliceBlue;                      //背景色
            chartArea.BackSecondaryColor = Color.White;                 //渐变背景色
            chartArea.BackGradientStyle = GradientStyle.TopBottom;      //渐变方式
            chartArea.BackHatchStyle = ChartHatchStyle.None;            //背景阴影
            chartArea.BorderDashStyle = ChartDashStyle.NotSet;          //边框线样式
            chartArea.BorderWidth = 1;                                  //边框宽度
            chartArea.BorderColor = Color.Black;


            chartArea.AxisX.MajorGrid.Enabled = true;
            chartArea.AxisY.MajorGrid.Enabled = true;

            // Axis
            chartArea.AxisY.Title = @"Value";
            chartArea.AxisY.LabelAutoFitMinFontSize = 5;
            chartArea.AxisY.LineWidth = 2;
            chartArea.AxisY.LineColor = Color.Black;
            chartArea.AxisY.Enabled = AxisEnabled.True;

            chartArea.AxisX.Title = @"Time";
            chartArea.AxisX.IsLabelAutoFit = true;
            chartArea.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea.AxisX.LabelStyle.Angle = -15;


            chartArea.AxisX.LabelStyle.IsEndLabelVisible = true;        //show the last label
            chartArea.AxisX.Interval = 10;
            chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            chartArea.AxisX.IntervalType = DateTimeIntervalType.NotSet;
            chartArea.AxisX.TextOrientation = TextOrientation.Auto;
            chartArea.AxisX.LineWidth = 2;
            chartArea.AxisX.LineColor = Color.Black;
            chartArea.AxisX.Enabled = AxisEnabled.True;
            chartArea.AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Months;
            chartArea.AxisX.Crossing = 0;

            chartArea.Position.Height = 85;
            chartArea.Position.Width = 85;
            chartArea.Position.X = 5;
            chartArea.Position.Y = 7;

            this.chart.ChartAreas.Add(chartArea);
            chart.BackGradientStyle = GradientStyle.TopBottom;
            //图表的边框颜色、
            chart.BorderlineColor = Color.FromArgb(26, 59, 105);
            //图表的边框线条样式
            chart.BorderlineDashStyle = ChartDashStyle.Solid;
            //图表边框线条的宽度
            chart.BorderlineWidth = 2;
            //图表边框的皮肤
            chart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

        }

        private void createSeries()
        {
            //Series1
            var series1 = new Series();
            series1.ChartArea = "FirstArea";
            chart.Series.Add(series1);

            //Series1 style
            series1.ToolTip = "#VALX,#VALY";    //鼠标停留在数据点上，显示XY值

            series1.Name = "series1";
            series1.ChartType = SeriesChartType.Spline;  // type
            series1.BorderWidth = 2;
            series1.Color = Color.Red;
            series1.XValueType = ChartValueType.Time;//x axis type
            series1.YValueType = ChartValueType.Int32;//y axis type

            //Marker
            series1.MarkerStyle = MarkerStyle.Square;
            series1.MarkerSize = 5;
            series1.MarkerColor = Color.Black;

            this.chart.Legends.Clear();

        }
    }
}
