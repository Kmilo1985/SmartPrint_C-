using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPrint
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void TimerSplash_Tick(object sender, EventArgs e)
        {
            FrmInicio inicio = new FrmInicio();

            progressBar1.Increment(4);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                inicio.Show();
                TimerSplash.Stop();
                this.Visible = false;
            }
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            TimerSplash.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
