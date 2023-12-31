﻿using System;
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
    public partial class March : Form
    {
        DataBase dB = new DataBase();
        public March()
        {
            InitializeComponent();
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[2].Width = 90;

            for (int i = 3; i < dataGridView1.ColumnCount; i += 2)
            { dataGridView1.Columns[i].Width = 35; }
            for (int i = 4; i < dataGridView1.ColumnCount; i += 2)
            {
                dataGridView1.Columns[i].Width = 0;
                dataGridView1.Columns[i].ReadOnly = true;
                // Uncomment the following line after testing
                //dataGridView1.Columns[i].Visible = false;
            }
            dataGridView1.Columns[65].Width = 55;
        }

        private void March_Load(object sender, EventArgs e)
        {
          
            this.march_2023TableAdapter.Fill(this.payrollTrackingDBDataSet13.March_2023);
            this.WindowState = FormWindowState.Maximized;
        }

        class Salary : SalaryCalculator
        {
            internal override IQueryable<object> GetSalaryData(int id)
            {
                var query = from pos in _dbEntities.PositionsAndPays
                            join emp in _dbEntities.Employees on pos.Id equals emp.IdPosition
                            join month in _dbEntities.March_2023 on emp.Id equals month.IdEmployee
                            where month.Id == id
                            from bon in _dbEntities.SalaryBonuses
                            where bon.BonusID == 1
                            select new
                            {
                                pos.HourlySalary___,
                                bon.Percentage__
                            };

                return query;

            }
            internal override IQueryable<object> GetSalaryData_Weekend(int id)
            {
                var query = from pos in _dbEntities.PositionsAndPays
                            join emp in _dbEntities.Employees on pos.Id equals emp.IdPosition
                            join month in _dbEntities.March_2023 on emp.Id equals month.IdEmployee
                            where month.Id == id
                            from bon in _dbEntities.SalaryBonuses
                            where bon.BonusID == 2
                            select new
                            {
                                pos.HourlySalary___,
                                bon.Percentage__
                            };

                return query;

            }

            internal override IQueryable<object> GetSalaryData_Month(int id)
            {

                var query = from month in _dbEntities.March_2023
                            where month.Id == id
                            select new
                            {
                                TotalMoney = month.C1DailiSalary + month.C2DailiSalary + month.C3DailiSalary + month.C4DailiSalary + month.C5DailiSalary + month.C6DailiSalary + month.C7DailiSalary
                                + month.C8DailiSalary + month.C9DailiSalary + month.C10DailiSalary + month.C11DailiSalary + month.C12DailiSalary + month.C13DailiSalary + month.C14DailiSalary
                                + month.C15DailiSalary + month.C16DailiSalary + month.C17DailiSalary + month.C18DailiSalary + month.C19DailiSalary + month.C20DailiSalary + month.C21DailiSalary
                                + month.C22DailiSalary + month.C23DailiSalary + month.C24DailiSalary + month.C25DailiSalary + month.C26DailiSalary + month.C27DailiSalary + month.C28DailiSalary
                                + month.C29DailiSalary + month.C30DailiSalary + month.C31DailiSalary
                            };
                return query;
            }
        }
        Salary salary = new Salary();

        private void add_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 1)
            {
                MessageBox.Show("Choose one cell!", "Attention!");
                return;
            }

            int columnIndex = dataGridView1.SelectedCells[0].ColumnIndex;
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;


            string id = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            string idEmployee = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            string employeeName = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            string day1 = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            string day1_salary = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            string day2 = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            string day2_salary = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            string day3 = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            string day3_salary = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
            string day4 = dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
            string day4_salary = dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
            string day5 = dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();
            string day5_salary = dataGridView1.Rows[rowIndex].Cells[12].Value.ToString();
            string day6 = dataGridView1.Rows[rowIndex].Cells[13].Value.ToString();
            string day6_salary = dataGridView1.Rows[rowIndex].Cells[14].Value.ToString();
            string day7 = dataGridView1.Rows[rowIndex].Cells[15].Value.ToString();
            string day7_salary = dataGridView1.Rows[rowIndex].Cells[16].Value.ToString();
            string day8 = dataGridView1.Rows[rowIndex].Cells[17].Value.ToString();
            string day8_salary = dataGridView1.Rows[rowIndex].Cells[18].Value.ToString();
            string day9 = dataGridView1.Rows[rowIndex].Cells[19].Value.ToString();
            string day9_salary = dataGridView1.Rows[rowIndex].Cells[20].Value.ToString();
            string day10 = dataGridView1.Rows[rowIndex].Cells[21].Value.ToString();
            string day10_salary = dataGridView1.Rows[rowIndex].Cells[22].Value.ToString();
            string day11 = dataGridView1.Rows[rowIndex].Cells[23].Value.ToString();
            string da11_salary = dataGridView1.Rows[rowIndex].Cells[24].Value.ToString();
            string day12 = dataGridView1.Rows[rowIndex].Cells[25].Value.ToString();
            string day12_salary = dataGridView1.Rows[rowIndex].Cells[26].Value.ToString();
            string day13 = dataGridView1.Rows[rowIndex].Cells[27].Value.ToString();
            string day13_salary = dataGridView1.Rows[rowIndex].Cells[28].Value.ToString();
            string day14 = dataGridView1.Rows[rowIndex].Cells[29].Value.ToString();
            string day14_salary = dataGridView1.Rows[rowIndex].Cells[30].Value.ToString();
            string day15 = dataGridView1.Rows[rowIndex].Cells[31].Value.ToString();
            string day15_salary = dataGridView1.Rows[rowIndex].Cells[32].Value.ToString();
            string day16 = dataGridView1.Rows[rowIndex].Cells[33].Value.ToString();
            string day16_salary = dataGridView1.Rows[rowIndex].Cells[34].Value.ToString();
            string day17 = dataGridView1.Rows[rowIndex].Cells[35].Value.ToString();
            string day17_salary = dataGridView1.Rows[rowIndex].Cells[36].Value.ToString();
            string day18 = dataGridView1.Rows[rowIndex].Cells[37].Value.ToString();
            string day18_salary = dataGridView1.Rows[rowIndex].Cells[38].Value.ToString();
            string day19 = dataGridView1.Rows[rowIndex].Cells[39].Value.ToString();
            string day19_salary = dataGridView1.Rows[rowIndex].Cells[40].Value.ToString();
            string day20 = dataGridView1.Rows[rowIndex].Cells[41].Value.ToString();
            string day20_salary = dataGridView1.Rows[rowIndex].Cells[42].Value.ToString();
            string day21 = dataGridView1.Rows[rowIndex].Cells[43].Value.ToString();
            string day21_salary = dataGridView1.Rows[rowIndex].Cells[44].Value.ToString();
            string day22 = dataGridView1.Rows[rowIndex].Cells[45].Value.ToString();
            string day22_salary = dataGridView1.Rows[rowIndex].Cells[46].Value.ToString();
            string day23 = dataGridView1.Rows[rowIndex].Cells[47].Value.ToString();
            string day23_salary = dataGridView1.Rows[rowIndex].Cells[48].Value.ToString();
            string day24 = dataGridView1.Rows[rowIndex].Cells[49].Value.ToString();
            string day24_salary = dataGridView1.Rows[rowIndex].Cells[50].Value.ToString();
            string day25 = dataGridView1.Rows[rowIndex].Cells[51].Value.ToString();
            string day25_salary = dataGridView1.Rows[rowIndex].Cells[52].Value.ToString();
            string day26 = dataGridView1.Rows[rowIndex].Cells[53].Value.ToString();
            string day26_salary = dataGridView1.Rows[rowIndex].Cells[54].Value.ToString();
            string day27 = dataGridView1.Rows[rowIndex].Cells[55].Value.ToString();
            string day27_salary = dataGridView1.Rows[rowIndex].Cells[56].Value.ToString();
            string day28 = dataGridView1.Rows[rowIndex].Cells[57].Value.ToString();
            string day28_salary = dataGridView1.Rows[rowIndex].Cells[58].Value.ToString();
            string day29 = dataGridView1.Rows[rowIndex].Cells[59].Value.ToString();
            string day29_salary = dataGridView1.Rows[rowIndex].Cells[60].Value.ToString();
            string day30 = dataGridView1.Rows[rowIndex].Cells[61].Value.ToString();
            string day30_salary = dataGridView1.Rows[rowIndex].Cells[62].Value.ToString();
            string day31 = dataGridView1.Rows[rowIndex].Cells[63].Value.ToString();
            string day31_salary = dataGridView1.Rows[rowIndex].Cells[64].Value.ToString();
            string totalSalary = dataGridView1.Rows[rowIndex].Cells[65].Value.ToString();

            try
            {
                
                string query = "UPDATE March_2023 SET [1]=" + day1 + ",[1DailiSalary]=" +salary.WorkDaySalary(day1, id) + ",[2]=" + day2 + ",[2DailiSalary]=" + salary.WorkDaySalary(day2, id) + "," +
                    "[3]=" + day3 + ",[3DailiSalary]=" + salary.WorkDaySalary(day3, id) + ",[4]=" + day4 + ",[4DailiSalary]=" + salary.WeekendDaySalary(day4, id) + ",[5]=" + day5 + ",[5DailiSalary]=" + salary.WeekendDaySalary(day5, id) + "," +
                    "[6]=" + day6 + ",[6DailiSalary]=" + salary.WorkDaySalary(day6, id) + ",[7] ="+day7+",[7DailiSalary]=" + salary.WorkDaySalary(day7, id) + ",[8]="+day8+",[8DailiSalary]=" + salary.WorkDaySalary(day8, id) + "," +
                    "[9]=" + day9 + ",[9DailiSalary]=" + salary.WorkDaySalary(day9, id) + ",[10]=" + day10 + ",[10DailiSalary]=" + salary.WorkDaySalary(day10, id) + ",[11]=" + day11 + ",[11DailiSalary]=" + salary.WeekendDaySalary(day11, id) + "," +
                    "[12]=" + day12 + ",[12DailiSalary]=" +salary.WeekendDaySalary(day12, id) + ",[13]=" + day13 + ",[13DailiSalary]=" + salary.WorkDaySalary(day13, id) + ",[14]=" + day14 + ",[14DailiSalary]=" + salary.WorkDaySalary(day14, id) + "," +
                    "[15]=" + day15 + ",[15DailiSalary]=" + salary.WorkDaySalary(day15, id) + ",[16]=" + day16 + ",[16DailiSalary]=" + salary.WorkDaySalary(day16, id) + ",[17]=" + day17 + ",[17DailiSalary]=" + salary.WorkDaySalary(day17, id) + "," +
                    "[18]=" + day18 + ",[18DailiSalary]=" + salary.WeekendDaySalary(day18, id) + ",[19]=" + day19 + ",[19DailiSalary]=" + salary.WeekendDaySalary(day19, id) + ",[20]=" + day20 + ",[20DailiSalary]=" + salary.WorkDaySalary(day20, id) + "," +
                    "[21]=" + day21 + ",[21DailiSalary]=" + salary.WorkDaySalary(day21, id) + ",[22]=" + day22 + ",[22DailiSalary]=" + salary.WorkDaySalary(day22, id) + ",[23]=" + day23 + ",[23DailiSalary]=" + salary.WorkDaySalary(day23, id) + "," +
                    "[24]=" + day24 + ",[24DailiSalary]=" + salary.WorkDaySalary(day24, id) + ",[25]=" + day25 + ",[25DailiSalary]=" + salary.WeekendDaySalary(day25, id) + ",[26]=" + day26 + ",[26DailiSalary]=" + salary.WeekendDaySalary(day26, id) + "," +
                    "[27]=" + day27 + ",[27DailiSalary]=" + salary.WorkDaySalary(day27, id) + ",[28]=" + day28 + ",[28DailiSalary]=" + salary.WorkDaySalary(day28, id) + ",[29]=" + day29 + ",[29DailiSalary]=" + salary.WorkDaySalary(day29, id) + "," +
                    "[30]=" + day30 + ",[30DailiSalary]=" + salary.WorkDaySalary(day30, id) + ",[31]=" + day31 + ",[31DailiSalary]=" + salary.WorkDaySalary(day31, id) + " WHERE Id = " + id;

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
            finally { dB.GetConnection().Close(); }

            try
            {
                string query1 = "UPDATE March_2023 SET MonthliSalary=" + salary.MonthSalary(id) + " where Id=" + id;
                using (SqlCommand dbcommand = new SqlCommand(query1, dB.GetConnection()))
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
                this.march_2023TableAdapter.Fill(this.payrollTrackingDBDataSet13.March_2023);
                dB.GetConnection().Close();
            }

        }
    }
}
