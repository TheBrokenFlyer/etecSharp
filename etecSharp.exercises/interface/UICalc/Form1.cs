using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private char funcType = '+';

        public Form1() {
            InitializeComponent();
            statFuncType.Text = string.Format("Function type: '{0}'", funcType);
        }

        private void setSum(object sender, MouseEventArgs e) {
            this.funcType = '+';
            statFuncType.Text = string.Format("Function type: '{0}'", funcType);
        }
        private void setSub(object sender, MouseEventArgs e) {
            this.funcType = '-';
            statFuncType.Text = string.Format("Function type: '{0}'", funcType);
        }
        private void setMul(object sender, MouseEventArgs e) {
            this.funcType = '*';
            statFuncType.Text = string.Format("Function type: '{0}'", funcType);
        }
        private void setDiv(object sender, MouseEventArgs e) {
            this.funcType = '/';
            statFuncType.Text = string.Format("Function type: '{0}'", funcType);
        }

        private double equals(char func, long a, long b) {
            switch (func) {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
                default:
                    return a + b;
            }
        }

        private void updateOutput(object sender, EventArgs e) {
            if (txtVal1.Text == "") { txtVal1.Text = "0"; }
            if (txtVal2.Text == "") { txtVal2.Text = "0"; }
            lblOutput.Text = equals(funcType, System.Convert.ToInt64(txtVal1.Text), System.Convert.ToInt64(txtVal2.Text)) + "";
        }
        private void updateOutput(object sender, MouseEventArgs e) {
            if (txtVal1.Text == "") { txtVal1.Text = "0"; }
            if (txtVal2.Text == "") { txtVal2.Text = "0"; }
            lblOutput.Text = equals(funcType, System.Convert.ToInt64(txtVal1.Text), System.Convert.ToInt64(txtVal2.Text)) + "";
        }
    }
}
