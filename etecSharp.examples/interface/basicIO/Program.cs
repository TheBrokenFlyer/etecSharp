using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace basicIO {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

		static string logpasta = @".\log";
		static string logarquivo = @".\log\log.txt"; 

		/// <summary>
		/// escreve num arquivo o log
		/// </summary>
		/// <param name="mensagem">a mensagem a ser escrita</param>
		public static void log(string mensagem) {
			if (!Directory.Exists(logpasta)) Directory.CreateDirectory(logpasta);
			using (StreamWriter escritor = File.AppendText(logarquivo)) {
				escritor.WriteLine(string.Format("[{0}] LOG: {1}",mensagem,new DateTime().ToString()));
			}
		}
	}

	/// <summary>
	/// Classe de conexão com o banco MSSQL
	/// </summary>
	public class Conector {
		private static SqlConnection _conn = null;
		private static string _connString =
			  "Data Source=localhost;"
			+ "Initial Catalog=dtb;"
			+ "User id=sa;"
			+ "Password=info211;";

		private static void conectar() {
			if (Conector._conn == null) Conector._conn = new SqlConnection(Conector._connString);
			Conector._conn.Open();
		}

		public static void fechar() {
			if (Conector._conn != null) {
				Conector._conn.Close();
				Conector._conn = null;
			}
		}

		public static void query(string id,ComboBox alvo) {
			if(Conector._conn==null) Conector.conectar();
			SqlCommand query = new SqlCommand("SELECT credUsr FROM tbCred WHERE (idDept = '"+id+"')", Conector._conn);
			SqlDataAdapter adapt = new SqlDataAdapter(query);
			DataTable resultados = new DataTable();
			adapt.Fill(resultados);
			List<string> retornar = new List<string>(0);
			foreach(DataRow linha in resultados.Rows) retornar.Add(linha[0].ToString());
			alvo.DataSource = retornar;
			Conector.fechar();
		}

		public static void queryDept(ComboBox alvo) {
			if(Conector._conn == null) Conector.conectar();
			SqlCommand query = new SqlCommand("SELECT * FROM tbDept",Conector._conn);
			SqlDataAdapter adapt = new SqlDataAdapter(query);
			DataTable resultados = new DataTable();
			adapt.Fill(resultados);
			List<string> retornar = new List<string>(0);
			foreach (DataRow linha in resultados.Rows) retornar.Add(linha[0].ToString());
			alvo.DataSource = retornar;
			Conector.fechar();
		}

		/// <summary>
		/// Método de "login"
		/// </summary>
		/// <param name="l">O usuário</param>
		/// <param name="p">A senha</param>
		public static bool login(string l, string p) {
			if(Conector._conn == null) Conector.conectar();
			SqlCommand query = new SqlCommand(string.Format("SELECT * FROM tbCred WHERE (credUsr = '{0}') AND (credPass = '{1}');",l,p), Conector._conn);
			SqlDataAdapter adapt = new SqlDataAdapter(query);
			DataTable resultados = new DataTable();
			adapt.Fill(resultados);
			Conector.fechar();
			return resultados.Rows.Count==1;
		}

		public static void cadastrar(string dept,string l,string p) {
			if(Conector._conn == null) Conector.conectar();
			new SqlCommand(string.Format("INSERT INTO tbCred(idDept,credUsr,credPass) VALUES ('{0}','{1}','{2}')",dept,l,p), Conector._conn)
				.ExecuteNonQuery();
		}

	}
}
