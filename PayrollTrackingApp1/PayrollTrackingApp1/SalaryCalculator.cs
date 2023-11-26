using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollTrackingApp1
{
    public class SalaryCalculator
    {

        //public string WorkDaySalary(string time, string IdEmployee)
        //{
        //    PayrollTrackingDBEntities1 dB = new PayrollTrackingDBEntities1();
        //    dB.Employees.ToList();
        //    dB.PositionsAndPays.ToList();
        //    dB.January_2023.ToList();
        //    dB.February_2023.ToList();
        //    dB.March_2023.ToList();
        //    dB.April_2023.ToList();
        //    dB.May_2023.ToList();
        //    dB.June_2023.ToList();
        //    dB.July_2023.ToList();
        //    dB.August_2023.ToList();
        //    dB.September_2023.ToList();
        //    dB.October_2023.ToList();
        //    dB.November_2023.ToList();
        //    dB.December_2023.ToList();
        //    dB.SalaryBonuses.ToList();
           
        //    int id = Int32.Parse(IdEmployee);
        //    int t = Int32.Parse(time);
        //    var query = from pos in dB.PositionsAndPays
        //                join empl in dB.Employees on pos.Id equals empl.IdPosition
        //                join jan in dB.January_2023 on empl.Id equals jan.IdEmployee
        //                where jan.IdEmployee == id
        //                join mar in dB.March_2023 on empl.Id equals mar.IdEmployee
        //                where mar.IdEmployee == id
        //                join apr in dB.April_2023 on empl.Id equals apr.IdEmployee
        //                where apr.IdEmployee == id
        //                join may in dB.May_2023 on empl.Id equals may.IdEmployee
        //                where may.IdEmployee == id
        //                join jun in dB.June_2023 on empl.Id equals jun.IdEmployee
        //                where jun.IdEmployee == id
        //                join jul in dB.July_2023 on empl.Id equals jul.IdEmployee
        //                where jul.IdEmployee == id
        //                join aug in dB.August_2023 on empl.Id equals aug.IdEmployee
        //                where aug.IdEmployee == id
        //                join sep in dB.September_2023 on empl.Id equals sep.IdEmployee
        //                where sep.IdEmployee == id
        //                join feb in dB.February_2023 on empl.Id equals feb.IdEmployee
        //                where feb.IdEmployee == id
        //                join feb in dB.February_2023 on empl.Id equals feb.IdEmployee
        //                where feb.IdEmployee == id
        //                join feb in dB.February_2023 on empl.Id equals feb.IdEmployee
        //                where feb.IdEmployee == id
        //                join feb in dB.February_2023 on empl.Id equals feb.IdEmployee
        //                where feb.IdEmployee == id
        //                from bon in dB.SalaryBonuses
        //                where bon.BonusID == 1
        //                select new
        //                {
        //                    pos.HourlySalary,
        //                    bon.Percentage__
        //                };




        //    if (t <= 8)
        //    {
        //        decimal daySalary = 0;
        //        foreach (var item in query)
        //        {
        //            decimal money = (decimal)item.HourlySalary;
        //            daySalary = t * money;
        //        }
        //        string salary = daySalary.ToString(CultureInfo.InvariantCulture);

        //        return salary;

        //    }
        //    else
        //    {
        //        decimal overtimeSalary = 0;
        //        foreach (var item in query)
        //        {
        //            decimal normalyDaySalary;
        //            decimal money = (decimal)item.HourlySalary;
        //            decimal percentOverTime = (decimal)item.Percentage__ / 100;
        //            normalyDaySalary = money * 8;
        //            overtimeSalary = normalyDaySalary + ((t - 8) * money * (1 + percentOverTime));

        //        }
        //        string bonsalary = overtimeSalary.ToString(CultureInfo.InvariantCulture);
        //        return bonsalary;

        //    }
        //}

        //public string DayOffSalary(string time, string IdPerson)
        //{
        //    DB_TestEntities dB = new DB_TestEntities();
        //    dB.People.ToList();
        //    dB.Positions.ToList();
        //    dB.Months.ToList();
        //    dB.AdditionalInterests.ToList();
        //    int id = Int32.Parse(IdPerson);
        //    int t = Int32.Parse(time);

        //    var query = from pos in dB.Positions
        //                join per in dB.People on pos.Id equals per.IdPosition
        //                join month in dB.Months on per.Id equals month.IdPerson
        //                where month.IdPerson == id
        //                from add in dB.AdditionalInterests
        //                where add.Id == 2
        //                select new
        //                {
        //                    pos.HourlySalary,
        //                    add.PercentOvertime__
        //                };

        //    decimal daySalary = 0;
        //    foreach (var item in query)
        //    {
        //        decimal money = (decimal)item.HourlySalary;
        //        decimal percentOverTime = (decimal)item.PercentOvertime__ / 100;
        //        daySalary = t * money * (1 + percentOverTime);
        //    }

        //    string salary = daySalary.ToString(CultureInfo.InvariantCulture);
        //    return salary;
        //}

        //public string MonthSalary(string IdPerson)
        //{
        //    DB_TestEntities dB = new DB_TestEntities();
        //    dB.Months.ToList();
        //    int id = Int32.Parse(IdPerson);
        //    var query = from month in dB.Months
        //                where month.IdPerson == id
        //                select new
        //                {
        //                    TotalMoney = month.C_Day1 + month.C_Day2 + month.C_Day3 + month.C_Day4 + month.C_Day5
        //                };
        //    // string salary = "0";
        //    decimal monthSalary = 0;
        //    foreach (var item in query)
        //    {
        //        //salary += item.TotalMoney;
        //        monthSalary = (decimal)item.TotalMoney;
        //    }
        //    string salary = monthSalary.ToString(CultureInfo.InvariantCulture);
        //    return salary;
        //}
    }
}
