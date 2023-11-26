using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollTrackingApp1
{
    public partial class Employee_Information : Form
    {
       DataBase dB = new DataBase();
        public Employee_Information()
        {
            InitializeComponent();

            dataGridView1.Columns[0].Width = 30;
        }

        private void Employee_Information_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payrollTrackingDBDataSet1.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter1.Fill(this.payrollTrackingDBDataSet1.Employee);
          

        }
  
        private void Add_button_Click(object sender, EventArgs e)
        {

            using (PayrollTrackingDBEntities1 entities1 = new PayrollTrackingDBEntities1())
            {

                int index = dataGridView1.SelectedRows[0].Index;

                if (dataGridView1.Rows[index].Cells[0].Value == null ||
                   dataGridView1.Rows[index].Cells[1].Value == null ||
                   dataGridView1.Rows[index].Cells[2].Value == null ||
                   dataGridView1.Rows[index].Cells[3].Value == null ||
                   dataGridView1.Rows[index].Cells[4].Value == null ||
                   dataGridView1.Rows[index].Cells[5].Value == null)
                {
                    MessageBox.Show("Not all data is entered!");
                    return;
                }


                string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                string FName = dataGridView1.Rows[index].Cells[1].Value.ToString();
                string LName = dataGridView1.Rows[index].Cells[2].Value.ToString();
                string Age = dataGridView1.Rows[index].Cells[3].Value.ToString();
                string Position = dataGridView1.Rows[index].Cells[4].Value.ToString();
                string Phone = dataGridView1.Rows[index].Cells[5].Value.ToString();



                try
                {

                    // Выполянем запрос к БД
                    //dbconnection.Open();//открываем соеденение
                    string query = "INSERT INTO Employee Values ('" + FName + "', '" + LName + "'," + Age + "," + Position + ",' " + Phone + " ') " +
                  "insert into [January_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [January_2023]"+
                  "insert into [February_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [February_2023]"+
                  "insert into [March_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [March_2023]" +
                  "insert into [April_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [April_2023]" +
                  "insert into [May_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [May_2023]" +
                  "insert into [June_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [June_2023]" +
                  "insert into [July_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [July_2023]" +
                  "insert into [August_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [August_2023]" +
                  "insert into [September_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [September_2023]" +
                  "insert into [October_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [October_2023]" +
                  "insert into [November_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [November_2023]" +
                  "insert into [December_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [December_2023]" ;//строка запроса


                    SqlCommand dbcommand = new SqlCommand(query, dB.GetConnection());                                    //string query = "Delete from Person where id="+id+"";строка удаления данных
                    dB.GetConnection().Open();
                    dbcommand.ExecuteNonQuery();
                      //  MessageBox.Show("Data added!");

                  
                }
                catch (Exception ex)
                {
                    //throw ex;
                    MessageBox.Show($"Message: {ex.Message}", "Exception Thrown!");
                }
                finally
                {
                    this.employeeTableAdapter1.Fill(this.payrollTrackingDBDataSet1.Employee);
                }
               
           }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            using (PayrollTrackingDBEntities1 entities1 = new PayrollTrackingDBEntities1())
            {
                if (dataGridView1.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Choose one line!", "Attention!");
                    return;
                }

                int index = dataGridView1.SelectedRows[0].Index;

                if (dataGridView1.Rows[index].Cells[0].Value == null ||
                   dataGridView1.Rows[index].Cells[1].Value == null ||
                   dataGridView1.Rows[index].Cells[2].Value == null ||
                   dataGridView1.Rows[index].Cells[3].Value == null ||
                   dataGridView1.Rows[index].Cells[4].Value == null ||
                   dataGridView1.Rows[index].Cells[5].Value == null)
                {
                    MessageBox.Show("Not all data is entered!");
                    return;
                }


                string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                string FName = dataGridView1.Rows[index].Cells[1].Value.ToString();
                string LName = dataGridView1.Rows[index].Cells[2].Value.ToString();
                string Age = dataGridView1.Rows[index].Cells[3].Value.ToString();
                string Position = dataGridView1.Rows[index].Cells[4].Value.ToString();
                string Phone = dataGridView1.Rows[index].Cells[5].Value.ToString();



                try
                {

                    // Выполянем запрос к БД
                    //dbconnection.Open();//открываем соеденение
                    string query = "UPDATE Employee set FName='" + FName + "' , LName='" + LName + "', Age=" + Age + ",IdPosition=" + Position + ", Phone= '"+Phone+"'  WHERE Id=" + id +"" +
                        " UPDATE  [January_2023] set  EmployeeName = concat('"+FName+"',' ','"+LName+"') where IdEmployee="+id+""+
                        "UPDATE  [February_2023] set  EmployeeName = concat('"+FName+"',' ','"+LName+"') where IdEmployee="+id+ "" +
                        "UPDATE  [March_2023] set  EmployeeName = concat('"+FName+"',' ','"+LName+"') where IdEmployee="+id+""+
                        "UPDATE[April_2023] set EmployeeName = concat('"+FName+"', ' ', '"+LName+"') where IdEmployee = "+id+""+
                        "UPDATE[May_2023] set EmployeeName = concat('"+FName+"', ' ', '"+LName+"') where IdEmployee = "+id+""+
                       " UPDATE[June_2023] set EmployeeName = concat('"+FName+"', ' ', '"+LName+"') where IdEmployee = "+id+""+
                       "UPDATE[July_2023] set EmployeeName = concat('"+FName+"', ' ', '"+LName+"') where IdEmployee = "+id+""+
                      " UPDATE  [August_2023] set  EmployeeName = concat('"+FName+"',' ','"+LName+"') where IdEmployee="+id+""+
                      " UPDATE  [September_2023] set  EmployeeName = concat('" + FName + "',' ','" + LName + "') where IdEmployee=" + id + "" +
                      " UPDATE  [October_2023] set  EmployeeName = concat('" + FName + "',' ','" + LName + "') where IdEmployee=" + id + "" +
                      " UPDATE  [November_2023] set  EmployeeName = concat('" + FName + "',' ','" + LName + "') where IdEmployee=" + id + "" +
                      " UPDATE  [December_2023] set  EmployeeName = concat('" + FName + "',' ','" + LName + "') where IdEmployee=" + id ;//строка запроса


                    SqlCommand dbcommand = new SqlCommand(query, dB.GetConnection());                                    //string query = "Delete from Person where id="+id+"";строка удаления данных
                    dB.GetConnection().Open();
                    dbcommand.ExecuteNonQuery();
                    //MessageBox.Show("Data added!");


                }
                catch (Exception ex)
                {
                    //throw ex;
                    MessageBox.Show($"Message: {ex.Message}", "Exception Thrown!");
                }
                finally
                {
                    this.employeeTableAdapter1.Fill(this.payrollTrackingDBDataSet1.Employee);
                }

            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            using (PayrollTrackingDBEntities1 entities1 = new PayrollTrackingDBEntities1())
            {
                //Проверим количество выбранных строк
                if (dataGridView1.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Choose one line!", "Attention!");
                    return;
                }

                //Запомним выбранную строку
                int index = dataGridView1.SelectedRows[0].Index;

                // Проверим данные в таблицы
                if (dataGridView1.Rows[index].Cells[0].Value == null)
                {
                    MessageBox.Show("Not all data is entered!");
                    return;
                }

                // Считаем данные
                string id = dataGridView1.Rows[index].Cells[0].Value.ToString();

                

                try
                {
                    // Выполянем запрос к БД
                                                              // открываем соеденение
                    string query = "DELETE FROM Employee WHERE id = " + id;       // строка запроса

                    SqlCommand dbcommand = new SqlCommand(query, dB.GetConnection());                                    //string query = "Delete from Person where id="+id+"";строка удаления данных
                    dB.GetConnection().Open();
                    DialogResult result = MessageBox.Show("Deleting will permanently remove information about this employee. Continue?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    { 
                        dbcommand.ExecuteNonQuery();
                        // Код для удаления информации о сотруднике
                        Console.WriteLine("Employee information deleted.");
                    }
                    else
                    {
                        // Код, который выполнится при выборе "Отмена"
                        Console.WriteLine("Deletion canceled.");
                    }
                  
                }
                catch (Exception ex)
                {
                    //throw ex;
                    MessageBox.Show($"Message: {ex.Message}", "Exception Thrown!");
                }
                finally
                {
                    // Закрываем соеденение с БД
                    this.employeeTableAdapter1.Fill(this.payrollTrackingDBDataSet1.Employee);
                }
            }
        }
    }
}
