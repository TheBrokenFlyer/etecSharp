using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIMixedExercises {
    public partial class UIExercise1 : Form {
        public UIExercise1() {
            InitializeComponent();
        }

        private void closeWindow(object sender, FormClosedEventArgs e) {
            UIMain.ex1 = null;
        }

        private void update(object sender, EventArgs e) {
            if (txt1.Text == "") {
                txt1.Text = 0 +"";
            }
            if (txt2.Text == "") {
                txt2.Text = 0 + "";
            }
            try {
                double[] i = { double.Parse(txt1.Text), double.Parse(txt2.Text) };
                double re = i[0] + i[1];
                if (re > 20) {
                    lblResult.Text = (re+8) +"";
                    lblPlus.Visible = false;
                    lblMinus.Visible = true;
                } else if (re == 20) {
                    lblResult.Text = (re-5) +"";
                    lblPlus.Visible = false;
                    lblMinus.Visible = true;
                } else {
                    lblResult.Text = re +"";
                    lblPlus.Visible = false;
                    lblMinus.Visible = false;
                }
            } catch {
                lblResult.Text = "error";
            }
        }
    }
}
