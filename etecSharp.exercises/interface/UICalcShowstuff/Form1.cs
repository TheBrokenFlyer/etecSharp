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


        private double aa() {
            //TO BE CONTINUED
            return System.Convert.ToDouble("1+1");
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e) {
            textBox1.Text = aa() + "";
        }

        
    }
}
