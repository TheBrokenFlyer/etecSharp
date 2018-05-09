using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace WindowsFormsApplication1 {
    public partial class UICalcShowstuff : Form {
        public UICalcShowstuff() {
            InitializeComponent();
        }
        
        DataTable table = new DataTable();

        private void btnEql_Click(object sender, EventArgs e) {
            txtOut.Text = table.Compute(txtOut.Text, "") + "";
        }

        private void writeButton(object sender, EventArgs e) {
            
            //calls method for writing on the screen
            writeOutput(
                //cast the sender as a system button and gathers the text writen on it for usage as an argument
                ((Button)sender).Text
            );
        }

        private void writeOutput(string arg) {
            if (txtOut.Text == "0") {
                txtOut.Text = arg + "";
            } else {
                txtOut.Text += arg;
            }
        }

        private void clearOutput(object sender, EventArgs e) {
            txtOut.Text = "0";
        }
    }
}
