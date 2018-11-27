using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Controlador {
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
			if(Conector._conn==null)
				Conector._conn=new SqlConnection(Conector._connString);
			Conector._conn.Open();
		}

		public static void fechar() {
			if(Conector._conn != null)
				Conector._conn.Close();
			else return;
			Conector._conn = null;
		}

		public static void query(DataGridView alvo=null, string nome=null, string marca=null, int ano=-1) {
			if(alvo == null) throw new ArgumentNullException("alvo não pode ser nulo");
			if(Conector._conn == null) Conector.conectar();
			SqlCommand query = new SqlCommand(string.Format("SELECT idcarro as [ID],carronome AS [Nome],carrofabricante AS [Fabricante],carroano AS [Ano] FROM tbcarro {3}{0}{1}{2};",
				nome==null?"" :"(carronome LIKE '%"+nome+"%')",
				marca==null?"":((nome!=null)?             " AND ":"") +"(carrofabricante LIKE '%"+marca+"%')",
				ano<0?"":      ((nome!=null||marca!=null)?" AND ":"") +"(carroano = "+ano+")",
				(nome!=null||marca!=null||ano>-1)?"WHERE ":""),
				Conector._conn);
			SqlDataAdapter adapt = new SqlDataAdapter(query);
			DataTable resultados = new DataTable();
			adapt.Fill(resultados);
			alvo.DataSource = resultados;
			Conector.fechar();
		}

		public static void queryFab(ComboBox alvo) {
			if(Conector._conn == null) Conector.conectar();
			SqlCommand query = new SqlCommand("SELECT fabricantenome FROM tbfabricante", Conector._conn);
			SqlDataAdapter adapt = new SqlDataAdapter(query);
			DataTable resultados = new DataTable();
			adapt.Fill(resultados);
			Conector.fechar();
			List<string> retornar = new List<string>(0);
			foreach (DataRow linha in resultados.Rows) retornar.Add(linha[0].ToString());
			alvo.DataSource = retornar;
		}

		public static void inserir(string modelo, string fabricante, int ano) {
			if(Conector._conn == null) Conector.conectar();
			new SqlCommand(string.Format("INSERT INTO tbcarro(carronome,carrofabricante,carroano) VALUES ('{0}','{1}',{2})", modelo, fabricante, ano>0?ano.ToString():null), Conector._conn)
				.ExecuteNonQuery();
			Conector.fechar();
		}

		public static void del(DataGridView dgv, int id) {
			if(Conector._conn == null) Conector.conectar();
			new SqlCommand("DELETE FROM tbcarro WHERE (idcarro = "+id+ ")", Conector._conn)
				.ExecuteNonQuery();
			Conector.fechar();
		}
	}
}
