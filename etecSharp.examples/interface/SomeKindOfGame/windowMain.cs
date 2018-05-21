using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class windowMain : Form {

        public windowMain() {
            InitializeComponent();
        }

        Size size = new Size(60, 70);
        int points = 0;

        private void addPoints(object sender) {
            this.Size = new Size(size.Width+=6, size.Height+=4);
            this.Text = ++points + "";
            btnLose.Focus();

            if (timer1.Interval > 500) {
                timer1.Interval -= 2;
            }

            Random r = new Random(new Random().Next(9999).GetHashCode());
            
            btnPoint.Location = new Point(
                                        r.Next(12, this.Size.Width-(12*4)),
                                        r.Next(12, this.Size.Height-(12*4))
                                    );
        }

        private void keyAddPoints(object sender, KeyEventArgs e) {
            addPoints(sender);
        }

        private void keyAddPoints(object sender, EventArgs e) {
            addPoints(sender);
        }

        private void keyMinusPoints(object sender, EventArgs e) {
            this.Size = new Size(size.Width -= 2, size.Height -= 1);
            this.Text = --points + "";
        }

        private void btnPoint_Enter(object sender, EventArgs e) {
            btnPoint.Focus();
        }

        private void btnPoint_Leave(object sender, EventArgs e) {
            btnLose.Focus();
        }
        


    }
}
