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
        private void executeQuery(string query, OleDbConnection connection) {
            ///prepares the command to be executed
            OleDbCommand _dtCommand = new OleDbCommand(query, connection);

            ///if the command is not to search/select...
            if (!query.StartsWith("select")) {
                ///executes the query normally.
                _dtCommand.ExecuteNonQuery();

            ///otherwise if the search query has no rows
            } else {
                ///executes the reader and sends to the reader
                this.readTbPerson = _dtCommand.ExecuteReader();

            }
        }

        /// <summary>
        /// Executes a search query on the table 'tbPerson'.
        /// </summary>
        /// <param name="name">is the name to be searched</param>
        /// <param name="response">is the response to be searched</param>
        /// <param name="like">if the parameter is LIKE</param>
        public void searchPerson(string name, string response, bool like) {
            string parameters = "";

            string criteriaEql = null;
            string criteriaChar = null;

            if (like) {
                criteriaEql = "like";
                criteriaChar = "%";
            } else {
                criteriaEql = "=";
                criteriaChar = "";
            }

            if(name.Length > 0) {
                parameters += string.Format("where (personName {1} '{2}{0}{2}')", name, criteriaEql, criteriaChar);
            }
            if(response.Length > 0) {
                if (parameters.Length > 0) {
                    parameters += " and ";
                } else {
                    parameters += " where ";
                }

                parameters += string.Format("(personResponse {1} '{2}{0}{2}')", response, criteriaEql, criteriaChar);
            }

            ///"select (columns) from tbPerson {where {search queries}} order by personName;"
            query = string.Format(
                        "select personName as [Name], personResponse as [Response] from tbPerson {0} order by personName;",
                        parameters
                    );

            ///executes the query
            this.executeQuery(this.query, this._connection);
            ///updates the database with the search results
            dtbContestants.DataSource = this.readTbPerson;
        }

        /// <summary>
        /// Registers a person into the database 'tbPerson'
        /// </summary>
        private void registerPerson(string name, string response) {
            ///if any are empty, interrupt.
            if (name.Equals("") | response.Equals("")) {
                MessageBox.Show(@"Missing data :\", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ///"insert into tbPerson(columns) values('{name}', '{response}');"
            query =
                 "insert into tbPerson(personName, personResponse) values ('"
                +name      +"', '"
                +response  +"');";

            ///tries to execute the query
            try {
                executeQuery(this.query, this._connection);
                MessageBox.Show("registered! :3");

            } catch (OleDbException exp) {
                MessageBox.Show(@"Failed to register :\" + '\n' + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ///updates the table
            this.searchPerson(txtName.Text, txtResponse.Text, false);
        }

        private void button_registerPerson(object sender, EventArgs e) {
            this.registerPerson(txtName.Text, txtResponse.Text);
        }

        private void button_searchPerson(object sender, EventArgs e) {
            ///updates the table
            this.searchPerson(txtName.Text, txtResponse.Text, false);
        }
    }
}
