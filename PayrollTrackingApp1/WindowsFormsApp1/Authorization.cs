using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollTrackingApp1
{
    public partial class Authorization : Form
    {
        DataBase dataBase = new DataBase();
        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            label1.Font = new Font("Arial", 16, FontStyle.Bold);
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            pasword_textBox.UseSystemPasswordChar = true;
            open_eye.Visible = false;
            login_textBox.MaxLength = 50;
            pasword_textBox.MaxLength = 50;
           
        }
        private void Enter_button_Click(object sender, EventArgs e)
        {
            var loginuser = login_textBox.Text;
            var pasworduser = pasword_textBox.Text;


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"select Id_user, login_user, pasword_user from Register where login_user = '{loginuser}' and pasword_user = '{pasworduser}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                //MessageBox.Show("Login successful!");
                PayrollTrackingApp mainform = new PayrollTrackingApp();
                this.Hide();
                mainform.ShowDialog();
                 this.Show();
                this.ClerAutorization();
               
            }
            else
            {

                MessageBox.Show("Account does not exist!");
            }
         

        }
        private void Authorization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Enter_button_Click(Enter_button, null);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
         
           
        }

        private void open_eye_Click(object sender, EventArgs e)
        {
            pasword_textBox.UseSystemPasswordChar = true;
            open_eye.Visible = false;
            close_eye.Visible = true;
            
        }

        private void close_eye_Click(object sender, EventArgs e)
        {
            pasword_textBox.UseSystemPasswordChar = false;
            open_eye.Visible = true;
            close_eye.Visible = false;
        }

        public void ClerAutorization()
        {

            login_textBox.Text = "";
            pasword_textBox.Text = "";
        }

    }
}
