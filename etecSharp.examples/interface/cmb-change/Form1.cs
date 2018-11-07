using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmb0.DataSource = this.itens;
        }

        string[] itens = {"Pastéis","Cores","Cidades"};

        string[][] tipos = {
            new string[] {"Queijo","Carne","Pizza"},
            new string[] {"Amarelo","Verde","Vermelho"},
            new string[] {"São Paulo","Rio","Dallas","New Home","Snowdin","Possum Springs"}
        };

        private void mudar(object sender, EventArgs e)
        {
            cmb1.DataSource = tipos[cmb0.SelectedIndex];
        }
    }
}
