using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void R1_Click(object sender, EventArgs e)
        {

        }

        private void S1R1_TextChanged(object sender, EventArgs e)
        {
            double ResistorSeries1 = double.Parse(S1R1.Text);
            double ResistorSeries2 = double.Parse(S1R2.Text);
            double ResistorParallel1 = double.Parse(P1R1.Text);
            double ResistorParallel2 = double.Parse(P1R2.Text);
            double ResistorSeries3 = double.Parse(S2R1.Text);
            double ResistorSeries4 = double.Parse(S2R2.Text);
            double ResistorSeries5 = double.Parse(S2R3.Text);
            double ResistorParallel3 = double.Parse(P2R1.Text);
            double ResistorParallel4 = double.Parse(P2R2.Text);
            double ResistorParallel5 = double.Parse(P2R3.Text);
        }

        private void Series1_Click(object sender, EventArgs e)
        {

        }
    }
}
