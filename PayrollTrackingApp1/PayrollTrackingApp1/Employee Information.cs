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
    public partial class Employee_Information : Form
    {
        public Employee_Information()
        {
            InitializeComponent();

            dataGridView1.Columns[0].Width = 30;
        }

        private void Employee_Information_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payrollTrackingDBDataSet1.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter1.Fill(this.payrollTrackingDBDataSet1.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payrollTrackingDBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.payrollTrackingDBDataSet.Employee);

        }
    }
}
