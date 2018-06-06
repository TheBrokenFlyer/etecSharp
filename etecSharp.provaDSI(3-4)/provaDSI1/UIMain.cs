using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIMixedExercises {
    public partial class UIMain : Form {
        public UIMain() {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        public static UIExercise1 ex1 = null;
        public static UIExercise2 ex2 = null;
        public static UIExercise3 ex3 = null;
        public static UIExercise4 ex4 = null;
        public static UIExercise5 ex5 = null;
        public static UIExercise6 ex6 = null;
        public static UIExercise7 ex7 = null;

        private void openExercise(object sender, EventArgs e) {
            switch (
                int.Parse(
                    ((ToolStripMenuItem)sender).Text
                )
            ) {
                case 1:
                    if (ex1 == null) {
                        ex1 = new UIExercise1();
                        ex1.MdiParent = this;
                        ex1.Show();
                    }
                    break;
                case 2:
                    if (ex2 == null) {
                        ex2 = new UIExercise2();
                        ex2.MdiParent = this;
                        ex2.Show();
                    }
                    break;
                case 3:
                    if (ex3 == null) {
                        ex3 = new UIExercise3();
                        ex3.MdiParent = this;
                        ex3.Show();
                    }
                    break;
                case 4:
                    if (ex4 == null) {
                        ex4 = new UIExercise4();
                        ex4.MdiParent = this;
                        ex4.Show();
                    }
                    break;
                case 5:
                    if (ex5 == null) {
                        ex5 = new UIExercise5();
                        ex5.MdiParent = this;
                        ex5.Show();
                    }
                    break;
                case 6:
                    if (ex6 == null) {
                        ex6 = new UIExercise6();
                        ex6.MdiParent = this;
                        ex6.Show();
                    }
                    break;
                case 7:
                    if (ex7 == null) {
                        ex7 = new UIExercise7();
                        ex7.MdiParent = this;
                        ex7.Show();
                    }
                    break;
                default:
                    MessageBox.Show("Exercise not done yet.");
                    break;
            }

        }

        
    }
}
