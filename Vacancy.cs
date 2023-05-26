using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WorkLink
{
  abstract class Vacancy : IObserver
  {
    public void Update()
    {
      Console.WriteLine("Новая вакансия добавлена");
    }

    public void ShowVacancy(int key, TableLayoutPanel tableLayoutPanel1)
    {
      Button Button = new Button();
      Button.Text = "Рассмотреть вакансию";
      Button.Dock = DockStyle.Right;
      Button.BackColor = Color.BurlyWood;

      Label name = new Label();
      name.Text = "hello" + key.ToString();
      name.Dock = DockStyle.Top;

      Label sod = new Label();
      sod.Text = "ewrgheiowrjgeowirhg[iowjroijf43289tgjw9jh495ut034-tuju298tug0945h39rj3wqj";
      sod.Location = new Point(0, 30);

      Label salary = new Label();
      salary.Text = "зарплата: " + key.ToString() + "0000";
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

      tableLayoutPanel1.Controls.Add(panel);
    }
  }

  class VacancyProgrammer : Vacancy
  {
    string Name = "VacancyNAME";
    int Salary = 10000;
    string[] RequiredSkills = { "abc1", "abc2", "abc3" };
    string Content = "fwqfgjergiuershgjkerhng";
    string Company = "OOO fgewrger";
    int CompanyRating = 4;
  }
}
