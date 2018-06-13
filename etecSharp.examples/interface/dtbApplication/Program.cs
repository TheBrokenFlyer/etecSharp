using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace dtbApplication {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmRegister());
        }
    }

    public static class DTBConnection {

        private static string _connection_parameters = @"Provider=Microsoft.Ace.OLEDB.12.0;DataSource=TWOW-DTB.accdb";
        private static OleDbConnection _connection = null;

        /// <summary>
        /// Connects to the database.
        /// </summary>
        /// <returns>
        /// The <code>OleDbConnection</code> object with its connection opened.
        /// </returns>
        public static OleDbConnection connect() {
            //try to open connection
            try {
                _connection = new OleDbConnection(_connection_parameters);
                _connection.Open();
            } catch (Exception exp) {
                while (MessageBox.Show("Failed to connect!\n" + exp.GetBaseException() + '\n' + exp.Message,
                        "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error
                    ) == DialogResult.Retry
                ) {
                    //try to open the connection again
                    try {
                        _connection = new OleDbConnection(_connection_parameters);
                        _connection.Open();
                        return _connection;
                    } catch (Exception exp_) {
                        exp = exp_; //copy error to 'exp' and continue the loop
                    }
                }
                _connection = null;
            }
            //return the stabilished connection
            return _connection;
        }

        /// <summary>
        /// Closes the connection
        /// </summary>
        /// <returns>
        /// <code>true</code> if there was a connection previously opened, <code>false</code> if not
        /// </returns>
        public static bool close() {
            if(_connection != null) {
                _connection.Close();
                _connection = null;
                return true;
            } else {
                return false;
            }
        }
    }
}
