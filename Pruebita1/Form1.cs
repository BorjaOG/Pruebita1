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

            CmbPosition.Items.Add("Medicare");
            CmbPosition.Items.Add("Bupa");
            CmbPosition.Items.Add("OSHC");
            CmbPosition.Items.Add("None");


        }
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string Name = txtNombre.Text + " " + txbSurname.Text;
            string Reason = txtreason.Text;           
            DateTime Date = dt1.Value;
            string Married = ChbMarried.Checked == true ? "married": "single";          
            string Insurance = CmbPosition.SelectedItem.ToString();
            string Kids = NmKids.Text;
            string Nationality;

            if (RbAussie.Checked)
                Nationality = "Aussie";
            else
                Nationality = "other than Australian";


            string Message =  Name + ", born on the " + Date + ", with nationality  " + Nationality + " , " + Married + ", with " + Kids + " kids " + " and " + Insurance + "insurance,  we are contacting you because you have told us:  " + Reason + "do you wish to confirm your appointment?";

           
            MessageBox.Show(Message);
        }


    }
}
