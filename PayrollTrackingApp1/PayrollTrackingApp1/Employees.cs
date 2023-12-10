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
    public partial class Employees : Form
    {
        DataBase dB = new DataBase();
        public Employees()
        {
            InitializeComponent();
            dataGridView1.Columns[0].Width = 30;// Ustawienie szerokości kolumn w DataGridView.
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 50;
        }

        private void Emplloees_Load(object sender, EventArgs e)
        {
            
            this.employeeTableAdapter.Fill(this.payrollTrackingDBDataSet3.Employee);

        }

        private void add_button_Click(object sender, EventArgs e)
        {

            // Pobranie indeksu zaznaczonego wiersza w DataGridView.
            int index = dataGridView1.SelectedRows[0].Index;

            // Sprawdzenie, czy wszystkie dane są wprowadzone dla zaznaczonego wiersza.
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
               dataGridView1.Rows[index].Cells[1].Value == null ||
               dataGridView1.Rows[index].Cells[2].Value == null ||
               dataGridView1.Rows[index].Cells[3].Value == null ||
               dataGridView1.Rows[index].Cells[4].Value == null ||
               dataGridView1.Rows[index].Cells[5].Value == null)
            {
                // Wyświetlenie komunikatu o braku wprowadzonych danych.
                MessageBox.Show("Not all data is entered!");
                return;
            }

            // Pobranie danych z zaznaczonego wiersza do zmiennych.
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string FName = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string LName = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string Age = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string Position = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string Phone = dataGridView1.Rows[index].Cells[5].Value.ToString();


            try
            {

                // Wykonujemy zapytanie do bazy danych
                string query = "INSERT INTO Employee Values ('" + FName + "', '" + LName + "'," + Age + "," + Position + ",' " + Phone + " ') " +
              "insert into [January_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [January_2023]" +
              "insert into [February_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [February_2023]" +
              "insert into [March_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [March_2023]" +
              "insert into [April_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [April_2023]" +
              "insert into [May_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [May_2023]" +
              "insert into [June_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [June_2023]" +
              "insert into [July_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [July_2023]" +
              "insert into [August_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [August_2023]" +
              "insert into [September_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [September_2023]" +
              "insert into [October_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [October_2023]" +
              "insert into [November_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [November_2023]" +
              "insert into [December_2023] (IdEmployee, EmployeeName) select Id, concat(FName, ' ', LName) from Employee  except select IdEmployee, EmployeeName from [December_2023]";// Łańcuch zapytania do bazy danych


                                                                          // Tworzymy obiekt SqlCommand z zapytaniem i podłączamy go do połączenia z bazą danych
                SqlCommand dbCommand = new SqlCommand(query, dB.GetConnection());
 
                                                      // Otwieramy połączenie z bazą danych
                dB.GetConnection().Open();

                                                   // Wykonujemy niezależne od rodzaju zapytania (insert, update, delete)
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                                                        // Obsługa wyjątku, wyświetlamy komunikat z informacją o błędzie
                MessageBox.Show($"Message: {ex.Message}", "Exception Thrown!");
            }
            finally
            {
                                                               // Odświeżamy dane w DataGridView, niezależnie od tego, czy wystąpił błąd czy nie
                this.employeeTableAdapter.Fill(this.payrollTrackingDBDataSet3.Employee);

                                                                  // Zamykamy połączenie z bazą danych
                dB.GetConnection().Close();
            }

        }

        private void edit_button_Click(object sender, EventArgs e)
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

                // Wykonujemy zapytanie do bazy danych
                string query = "UPDATE Employee set FName='" + FName + "' , LName='" + LName + "', Age=" + Age + ",IdPosition=" + Position + ", Phone= '" + Phone + "'  WHERE Id=" + id + "" +
                    " UPDATE  [January_2023] set  EmployeeName = concat('" + FName + "',' ','" + LName + "') where IdEmployee=" + id + "" +
                    "UPDATE  [February_2023] set  EmployeeName = concat('" + FName + "',' ','" + LName + "') where IdEmployee=" + id + "" +
                    "UPDATE  [March_2023] set  EmployeeName = concat('" + FName + "',' ','" + LName + "') where IdEmployee=" + id + "" +
                    "UPDATE[April_2023] set EmployeeName = concat('" + FName + "', ' ', '" + LName + "') where IdEmployee = " + id + "" +
                    "UPDATE[May_2023] set EmployeeName = concat('" + FName + "', ' ', '" + LName + "') where IdEmployee = " + id + "" +
                   " UPDATE[June_2023] set EmployeeName = concat('" + FName + "', ' ', '" + LName + "') where IdEmployee = " + id + "" +
                   "UPDATE[July_2023] set EmployeeName = concat('" + FName + "', ' ', '" + LName + "') where IdEmployee = " + id + "" +
                  " UPDATE  [August_2023] set  EmployeeName = concat('" + FName + "',' ','" + LName + "') where IdEmployee=" + id + "" +
                  " UPDATE  [September_2023] set  EmployeeName = concat('" + FName + "',' ','" + LName + "') where IdEmployee=" + id + "" +
                  " UPDATE  [October_2023] set  EmployeeName = concat('" + FName + "',' ','" + LName + "') where IdEmployee=" + id + "" +
                  " UPDATE  [November_2023] set  EmployeeName = concat('" + FName + "',' ','" + LName + "') where IdEmployee=" + id + "" +
                  " UPDATE  [December_2023] set  EmployeeName = concat('" + FName + "',' ','" + LName + "') where IdEmployee=" + id;// Łańcuch zapytania do bazy danych


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
                this.employeeTableAdapter.Fill(this.payrollTrackingDBDataSet3.Employee);
                dB.GetConnection().Close();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

            // Sprawdźmy liczbę wybranych wierszy
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Choose one line!", "Attention!");
                return;
            }

            // Zapamiętajmy wybrany wiersz
            int index = dataGridView1.SelectedRows[0].Index;

            // Sprawdźmy dane w tabeli
            if (dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Not all data is entered!");
                return;
            }

           
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();



            try
            {
                
                string query = "DELETE FROM Employee WHERE id = " + id;       

                SqlCommand dbcommand = new SqlCommand(query, dB.GetConnection());                                   
                dB.GetConnection().Open();
                DialogResult result = MessageBox.Show("Deleting will permanently remove information about this employee. Continue?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    dbcommand.ExecuteNonQuery();
                 
                    Console.WriteLine("Employee information deleted.");
                }
                else
                {
                 
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
                              this.employeeTableAdapter.Fill(this.payrollTrackingDBDataSet3.Employee);
                dB.GetConnection().Close();
            }
        }
    }
}
