using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myS7ProSimLib;

namespace BokhanS7
{
    public partial class Form1 : Form
    {
        myS7ProSimLib.S7ProSim simatic = new myS7ProSimLib.S7ProSim();
        public Form1()
        {
            InitializeComponent();
        }

        private void connect(object sender, EventArgs e)
        {
            simatic.Connect();
            cpu_value.Text = simatic.GetState();
            scan_value.Text = simatic.GetScanMode().ToString();
            label_status.Text = "Connected";
        }

        private void disconnect(object sender, EventArgs e)
        {
            simatic.Disconnect();
            cpu_value.Text = "";
            scan_value.Text = "";
            label_status.Text = "Disconnected";
        }
        private void cpu_changed(object sender, EventArgs e)
        {
            string selected = cb_cpu.SelectedItem.ToString();

            simatic.SetState(selected);
            cpu_value.Text = selected;
        }

        private void scan_changed(object sender, EventArgs e)
        {
            string selected = cb_scan.SelectedItem.ToString();

            if (selected == "Single Scan")
            {
                simatic.SetScanMode(myS7ProSimLib.ScanModeConstants.SingleScan);
            }
            else if (selected == "Continuous Scan")
            {
                simatic.SetScanMode(myS7ProSimLib.ScanModeConstants.ContinuousScan);
            }
            
            scan_value.Text = selected;
        }

        private void prim_changed(object sender, EventArgs e)
        {
            object I0_0 = cb_primpump.Checked;

            simatic.WriteInputPoint(0, 0, ref I0_0);

            if ((simatic.GetState() == "RUN" || simatic.GetState() == "RUN_P") && Convert.ToBoolean(I0_0) == true)
            {
                button_prim.BackColor = Color.Green;
            }
            else
            {
                button_prim.BackColor = Color.White;
            }
        }

        private void reserve_pump(object sender, EventArgs e)
        {
            object I0_1 = cb_reservepump.Checked;

            simatic.WriteInputPoint(0, 1, ref I0_1);

            if ((simatic.GetState() == "RUN" || simatic.GetState() == "RUN_P") && Convert.ToBoolean(I0_1) == true)
            {
                button_reserve.BackColor = Color.Green;
            }
            else
            {
                button_reserve.BackColor = Color.White;
            }
        }

        private void rb_auto(object sender, EventArgs e)
        {
            object I0_2 = !radioButton1.Checked;

            simatic.WriteInputPoint(0, 2, ref I0_2);

            if ((simatic.GetState() == "RUN" || simatic.GetState() == "RUN_P") && Convert.ToBoolean(I0_2) == true)
            {
                button_state.Text = "Automatic";
            }
        }

        private void rb_manual(object sender, EventArgs e)
        {
            object I0_2 = radioButton2.Checked;

            simatic.WriteInputPoint(0, 2, ref I0_2);

            if ((simatic.GetState() == "RUN" || simatic.GetState() == "RUN_P") && Convert.ToBoolean(I0_2) == true)
            {
                button_state.Text = "Manual";
            }
        }

        private void timer(object sender, EventArgs e)
        {
            object Q0_0 = false;

            simatic.ReadOutputPoint(0, 0, myS7ProSimLib.PointDataTypeConstants.S7_Bit, ref Q0_0);

            pictureBox1.BackColor = (bool)Q0_0 ? Color.Green : Color.Transparent;
        }
    }
}
