using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIInternalFrame {

    public partial class frmMenu : Form {

        public static frmSub    internalWindowUnique,
                                internalWindowMultiple;
        private int windowCount { get; set; }


        public frmMenu() {
            InitializeComponent();
            IsMdiContainer = true;
        }

        
        

        private void newWindowUnique(object sender, EventArgs e) {
            if(internalWindowUnique == null) {
                internalWindowUnique = new frmSub(); //creates an instance of the window named 'window'.

                internalWindowUnique.MdiParent = this; //sets 'this' instance of frmMenu as its parent, so the window can host the instance.
                internalWindowUnique.Show(); //this is an equivalent from '.setVisible(true);' in Java. it just makes the window visible.

                internalWindowUnique.Text =  //sets the name of this window... {
                    txtWindowName.Text                 //gathers the name the user typed
                        .Replace(                     //and applies formatting syntax to it
                            "%N%",                   //where it replaces any entries of '%N%'
                            ++this.windowCount + "" //with the number of windows that the user had opened.
                        );//...}
            }
        }

        private void newWindowMultiple(object sender, EventArgs e) {
            internalWindowMultiple = new frmSub(); //creates an instance of the window named 'window'.

            internalWindowMultiple.MdiParent = this; //sets 'this' instance of frmMenu as its parent, so the window can host the instance.
            internalWindowMultiple.Show(); //this is an equivalent from '.setVisible(true);' in Java. it just makes the window visible.
        }

        private void closeApplication(object sender, EventArgs e) {
            if(MessageBox.Show("Are you sure you want to exit?", "Closing", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                this.Close();
            }
        }

        private void toggleResizable(object sender, EventArgs e) {
            if(internalWindowUnique.FormBorderStyle != System.Windows.Forms.FormBorderStyle.SizableToolWindow) {
                internalWindowUnique.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            } else {
                internalWindowUnique.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            }
        }

    }
}
