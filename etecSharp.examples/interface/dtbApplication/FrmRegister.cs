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
            query =
                 "select personName as [Name], personResponse as [Response] "
                +"where (personName like '%|NAME|%'
                +"order by personName";
        }
    }
}
