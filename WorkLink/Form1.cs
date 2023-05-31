using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WorkLink
{
  public partial class Form1 : Form
  {
    string JsonFileName;
    List<Vacancy> VacanciList;
    List<Vacancy> VacanciesToView;
    private int key = 0;

    public Form1()
    {
      FormStart();
    }

    public Form1(Resume SampleResume)
    {
      FormStart();

      SampleResume.NotifyObserver();
      SampleResume.RemoveObserver();
    }

    private void Form1_Load(object sender, EventArgs e)
    {   }

    private void FormStart()
    {
      JsonFileName = "vacancies.json";
      VacanciList = JsonConvert.DeserializeObject<List<Vacancy>>(File.ReadAllText(JsonFileName));
      VacanciesToView = JsonConvert.DeserializeObject<List<Vacancy>>(File.ReadAllText(JsonFileName));
      InitializeComponent();

      string JsonResumeFileName = "Resume.json";
      Resume Resume = JsonConvert.DeserializeObject<Resume>(File.ReadAllText(JsonResumeFileName));

      if (Resume.AcceptedVacancies.Count > 0)
      {
        label3.Text = Resume.AcceptedVacancies.Count.ToString();
        label3.Visible = true;
      }
    }

    private Panel CreatePanel(int key)
    {
      Button Button = new Button();
      Button.Text = "Рассмотреть вакансию";
      Button.Dock = DockStyle.Right;
      Button.BackColor = Color.BurlyWood;
      Button.Click += SeeVacancy;

      void SeeVacancy(object sender, EventArgs e)
      {
        this.Hide();
        Form3 WatchVacancyForm = new Form3(VacanciesToView[key].ID);
        WatchVacancyForm.Show();
      }

      Label name = new Label();
      name.Text = VacanciesToView[key].Name;
      name.Dock = DockStyle.Top;

      Label sod = new Label();
      sod.Text = VacanciesToView[key].Details;
      sod.Location = new Point(0, 30);

      Label salary = new Label();
      salary.Text = "Зарплата: " + VacanciesToView[key].Salary;
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

    private void CreateVacancy()
    {
      while (key < 5 && key >= 0 && key < VacanciesToView.Count)
      {
        Panel Panel = CreatePanel(key);
        tableLayoutPanel1.Controls.Add(Panel);
        ++key;
      }
    }

    private void CreateVacancy(int key2)
    {
      while (key < key2 && key >= 0 && key < VacanciesToView.Count)
      {
        Panel Panel = CreatePanel(key);
        tableLayoutPanel1.Controls.Add(Panel);
        ++key;
      }
    }

    private void FilterByProfession(string VacancyType)
    {
      tableLayoutPanel1.Controls.Clear();
      VacanciesToView.Clear();
      foreach (Vacancy vacancy in VacanciList)
      {
        if (vacancy.VacancyType == VacancyType)
        {
          VacanciesToView.Add(vacancy);
        }
      }
      key = 0;
      CreateVacancy();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form2 ResumeForm = new Form2();
      ResumeForm.Show();
    }

    private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
    {
      CreateVacancy();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      tableLayoutPanel1.Controls.Clear();
      if(key >= VacanciesToView.Count)
      {
        int key2 = key;
        if(key % 5 != 0)
        {
          key -= key % 5;
        }
        CreateVacancy(key2);
        MessageBox.Show("конец списка");
      } else
      {
        int key2 = key + 5;
        CreateVacancy(key2);
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      tableLayoutPanel1.Controls.Clear();
      if (key <= 5 )
      {
        int key2 = key;
        key = 0;
        CreateVacancy(key2);
        MessageBox.Show("конец списка");
      } else
      {
        if(VacanciesToView.Count < 10)
        {
          key -= VacanciesToView.Count;
        } else
        {
          if(key % 5 != 0)
          {
            key = key - 5 - (key % 5);
          } else
          {
            key -= 10;
          }
        }
        int key2 = key + 5;
        CreateVacancy(key2);
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      string selectedState = comboBox1.SelectedItem.ToString();
      switch (selectedState)
      {
        case "Без фильтра":
          tableLayoutPanel1.Controls.Clear();
          VacanciesToView.Clear();
          VacanciesToView = JsonConvert.DeserializeObject<List<Vacancy>>(File.ReadAllText(JsonFileName));
          key = 0;
          CreateVacancy();
          break;

        case "Бухгалтер":
          string VacancyTypeAccountant = "AccountantVacancy";
          FilterByProfession(VacancyTypeAccountant);
          break;

        case "Официант":
          string VacancyTypeWaiter = "WaiterVacancy";
          FilterByProfession(VacancyTypeWaiter);
          break;

        case "Программист":
          string VacancyTypeProgrammer = "ProgrammerVacancy";
          FilterByProfession(VacancyTypeProgrammer);
          break;

        case "Учитель":
          string VacancyTypeTeacher = "TeacherVacancy";
          FilterByProfession(VacancyTypeTeacher);
          break;

        case "Врач":
          string VacancyTypeDoctor = "DoctorVacancy";
          FilterByProfession(VacancyTypeDoctor);
          break;

        case "Механик":
          string VacancyTypeMechanic = "MechanicVacancy";
          FilterByProfession(VacancyTypeMechanic);
          break;

        case "Прочее":
          string VacancyTypeOther = "OtherVacancy";
          FilterByProfession(VacancyTypeOther);
        break;
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form5 ResumeForm = new Form5();
      ResumeForm.Show();
    }


    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void button6_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form4 CreationVacancyForm = new Form4();
      CreationVacancyForm.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form7 InterviewSchedule = new Form7();
      InterviewSchedule.Show();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}
