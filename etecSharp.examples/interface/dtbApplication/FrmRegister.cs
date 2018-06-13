using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dtbApplication {
    public partial class FrmRegister : Form {
        public FrmRegister() {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e) {
            this.tbPersonTableAdapter.Fill(this._DataSet.tbPerson);
        }

        private OleDbConnection _connection = DTBConnection.connect();
        private OleDbDataReader readTbPerson;
        private BindingSource bindTbPerson = new BindingSource();
        private string query = null;

        /// <summary>
        /// Executes a query
        /// </summary>
        public void search() {
            string nameParam = "";
            string responseParam = "";

            ///if there is a 
            if (!txtName.Text.Equals("")) {
                nameParam = string.Format("where personName like '%{0}%'", txtName.Text);
                if (!txtResponse.Text.Equals("")) {
                    nameParam += ", ";
                }
            }
            if (!txtResponse.Text.Equals("")) {
                responseParam = string.Format("where personResponse like '%{0}%'", txtResponse.Text);
            }
            query =
                 "select personName as [Name], personResponse as [Response] from tbPerson"
                +nameParam
                +responseParam
                +"order by personName";
        }
    }
}
