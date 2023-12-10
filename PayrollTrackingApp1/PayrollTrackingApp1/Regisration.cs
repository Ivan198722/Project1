using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollTrackingApp1
{
    public partial class Regisration : Form
    {
        DataBase dataBase = new DataBase();
        public Regisration()
        {
             InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            registration_label.Font = new Font("Arial", 16, FontStyle.Bold);
        }

        private void Regisration_Load(object sender, EventArgs e)
        {
            textBox_pasword.UseSystemPasswordChar = true;
            open_eye.Visible = false;
           
        }

        private void create_button_Click(object sender, EventArgs e)
        {

            var loginUser = textBox_login.Text;
            var paswordUser = textBox_pasword.Text;

          



            string queryString = $"insert into Register (login_user, pasword_user) values ('{loginUser}','{paswordUser}')";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account created!");
                this.ClerRegistration();
            }
            else { MessageBox.Show("Account don't created!"); }

            dataBase.CloseConnection();

        }
     
          private void open_eye_Click_1(object sender, EventArgs e)
          {

            textBox_pasword.UseSystemPasswordChar = true;
            open_eye.Visible = false;
            close_eye.Visible = true;
          }
        private void close_eye_Click_1(object sender, EventArgs e)
        {
             textBox_pasword.UseSystemPasswordChar = false;
            open_eye.Visible = true;
            close_eye.Visible = false;
        }




        public void ClerRegistration()
        {

            textBox_login.Text = "";
            textBox_pasword.Text = "";
        }

        private void Regisration_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyValue == (char)Keys.Enter)
           {
               create_button_Click(create_button, null);
           }

        }
    }
}
