using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIMixedExercises {
    public partial class UIExercise6 : Form {
        public UIExercise6() {
            InitializeComponent();
        }

        private void closeWindow(object sender, FormClosedEventArgs e) {
            UIMain.ex6 = null;
        }

        private void print(object sender, EventArgs e) {
            list.Items.Clear();
            try {
                if (num.Value < 0) {
                    for (int i = 0; i <= -num.Value; ++i) {
                        list.Items.Add("!!!LISARB");
                    }
                } else {
                    for (int i = 0; i <= num.Value; ++i) {
                        list.Items.Add("BRASIL!!!");
                    }
                }
            } catch {
                list.Items.Add("[ERROR]");
            }
        }
    }
}
