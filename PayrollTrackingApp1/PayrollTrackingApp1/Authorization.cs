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
            StartPosition = FormStartPosition.CenterScreen;// Ustawienie pozycji startowej formularza na środku ekranu.
            label1.Font = new Font("Arial", 16, FontStyle.Bold);// Ustawienie właściwości czcionki etykiety label1.
                                                                // Używana jest czcionka Arial o rozmiarze 16 punktów i stylu pogrubionym.
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            pasword_textBox.UseSystemPasswordChar = true;// Ustawienie, aby w polu tekstowym 'pasword_textBox' używany był znak systemowego hasła.
            open_eye.Visible = false;// Ukrycie widoczności obrazka otwartego oka 'open_eye'.
            login_textBox.MaxLength = 50;
            pasword_textBox.MaxLength = 50;// Ustawienie maksymalnej długości tekstu  na 50 znaków.

        }
        private void Enter_button_Click(object sender, EventArgs e)
        {
                                                             // Pobranie danych z pól tekstowych 'login_textBox' i 'pasword_textBox'.
            var loginuser = login_textBox.Text;
            var pasworduser = pasword_textBox.Text;

                                                             // Inicjalizacja obiektu SqlDataAdapter i DataTable do obsługi zapytań SQL.
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

                                                                 // Tworzenie zapytania SQL w celu weryfikacji danych logowania w bazie danych.
            string queryString = $"SELECT Id_user, login_user, pasword_user FROM Register WHERE login_user = '{loginuser}' AND pasword_user = '{pasworduser}'";

                                                                     // Inicjalizacja obiektu SqlCommand z wykorzystaniem zapytania SQL oraz połączenia z bazą danych.
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

                                                                    // Przypisanie obiektu SqlCommand do właściwości SelectCommand obiektu SqlDataAdapter.
            adapter.SelectCommand = command;

                                                             // Wypełnienie tabeli danymi z bazy danych.
            adapter.Fill(table);

                                                                    // Sprawdzenie, czy tabela zawiera dokładnie jedną pasującą krotkę.
            if (table.Rows.Count == 1)
            {
                                                                            // Wyświetlenie komunikatu o udanym zalogowaniu.
                                                                         // MessageBox.Show("Login successful!");

                                                                           // Utworzenie nowej instancji głównego formularza aplikacji.
                PayrollTrackingApp mainform = new PayrollTrackingApp();

                                                                                  // Ukrycie bieżącego formularza logowania.
                this.Hide();

                                                                                 // Wyświetlenie głównego formularza.
                mainform.ShowDialog();

                                                                         // Ponowne wyświetlenie bieżącego formularza logowania po zamknięciu głównego formularza.
                this.Show();

                                                                                          // Wywołanie metody do wyczyszczenia pól autoryzacyjnych.
                this.ClearAuthorization();
            }
            else
            {
                                                                                     // Wyświetlenie komunikatu o nieudanej próbie logowania.
                MessageBox.Show("Account does not exist!");
            }
        }
                          // Obsługa zdarzenia naciśnięcia klawisza w formularzu autoryzacyjnym.
        private void Authorization_KeyDown(object sender, KeyEventArgs e)
        {
                                                    // Sprawdzenie, czy naciśnięty klawisz to Enter.
            if (e.KeyValue == (char)Keys.Enter)
            {
                                           // Wywołanie obsługi zdarzenia kliknięcia przycisku Enter_button.
                Enter_button_Click(Enter_button, null);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
           
        }

        private void open_eye_Click(object sender, EventArgs e)
        {

                                                         // Ustawienie, aby w polu tekstowym 'pasword_textBox' używany był znak systemowego hasła.
            pasword_textBox.UseSystemPasswordChar = true;
 
                                                                   // Ukrycie widoczności obrazka otwartego oka 'open_eye'.
            open_eye.Visible = false;

                                                             // Wyświetlenie widoczności obrazka zamkniętego oka 'close_eye'.
            close_eye.Visible = true;

        }

        private void close_eye_Click(object sender, EventArgs e)
        {
            pasword_textBox.UseSystemPasswordChar = false;
            open_eye.Visible = true;
            close_eye.Visible = false;
        }
                                                  // Metoda do wyczyszczenia pól autoryzacyjnych.
        public void ClearAuthorization()
        {
                                               // Wyczyszczenie tekstu w polu tekstowym 'login_textBox'.
            login_textBox.Text = "";

                                               // Wyczyszczenie tekstu w polu tekstowym 'pasword_textBox'.
            pasword_textBox.Text = "";
        }

    }
}
