using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ZedGraph;
using PCComm;
namespace PCComm
{
    public partial class frmMain : Form
    {
        // Starting time in milliseconds
        int tickStart = 0;

        static Timer _fasttimer;
        static Timer _slowtimer;
        CommunicationManager comm = new CommunicationManager();
        string transType = string.Empty;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           LoadValues();
           SetDefaults();
           SetControlState();

           GraphPane temperaturelongPane = temperaturelong.GraphPane;
           CreateGraph(temperaturelongPane, "Temperature", 1440 * 1, 30 * 1, 10, 30);
           GraphPane moisturelongPane = moisturelong1.GraphPane;
           CreateGraph(moisturelongPane, "Moisture", 1440 * 1, 30 * 1, 50, 100);
           GraphPane lightlongPane = lightlong.GraphPane;
           CreateGraph(lightlongPane, "Light", 1440 * 1, 30 * 1, 0, 100);
           GraphPane temperatureshortPane = temperatureshort.GraphPane;
           CreateGraph(temperatureshortPane, "Temperature", 30, 2, 10, 30);
           GraphPane lightshortPane = lightshort.GraphPane;
           CreateGraph(lightshortPane, "Light", 30, 2, 0, 100);
           GraphPane moistureshortPane = moistureshort1.GraphPane;
           CreateGraph(moistureshortPane, "Moisture", 30, 2, 50, 100);
        }

        private void CreateGraph(GraphPane graph, string label, double xmax, double step, double ymin, double ymax)
        {
            graph.Title.IsVisible = false;
            graph.XAxis.Title.FontSpec.Size = 12;
            graph.XAxis.Title.IsVisible = false;
            graph.YAxis.Title.IsVisible = false;
            //graph.XAxis.Title.Text = "Hours";
            //graph.YAxis.Title.Text = label;
            graph.IsFontsScaled = false;

            // Just manually control the X axis range so it scrolls continuously
            // instead of discrete step-sized jumps
            graph.XAxis.Scale.Min = 0;
            graph.XAxis.Scale.Max = xmax;
            graph.YAxis.Scale.MinorStep = ymax/8;
            graph.YAxis.Scale.MajorStep = ymax/4;
            graph.XAxis.Scale.MinorStep = step;
            graph.XAxis.Scale.MajorStep = step * 2;
            graph.YAxis.Scale.Min = ymin;
            graph.YAxis.Scale.Max = ymax;
            graph.XAxis.MajorGrid.IsVisible = true;
            graph.YAxis.MajorGrid.IsVisible = true;

            graph.XAxis.Scale.IsVisible = false;


            // Save 1200 points.  At 50 ms sample rate, this is one minute
            // The RollingPointPairList is an efficient storage class that always
            // keeps a rolling set of point data without needing to shift any data values
            RollingPointPairList list = new RollingPointPairList((int)(xmax * 2));
            RollingPointPairList list2 = new RollingPointPairList((int)(xmax * 2));
            RollingPointPairList list3 = new RollingPointPairList((int)(xmax * 2));

            // Initially, a curve is added with no data points (list is empty)
            // Color is blue, and there will be no symbols
            LineItem curve = graph.AddCurve("", list, Color.Blue, SymbolType.None);
            curve.Line.Width = 2.0F;

            curve = graph.AddCurve("", list2, Color.Red, SymbolType.None);
            curve.Line.Width = 2.0F;

            curve = graph.AddCurve("", list3, Color.Green, SymbolType.None);

            curve.Line.Width = 2.0F;


            // Scale the axes
            graph.AxisChange();

        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            comm.Parity = "None";
            comm.StopBits = "One";
            comm.DataBits = "8";
            comm.BaudRate = "9600";
            comm.DisplayWindow = rtbDisplay;
            comm.PortName = cboPort.Text;
            comm.OpenPort();

            cmdOpen.Enabled = false;
            cmdClose.Enabled = true;
            cmdSend.Enabled = true;


            _fasttimer = new Timer();         // Set up the timer for 3 seconds
            _fasttimer.Tick += new EventHandler(FastTimerEventProcessor);
            _fasttimer.Interval = 1000;
            _fasttimer.Start();

            _slowtimer = new Timer();         // Set up the timer for 3 seconds
            _slowtimer.Tick += new EventHandler(SlowTimerEventProcessor);
            _slowtimer.Interval = 60000;
            _slowtimer.Start();

            // Save the beginning time for reference
            tickStart = Environment.TickCount;


        }

        private void FastTimerEventProcessor(Object myObject,
                                        EventArgs myEventArgs)
        {
            // Create a string array and store the contents of the Lines property.
            string[] tempArray = comm.DisplayWindow.Lines;
            string line = tempArray[tempArray.Length - 2];
            if (line == "")
                return;

            string[] values = Regex.Split(line, ",");
            if (values.Length < 5)
                return;

            //0 = moisture
            //1 = moisture
            //2 = moisture
            //3 = light
            //4 = temp
            //5 = mapped_temp
            //6 = seconds_elapsed
            //7 = seconds_light
            //8 = proportion_to_light
            //9 = proportion_lit

            Double moisture1 = Double.Parse(values[0]);
            Double moisture2 = Double.Parse(values[1]);
            Double moisture3 = Double.Parse(values[2]);
            Double light1 = Double.Parse(values[3]);
            Double temp = Double.Parse(values[4]);
            Double mapped_temp = Double.Parse(values[5]);
            Double seconds_elapsed = Double.Parse(values[6]);

            temperature.Text = String.Format("{0:0.0}", mapped_temp) + "°C";
            light.Text = String.Format("{0:0.0}", light1 / 1024 * 100) + "%";
            moisturedisplay1.Text = String.Format("{0:0.0}", moisture1 / 1024 * 100) + "%";
            moisturedisplay2.Text = String.Format("{0:0.0}", moisture2 / 1024 * 100) + "%";
            moisturedisplay3.Text = String.Format("{0:0.0}", moisture3 / 1024 * 100) + "%";

            UpdateGraph(temperatureshort, 30, mapped_temp, 0);
            UpdateGraph(moistureshort1, 30, moisture1 / 1024 * 100, 0);
            UpdateGraph(moistureshort1, 30, moisture2 / 1024 * 100, 1);
            UpdateGraph(moistureshort1, 30, moisture3 / 1024 * 100, 2);
            UpdateGraph(lightshort, 30, light1 / 1024 * 100, 0);
        }

        private void SlowTimerEventProcessor(Object myObject,
                                        EventArgs myEventArgs)
        {
            // Create a string array and store the contents of the Lines property.
            string[] tempArray = comm.DisplayWindow.Lines;
            string line = tempArray[tempArray.Length - 2];
            if (line == "")
                return;

            string[] values = Regex.Split(line, ",");
            if (values.Length < 5)
                return;

            Double moisture1 = Double.Parse(values[0]);
            Double moisture2 = Double.Parse(values[1]);
            Double moisture3 = Double.Parse(values[2]);
            Double light1 = Double.Parse(values[3]);
            Double temp = Double.Parse(values[4]);
            Double mapped_temp = Double.Parse(values[5]);
            Double seconds_elapsed = Double.Parse(values[6]);

            temperature.Text = String.Format("{0:0.0}", mapped_temp) + "°C";
            light.Text = String.Format("{0:0.0}", light1 / 1024 * 100) + "%";
            moisturedisplay1.Text = String.Format("{0:0.0}", moisture1 / 1024 * 100) + "%";
            moisturedisplay2.Text = String.Format("{0:0.0}", moisture1 / 1024 * 100) + "%";
            moisturedisplay3.Text = String.Format("{0:0.0}", moisture1 / 1024 * 100) + "%";

            UpdateGraph(temperaturelong, 1440, mapped_temp, 0);
            UpdateGraph(moisturelong1, 1440, moisture1 / 1024 * 100, 0);
            UpdateGraph(moisturelong1, 1440, moisture2 / 1024 * 100, 1);
            UpdateGraph(moisturelong1, 1440, moisture3 / 1024 * 100, 2);
            UpdateGraph(lightlong, 1440, light1 / 1024 * 100, 0);
        }

        private void UpdateGraph(ZedGraphControl graph, double scale, double value, int item)
        {

            // Make sure that the curvelist has at least one curve
            if (graph.GraphPane.CurveList.Count <= 0)
                return;

            // Get the first CurveItem in the graph
            LineItem curve = graph.GraphPane.CurveList[item] as LineItem;
            if (curve == null)
                return;

            // Get the PointPairList
            IPointListEdit list = curve.Points as IPointListEdit;
            // If this is null, it means the reference at curve.Points does not
            // support IPointListEdit, so we won't be able to modify it
            if (list == null)
                return;

            // Time is measured in seconds
            double time = (Environment.TickCount - tickStart) / 1000.0;

            // 3 seconds per cycle
            list.Add(time, value);

            // Keep the X scale at a rolling 30 second interval, with one
            // major step between the max X value and the end of the axis
            Scale xScale = graph.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = time + xScale.MajorStep;
                xScale.Min = xScale.Max - scale;
            }

            // Make sure the Y axis is rescaled to accommodate actual data
            graph.AxisChange();
            // Force a redraw
            graph.Invalidate();
        }

        /// <summary>
        /// Method to initialize serial port
        /// values to standard defaults
        /// </summary>
        private void SetDefaults()
        {
            cboPort.SelectedIndex = 1;
        }

        /// <summary>
        /// methos to load our serial
        /// port option values
        /// </summary>
        private void LoadValues()
        {
            comm.SetPortNameValues(cboPort);
        }

        /// <summary>
        /// method to set the state of controls
        /// when the form first loads
        /// </summary>
        private void SetControlState()
        {
            //rdoText.Checked = true;
            cmdSend.Enabled = false;
            cmdClose.Enabled = false;
        }
    }
}