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

            try { //tries to execute this

                //takes the current text in the 'output' text box and
                //computes it using the 'table' instance of 'DataTable'
                //<DataTable>.Compute(string textToBeComputed, string filter)
                txtOut.Text = table.Compute(txtOut.Text, "") + "";
            } catch { //if an exeption happens, execute this
                txtOut.Text = "ERRORORORORO";
            }
        }

        private void writeButton(object button, EventArgs e) {
            //calls method for writing on the screen
            writeOutput(
                //cast the sender as a system button and gathers the text writen on it for usage as an argument
                ((Button)button).Text
            );
        }
        private void writeFunctionButton(object button, EventArgs e) {
            //does the same
            writeOutput( ((Button)button).Text );
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
