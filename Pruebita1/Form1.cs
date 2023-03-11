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
    public partial class Quote : Form
    {
        public Quote()
        {
            InitializeComponent();
        }

        
        private void Quote_Load(object sender, EventArgs e)
        {
            string message = "Do you wish to contact us? ";
            string tittle = "Contact";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            DialogResult result = MessageBox.Show(message, tittle, button, icon);

            if( result == DialogResult.No)
            {
                MessageBox.Show("All good, Bye", tittle);
                this.Close();
            }
            
        }
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string texto = txtNombre.Text + " " + txbSurname.Text;
            string reason = txtreason.Text;           
            DateTime date = dt1.Value;
            lblSaludo.Text = " Hola " + texto + ", el dia " + date + " te contactamos con motivo de tu consulta:  " + reason;
           
        }

    }
}
