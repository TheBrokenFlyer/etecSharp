using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador;

namespace carro {
	public partial class frmView : Form {
		public frmView() {
			InitializeComponent();
			Conector.queryFab(cmbmarca);
			Conector.query(dgv);
		}

		private void pesquisar(object sender, EventArgs e) {
			Conector.query(dgv,
				txtmodelo.Text.Equals("")?null:txtmodelo.Text,
				cmbmarca.SelectedText.Equals("")?null:cmbmarca.SelectedText,
				mtxtano.Text.Equals("")?-1:int.Parse(mtxtano.Text));
		}

		private void deletar(object sender, EventArgs e) {
			if (lblVal.Text.Equals("")) {
				MessageBox.Show("Você precisa selecionar um valor");
				return;
			} else Conector.del(dgv, int.Parse(lblVal.Text));
			Conector.query(dgv);
		}

		private void adicionar(object sender, EventArgs e) {
			Conector.inserir(txtmodelo.Text, cmbmarca.Text, mtxtano.Text.Length>0?int.Parse(mtxtano.Text):-1);
			MessageBox.Show("Inserido");
			Conector.query(dgv);
			lblVal.Text = "----";
		}

		private void click(object sender, EventArgs e) {
			DataGridViewSelectedRowCollection select = dgv.SelectedRows;
			lblVal.Text = (select.Count>0?
				select[0].Cells["ID"].Value.ToString()
				:("----"))
				+ "";
		}
	}
}
