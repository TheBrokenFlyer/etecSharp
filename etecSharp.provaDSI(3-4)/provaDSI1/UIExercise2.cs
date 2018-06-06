using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIMixedExercises {
    public partial class UIExercise2 : Form {
        public UIExercise2() {
            InitializeComponent();
        }

        private void closeWindow(object sender, FormClosedEventArgs e) {
            UIMain.ex2 = null;
        }

        private void update(object sender, EventArgs e) {
            try {
                int num = int.Parse(txt1.Text);
                lbl10.Visible = num%10==0;
                lbl5.Visible = num%5==0;
                lbl2.Visible = num%2==0;
            } catch {
                txt1.Text = "0";
            }
        }
    }
}
