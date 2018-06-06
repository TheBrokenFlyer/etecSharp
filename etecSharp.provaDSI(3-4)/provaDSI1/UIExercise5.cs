using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIMixedExercises {
    public partial class UIExercise5 : Form {
        public UIExercise5() {
            InitializeComponent();
        }

        private void closeWindow(object sender, FormClosedEventArgs e) {
            UIMain.ex5 = null;
        }

        private void print(object sender, EventArgs e) {
            list.Items.Clear();
            try {
                for (int i=0; i <= num.Value; ++i) {
                    list.Items.Add(i);
                }
            } catch {
                list.Items.Add("[ERROR]");
            }
        }
    }
}
