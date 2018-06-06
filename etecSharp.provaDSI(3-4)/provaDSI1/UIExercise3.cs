using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIMixedExercises {
    public partial class UIExercise3 : Form {
        public UIExercise3() {
            InitializeComponent();
        }

        private void closeWindow(object sender, FormClosedEventArgs e) {
            UIMain.ex3 = null;
        }

        private void update(object sender, EventArgs e) {
                 if (num1.Value == num2.Value & num1.Value == num3.Value) { lblTriangle.Text = "Equilátero"; }
            else if (num1.Value != num2.Value & num1.Value != num3.Value) { lblTriangle.Text = "Isóceles"; }
            else                                                          { lblTriangle.Text = "Escaleno"; }
        }
    }
}
