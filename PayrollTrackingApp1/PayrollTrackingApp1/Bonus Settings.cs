using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollTrackingApp1
{
    public partial class Bonus_Settings : Form
    {
        DataBase dB = new DataBase();
        public Bonus_Settings()
        {
            InitializeComponent();
        }

        private void Bonus_Settings_Load(object sender, EventArgs e)
        {
          
            this.salaryBonusesTableAdapter.Fill(this.payrollTrackingDBDataSet6.SalaryBonuses);
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
        }

        private void aplly_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 1)
            {
                MessageBox.Show("Choose one cell!", "Attention!");
                return;
            }

            int columnIndex = dataGridView1.SelectedCells[0].ColumnIndex;
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

            if (dataGridView1.Rows[rowIndex].Cells[0].Value == null ||
                dataGridView1.Rows[rowIndex].Cells[1].Value == null ||
                dataGridView1.Rows[rowIndex].Cells[2].Value == null)
            {
                MessageBox.Show("Not all data is entered!");
                return;
            }

            string id = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            string bonusName = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();

            // Pobieramy wartość procentową z komórki i zamieniamy ewentualną kropkę na przecinek
            string percentage = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            percentage = percentage.Replace(',', '.');

           


            try
            {
                // Wykonujemy zapytanie do bazy danych
                string query = "UPDATE SalaryBonuses SET [Percentage %] = " + percentage + " WHERE BonusID = " + id;

                using (SqlCommand dbcommand = new SqlCommand(query, dB.GetConnection()))
                {
                    dB.GetConnection().Open();
                    dbcommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}", "Exception Thrown!");
            }
            finally
            {
                this.salaryBonusesTableAdapter.Fill(this.payrollTrackingDBDataSet6.SalaryBonuses);
                dB.GetConnection().Close();
            }

        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox textBox)
            {
                textBox.KeyPress -= TextBox_KeyPress; // Upewnijmy się, że obsługiwacz nie został dodany wielokrotnie
                textBox.KeyPress += TextBox_KeyPress;
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // Zamieniamy wprowadzoną kropkę na przecinek
                e.KeyChar = ',';
            }
        }

    }
}
