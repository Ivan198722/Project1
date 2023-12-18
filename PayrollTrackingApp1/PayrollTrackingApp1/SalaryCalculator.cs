using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollTrackingApp1
{
    public class SalaryCalculator : Form
    {
        // Obiekt do komunikacji z bazą danych
        internal PayrollTrackingDBEntities3 _dbEntities;

        // Konstruktor inicjalizujący obiekt bazy danych
        public SalaryCalculator()
        {
            _dbEntities = new PayrollTrackingDBEntities3();
        }

        // Wirtualna metoda zwracająca dane dotyczące pensji
        internal virtual IQueryable<object> GetSalaryData(int id)
        {
            // Zapytanie do bazy danych, łączące odpowiednie tabele
            var query = from pos in _dbEntities.PositionsAndPays
                        join emp in _dbEntities.Employees on pos.Id equals emp.IdPosition
                        join month in _dbEntities.August_2023 on emp.Id equals month.IdEmployee
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

        // Wirtualna metoda obliczająca dzienne wynagrodzenie
        internal virtual string CalculateDaySalary(int t, IQueryable<object> query)
        {
            decimal daySalary = 0;
            foreach (dynamic item in query)
            {
                decimal money = (decimal)item.HourlySalary___;
                daySalary = t * money;
            }
            return daySalary.ToString(CultureInfo.InvariantCulture);
        }

        // Wirtualna metoda obliczająca nadgodziny
        internal virtual string CalculateOvertimeSalary(int t, IQueryable<object> query)
        {
            decimal overtimeSalary = 0;
            foreach (dynamic item in query)
            {
                decimal normalyDaySalary;
                decimal money = (decimal)item.HourlySalary___;
                decimal percentOverTime = (decimal)item.Percentage__ / 100;
                normalyDaySalary = money * 8;
                overtimeSalary = normalyDaySalary + ((t - 8) * money * (1 + percentOverTime));
            }
            return overtimeSalary.ToString(CultureInfo.InvariantCulture);
        }

        // Wirtualna metoda obliczająca wynagrodzenie za dzień pracy
        internal virtual string WorkDaySalary(string time, string IdPerson)
        {
            // Konwersja parametrów na liczby całkowite
            int id = Int32.Parse(IdPerson);
            int t = Int32.Parse(time);

            // Pobranie danych dotyczących pensji
            var query = GetSalaryData(id);

            // Sprawdzenie, czy czas pracy mieści się w standardowych godzinach
            if (t <= 8)
            {
                return CalculateDaySalary(t, query);
            }
            else
            {
                return CalculateOvertimeSalary(t, query);
            }
        }

        // Wirtualna metoda zwracająca dane dotyczące pensji za weekend
        internal virtual IQueryable<object> GetSalaryData_Weekend(int id)
        {
            // Zapytanie do bazy danych, łączące odpowiednie tabele
            var query = from pos in _dbEntities.PositionsAndPays
                        join emp in _dbEntities.Employees on pos.Id equals emp.IdPosition
                        join month in _dbEntities.August_2023 on emp.Id equals month.IdEmployee
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

        // Wirtualna metoda obliczająca wynagrodzenie za dzień wolny
        internal virtual string CalculateWeekendSalary(int t, IQueryable<object> query)
        {
            decimal daySalary = 0;
            foreach (dynamic item in query)
            {
                decimal money = (decimal)item.HourlySalary___;
                decimal percentOverTime = (decimal)item.Percentage__ / 100;
                daySalary = t * money * (1 + percentOverTime);
            }
            string salary = daySalary.ToString(CultureInfo.InvariantCulture);

            return salary;
        }

        // Wirtualna metoda obliczająca wynagrodzenie za dzień weekendowy
        internal virtual string WeekendDaySalary(string time, string IdPerson)
        {
            // Konwersja parametrów na liczby całkowite
            int id = Int32.Parse(IdPerson);
            int t = Int32.Parse(time);

            // Pobranie danych dotyczących pensji za weekend
            var query = GetSalaryData_Weekend(id);

            return CalculateWeekendSalary(t, query);
        }

        internal virtual IQueryable<object> GetSalaryData_Month(int id)
        {
            // Zapytanie do bazy danych, sumujące dzienne zarobki z całego miesiąca
            var query = from month in _dbEntities.August_2023
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

        internal virtual string CalculateMonthSalary(int id, IQueryable<object> query)
        {
            decimal monthSalary = 0;
            foreach (dynamic item in query)
            {
                // Sumowanie wynagrodzenia za każdy dzień miesiąca
                monthSalary = (decimal)item.TotalMoney;
            }
            string salary = monthSalary.ToString(CultureInfo.InvariantCulture);
            return salary;
        }

        internal virtual string MonthSalary(string IdPerson)
        {
            // Konwersja parametru na liczbę całkowitą
            int id = Int32.Parse(IdPerson);

            // Pobranie danych dotyczących miesięcznej pensji
            var query = GetSalaryData_Month(id);
            return CalculateMonthSalary(id, query);
        }
    }
}
