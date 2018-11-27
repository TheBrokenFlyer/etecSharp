using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace carro {
	static class Program {
		public static frmView view = null;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Program.view = new frmView();
			Application.Run(Program.view);
		}
	}
}
