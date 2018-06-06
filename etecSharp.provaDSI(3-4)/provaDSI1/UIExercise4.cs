using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIMixedExercises {
    public partial class UIExercise4 : Form {
        public UIExercise4() {
            InitializeComponent();
        }

        private void closeWindow(object sender, FormClosedEventArgs e) {
            UIMain.ex4 = null;
        }

        private void update(object sender, EventArgs e) {
                 if (listMonth.SelectedIndex == 0) {lblMonth.Text = "January";}
            else if (listMonth.SelectedIndex == 1) {lblMonth.Text = "Febuary";}
            else if (listMonth.SelectedIndex == 2) {lblMonth.Text = "March";}
            else if (listMonth.SelectedIndex == 3) {lblMonth.Text = "April";}
            else if (listMonth.SelectedIndex == 4) {lblMonth.Text = "May";}
            else if (listMonth.SelectedIndex == 5) {lblMonth.Text = "June";}
            else if (listMonth.SelectedIndex == 6) {lblMonth.Text = "July";}
            else if (listMonth.SelectedIndex == 7) {lblMonth.Text = "August";}
            else if (listMonth.SelectedIndex == 8) {lblMonth.Text = "September";}
            else if (listMonth.SelectedIndex == 9) {lblMonth.Text = "October";}
            else if (listMonth.SelectedIndex == 10) {lblMonth.Text = "November";}
            else if (listMonth.SelectedIndex == 11) {lblMonth.Text = "December";}
        }
    }
}
