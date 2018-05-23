using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {

    public partial class frmMenu : Form {

        public frmMenu() {
            InitializeComponent();
            //MessageBox.Show("hello", "uwu", MessageBoxButtons.OK);
            IsMdiContainer = true;
        }

        private void newWindow(object sender, EventArgs e) {
            frmSub window = new frmSub();
            window.MdiParent = this;
            window.Show();
        }
    }
}
