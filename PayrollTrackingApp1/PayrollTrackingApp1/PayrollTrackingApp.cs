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

            if (!Application.OpenForms.OfType<Employees>().Any())

                new Employees().Show();
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

        private void marchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<March>().Any())
                new March().Show();
        }

        private void aprilToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Application.OpenForms.OfType<April>().Any())
                new April().Show();
        }

        private void juneToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Application.OpenForms.OfType<June>().Any())
                new June().Show();
        }

        private void mayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<May>().Any())
                new May().Show();
        }

        private void julyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<July>().Any())
                new July().Show();
        }

        private void augustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<August>().Any())
                new August().Show();
        }

        private void septemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Application.OpenForms.OfType<September>().Any())
                new September().Show();
        }

        private void octoberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<October>().Any())
                new October().Show();
        }

        private void novemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<November>().Any())
                new November().Show();
        }

        private void decemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<December>().Any())
                new December().Show();
        }
    }
}
