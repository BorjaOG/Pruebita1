using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebita1
{
    public partial class BeautySA : Form
    {
        public BeautySA()
        {
            InitializeComponent();
        }

        private void Apointments_Click(object sender, EventArgs e)
        {
            Quote window = new Quote();
            window.ShowDialog();

            
        }
    }
}
