using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class UILargeof3 : Form {
        public UILargeof3() {
            InitializeComponent();
        }

        private string which() {
            if (numVal1.Value == numVal2.Value && numVal2.Value == numVal3.Value) {
                return "both";
            } else if (numVal1.Value > numVal2.Value) {
                    if (numVal1.Value > numVal3.Value) {
                        return string.Format(lblA.Text + numVal1.Value);
                    } else if (numVal1.Value < numVal3.Value) {
                        return string.Format(lblC.Text + numVal3.Value);
                    }
                } else if (numVal1.Value < numVal2.Value) {
                    if (numVal2.Value > numVal3.Value) {
                        return string.Format(lblB.Text + numVal2.Value);
                    } else if (numVal2.Value < numVal3.Value) {
                        return string.Format(lblC.Text + numVal3.Value);
                    }
                }
            
            return "{CASE_NOT_WRITEN}";
        }

        private void numberUpdate(object sender, EventArgs e) {

            txtOut.Text = which();
        }        
    }
}
