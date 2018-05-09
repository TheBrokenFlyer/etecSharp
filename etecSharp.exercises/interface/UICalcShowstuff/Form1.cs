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

            txtOut.Text = "0";
        }

        DataTable table = new DataTable();

        bool funPressed = false;

        private void btnEql_Click(object sender, EventArgs e) {
            txtOut.Text = table.Compute(txtOut.Text, "") + "";
        }

        private void click0(object sender, EventArgs e) { writeOutput('0'); }
        private void click1(object sender, EventArgs e) { writeOutput('1'); }
        private void click2(object sender, EventArgs e) { writeOutput('2'); }
        private void click3(object sender, EventArgs e) { writeOutput('3'); }
        private void click4(object sender, EventArgs e) { writeOutput('4'); }
        private void click5(object sender, EventArgs e) { writeOutput('5'); }
        private void click6(object sender, EventArgs e) { writeOutput('6'); }
        private void click7(object sender, EventArgs e) { writeOutput('7'); }
        private void click8(object sender, EventArgs e) { writeOutput('8'); }
        private void click9(object sender, EventArgs e) { writeOutput('9'); }

        private void clickSum(object sender, EventArgs e) { writeOutput('+'); }
        private void clickSub(object sender, EventArgs e) { writeOutput('-'); }
        private void clickMul(object sender, EventArgs e) { writeOutput('*'); }
        private void clickDiv(object sender, EventArgs e) { writeOutput('/'); }

        private void writeOutput(char arg) {
            if (txtOut.Text == "0" | funPressed) {
                txtOut.Text = arg + "";
            } else {
                txtOut.Text += arg;
            }

            funPressed = false;
        }
    }
}
