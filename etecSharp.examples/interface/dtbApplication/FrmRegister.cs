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
/// 
/// LOADING
/// 
        /// <summary>
        /// Initializes the form window
        /// </summary>
        public FrmRegister() {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the database when the window opens.
        /// </summary>
        private void FrmRegister_Load(object sender, EventArgs e) {
            this.tbPersonTableAdapter.Fill(this._DataSet.tbPerson);
        }

/// 
/// FUNCTIONS
/// 

        /// <summary>
        /// This instance holds the connection state of the database
        /// </summary>
        private OleDbConnection _connection = DTBConnection.connect();

        /// <summary>
        /// Reader for the table 'tbPerson'
        /// </summary>
        private OleDbDataReader readTbPerson;
        private BindingSource bindTbPerson = new BindingSource();

        /// <summary>
        /// String holding the arguments for the query search on the database
        /// </summary>
        private string query = null;
        /// <summary>
        /// Executes the query in the database using the connection selected.
        /// </summary>
        /// <param name="query">is the string with the query to be executed</param>
        /// <param name="connection">is the connection to be used for the execusion</param>
        /// <returns>the OleDbCommand holding the results of this query</returns>
        private OleDbCommand executeQuery(string query, OleDbConnection connection) {
            OleDbCommand _dtCommand = new OleDbCommand(query, connection);

            ///if the command is not to search/select...
            if (!query.StartsWith("select")) {
                ///executes the query normally.
                _dtCommand.ExecuteNonQuery();

            ///otherwise if the search query has no rows
            } else if (!_dtCommand.ExecuteReader().HasRows) {
                MessageBox.Show("executeQuery(): nothing found.");
            }

            return _dtCommand;
        }

        /// <summary>
        /// Executes a search query on the database
        /// </summary>
        public void search() {
            string nameParam = "";
            string responseParam = "";

            if (!txtName.Text.Equals("")) { //if there is a search parameter for the name...

                //includes the name in the query
                nameParam = string.Format("where personName like '%{0}%'", txtName.Text);

                //if there is also a parameter for the response search
                if (!txtResponse.Text.Equals("")) {
                    nameParam += ", "; //includes a space for querying 
                }
            }
            if (!txtResponse.Text.Equals("")) {
                responseParam = string.Format("where personResponse like '%{0}%'", txtResponse.Text);
            }

            ///"select (columns) from tbPerson {where {search queries}} order by personName;"
            query =
                 "select personName as [Name], personResponse as [Response] from tbPerson"
                +nameParam
                +responseParam
                +"order by personName;";

            ///executes the query
            executeQuery(this.query, this._connection);
        }

        /// <summary>
        /// Button action for registering a person into the database 'tbPerson'
        /// </summary>
        private void registerPerson(object sender, EventArgs e) {
            ///gathers the info from both fields...
            string nameParam = txtName.Text;
            string responseParam = txtResponse.Text;

            ///if any are empty, interrupt.
            if (nameParam.Equals("") | responseParam.Equals("")) {
                MessageBox.Show(@"Missing data :\", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ///"insert into tbPerson(columns) values('{name}', '{response}');"
            query =
                 "insert into tbPerson(personName, personResponse) values ('"
                +nameParam      +"', '"
                +responseParam  +"');";

            ///executes the query
            executeQuery(this.query, this._connection);

            MessageBox.Show("registered! :3");
        }
    }
}
