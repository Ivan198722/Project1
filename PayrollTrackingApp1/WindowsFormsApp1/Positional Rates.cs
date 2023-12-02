using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace PayrollTrackingApp1
{
    public partial class Positional_Rates : Form
    {
        DataBase dB = new DataBase();
        public Positional_Rates()
        {
            InitializeComponent();
        }

        private void Positional_Rates_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payrollTrackingDBDataSet2.PositionsAndPay". При необходимости она может быть перемещена или удалена.
            this.positionsAndPayTableAdapter.Fill(this.payrollTrackingDBDataSet2.PositionsAndPay);

        }

        private void refresh_button_Click(object sender, EventArgs e)
        {

            using (PayrollTrackingDBEntities1 entities1 = new PayrollTrackingDBEntities1())
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
                string PositionName = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                string hourlySalary = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();

                try
                {
                    // Выполняем запрос к БД
                    string query = "UPDATE PositionsAndPay SET [HourlySalary($)] = " + hourlySalary + " WHERE ID = " + id;

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
                    this.positionsAndPayTableAdapter.Fill(this.payrollTrackingDBDataSet2.PositionsAndPay);
                }

            }
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            using (PayrollTrackingDBEntities1 dBEntities1 = new PayrollTrackingDBEntities1())
            {
                int index = dataGridView1.SelectedRows[0].Index;

                if (dataGridView1.Rows[index].Cells[0].Value == null ||
                   dataGridView1.Rows[index].Cells[1].Value == null ||
                   dataGridView1.Rows[index].Cells[2].Value == null)

                {
                    MessageBox.Show("Not all data is entered!");
                    return;
                }


                string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                string PositionName = dataGridView1.Rows[index].Cells[1].Value.ToString();
                string hourlySalary = dataGridView1.Rows[index].Cells[2].Value.ToString();

                try
                {

                    // Выполянем запрос к БД
                    //dbconnection.Open();//открываем соеденение
                    string query = "INSERT INTO  PositionsAndPay   Values ('" + PositionName + "',  " + hourlySalary + ")";

                    SqlCommand dbcommand = new SqlCommand(query, dB.GetConnection());
                    dB.GetConnection().Open();
                    dbcommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    //throw ex;
                    MessageBox.Show($"Message: {ex.Message}", "Exception Thrown!");
                }
                finally
                {
                    this.positionsAndPayTableAdapter.Fill(this.payrollTrackingDBDataSet2.PositionsAndPay);
                }
            }
        }
    }
}
