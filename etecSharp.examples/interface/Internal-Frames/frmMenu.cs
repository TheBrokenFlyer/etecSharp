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

        public frmSub internalWindow { get; set; }
        private int windowCount { get; set; }


        public frmMenu() {
            InitializeComponent();
            IsMdiContainer = true;
        }

        
        

        private void newWindow(object sender, EventArgs e) {
            this.internalWindow = new frmSub(); //creates an instance of the window named 'window'.

            this.internalWindow.MdiParent = this; //sets 'this' instance of frmMenu as its parent, so the window can host the instance.
            this.internalWindow.Show(); //this is an equivalent from '.setVisible(true);' in Java. it just makes the window visible.
            
            this.internalWindow.Text =  //sets the name of this window... {
                txtWindowName.Text                 //gathers the name the user typed
                    .Replace(                     //and applies formatting syntax to it
                        "%N%",                   //where it replaces any entries of '%N%'
                        ++this.windowCount + "" //with the number of windows that the user had opened.
                    );
            //...}
        }
    }
}
