using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {

        private double  points  = 0,
                        pow     = 1,
                        powReq  = 1;

        public Form1() {
            InitializeComponent();
        }

        private void addPoints(object sender, EventArgs e) {
            this.points += this.pow;
            lblPoints.Text = this.points.ToString();
        }

        private void addPow(object sender, EventArgs e) {
            if (this.points >= this.powReq) {
                this.points -= this.powReq;
                this.pow *= 2;
            }

            lblPoints.Text = this.points.ToString();
            btnAddPow.Text = "pow++; (" + this.powReq + ")";
        }

    }
}
