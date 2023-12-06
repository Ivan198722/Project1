using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollTrackingApp1
{
    public partial class PayrollTrackingApp : Form
    {
        public PayrollTrackingApp()
        {
            InitializeComponent();
        }

        private void PayrollTrackingApp_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (!Application.OpenForms.OfType<Regisration>().Any())

                new Regisration().Show();
        }

        private void employeeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Application.OpenForms.OfType<Employee_Information>().Any())

                new Employee_Information().Show();
        }

        private void positionalRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<Position_Rates>().Any())
                new Position_Rates ().Show();
        }

        private void bonusSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<Bonus_Settings>().Any())
                new Bonus_Settings().Show();
        }

        private void jenuaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Application.OpenForms.OfType<January>().Any())
                new January().Show();
        }

        private void febrToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Application.OpenForms.OfType<February>().Any())
                new February().Show();
        }
    }
}
