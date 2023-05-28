using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace WorkLink
{
  class Vacancy : IObserver
  {
    public string VacancyType;
    public string Name;
    public int Salary;
    public string[] RequiredSkills;
    public string Details;
    public string Company;
    public double CompanyRating;

    public void Update()
    {
      Console.WriteLine("Новая вакансия добавлена");
    }

    public Panel CreatePanelVacancy(string NameVacancy, string Details, int Salary)
    {
      Button Button = new Button();
      Button.Text = "Рассмотреть вакансию";
      Button.Dock = DockStyle.Right;
      Button.BackColor = Color.BurlyWood;

      Label name = new Label();
      name.Text = NameVacancy;
      name.Dock = DockStyle.Top;

      Label sod = new Label();
      sod.Text = Details;
      sod.Location = new Point(0, 30);

      Label salary = new Label();
      salary.Text = "Зарплата: " + Salary;
      salary.Dock = DockStyle.Bottom;

      name.Height = 30;
      sod.Height = 30;
      sod.Width = 500;
      Button.Height = 30;
      Button.Width = 100;
      salary.Height = 30;

      Panel panel = new Panel();
      panel.Controls.Add(name);
      panel.Controls.Add(sod);
      panel.Controls.Add(salary);
      panel.Controls.Add(Button);
      panel.Width = 845;
      panel.BackColor = Color.Azure;

      return panel;
    }
  }

  class ProgrammerVacancy : Vacancy
  { }

  class MechanicVacancy : Vacancy
  { }

  class OtherVacancy : Vacancy
  { }

  class TeacherVacancy : Vacancy
  { }

  class AccountantVacancy : Vacancy 
  { }

  class DoctorVacancy : Vacancy
  { }

  class WaiterVacancy : Vacancy 
  { }
}
