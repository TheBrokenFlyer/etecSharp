using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIInternalFrame {
    public partial class frmSub : Form {
        public frmSub() {
            InitializeComponent();
        }

        private void closeWindow(object sender, FormClosedEventArgs e) {
            frmMenu.internalWindowUnique = null;
        }
    }
}
