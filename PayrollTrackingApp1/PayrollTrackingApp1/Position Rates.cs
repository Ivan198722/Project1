using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollTrackingApp1
{
    public partial class Position_Rates : Form
    {
        
        DataBase dB = new DataBase();
        public Position_Rates()
        {
            InitializeComponent();
        }

        private void Position_Rates_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "payrollTrackingDBDataSet5.PositionsAndPay". При необходимости она может быть перемещена или удалена.
            this.positionsAndPayTableAdapter.Fill(this.payrollTrackingDBDataSet5.PositionsAndPay);

            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox textBox)
            {
                textBox.KeyPress -= TextBox_KeyPress; // Убедимся, что обработчик не добавлен несколько раз
                textBox.KeyPress += TextBox_KeyPress;
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // Заменяем введенную точку на запятую
                e.KeyChar = ',';
            }
        }

       
            private void add_button_Click(object sender, EventArgs e)
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
            string hourlySalary = dataGridView1.Rows[index].Cells[2].Value.ToString() ;
            
            if(hourlySalary==string.Empty)
            { hourlySalary="0"; }
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
                this.positionsAndPayTableAdapter.Fill(this.payrollTrackingDBDataSet5.PositionsAndPay);
                dB.GetConnection().Close();
            }
        }

        private void update_button_Click(object sender, EventArgs e)
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

           //dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
          string  hourlySalary = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            hourlySalary = hourlySalary.Replace(',', '.');
           
            // string hourlySalary=  dataGridView1.Rows[rowIndex].Cells[2].ValueType = GetType();

            //string formattedSalary = hourlySalary.ToString("0.##", CultureInfo.InvariantCulture);



            try
            {
                // Выполняем запрос к БД
                string query = "UPDATE PositionsAndPay SET [HourlySalary($)] = "+hourlySalary+" WHERE ID = " + id;

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
                this.positionsAndPayTableAdapter.Fill(this.payrollTrackingDBDataSet5.PositionsAndPay);
                dB.GetConnection().Close();
            }
        }

       
    }
}
