using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace basicIO {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			Conector.queryDept(cmbDepto);
			Program.log("Aberto");
		}

		private void depto(object sender, EventArgs e) {
			Conector.query(cmbDepto.SelectedValue.ToString(), cmbUsr);
			Program.log("carregados departamentos");
		}

		private void login(object sender, EventArgs e) {
			if (Conector.login(cmbUsr.SelectedItem.ToString(), txtPass.Text)) MessageBox.Show("Logado!");
			else MessageBox.Show("Erro: inválido. ");
			Program.log("login");
		}

		private void cadastrar(object sender, EventArgs e) {
			Conector.cadastrar(cmbDepto.SelectedItem.ToString(), cmbUsr.Text, txtPass.Text.ToString());
			MessageBox.Show("feito");
			Conector.query(cmbDepto.SelectedValue.ToString(), cmbUsr);
			txtPass.Text = "";
			Program.log("cadastro");
		}
	}
}
