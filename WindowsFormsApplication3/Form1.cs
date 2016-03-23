using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Epics;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        private ProcessVariable pv;

        public Form1()
        {
            InitializeComponent();

            pv = new ProcessVariable("chas:HEADSTA");
            pv.DataEvent += pv_DataEvent;
            pv.Connect();
        }

        void pv_DataEvent(object sender, ProcessVariable.DataEventArgs args)
        {
           SetLabel((string)args.data);
        }

        // Delegate for setting label text
        private delegate void SetLabelDelegate(string newText);
        private void SetLabel(string newText)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new SetLabelDelegate(SetLabel), new object[] { newText });
                return;
            }

            label1.Text = newText;
        }

        private void epicsLabel1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
