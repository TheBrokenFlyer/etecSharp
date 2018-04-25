using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class UIAverage3 : Form {
        public UIAverage3() {
            InitializeComponent();
        }

        private void numberUpdate(object sender, EventArgs e) {
            txtOut.Text = "" + (numVal1.Value + numVal2.Value + numVal3.Value) / 3;
        }

        
    }
}
