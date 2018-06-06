using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UIMixedExercises {
    public partial class UIExercise7 : Form {
        public UIExercise7() {
            InitializeComponent();
        }

        private void closeWindow(object sender, FormClosedEventArgs e) {
            UIMain.ex7 = null;
        }

        int arlindo = 150,
            manoel = 110,
            ano = 0;

        private void tick(object sender, EventArgs e) {
            //while (arlindo > manoel) {
                lblArlindo.Text = (arlindo+=2) +"cm";
                lblManoel.Text = (manoel+=3) +"cm";
                lblAno.Text = ++ano +"";
                if (manoel > arlindo) {
                    timer.Enabled = false;
                    lblAno.Text += "!!";
                }
            //}
        }
    }
}
