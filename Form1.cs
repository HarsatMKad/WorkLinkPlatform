﻿using System;
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
    public int key = 0;
    public Form1()
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

    public Form1(Resume SampleResume)
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

      SampleResume.NotifyObserver();
      SampleResume.RemoveObserver();
    }

    private void Form1_Load(object sender, EventArgs e)
    {   }

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
      while (key < 5 && key >= 0 && key < VacanciesToView.Count)
      {
        Panel panel = VacanciList[0].CreatePanelVacancy(VacanciesToView[key].ID, VacanciesToView[key].Name, VacanciesToView[key].Details, VacanciesToView[key].Salary);
        tableLayoutPanel1.Controls.Add(panel);
        ++key;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form2 ResumeForm = new Form2();
      ResumeForm.Show();
    }

    private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
    {
      while (key < 5 && key >= 0 && key < VacanciesToView.Count)
      {
        Panel panel = VacanciList[0].CreatePanelVacancy(VacanciesToView[key].ID, VacanciesToView[key].Name, VacanciesToView[key].Details, VacanciesToView[key].Salary);
        tableLayoutPanel1.Controls.Add(panel);
        ++key;
      }
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

        while (key < key2 && key >= 0 && key < VacanciesToView.Count)
        {
          Panel panel = VacanciList[0].CreatePanelVacancy(VacanciesToView[key].ID, VacanciesToView[key].Name, VacanciesToView[key].Details, VacanciesToView[key].Salary);
          tableLayoutPanel1.Controls.Add(panel);
          ++key;
        }
        MessageBox.Show("конец списка");
      } else
      {
        int key2 = key + 5;
        while (key < key2 && key >= 0 && key < VacanciesToView.Count)
        {
          Panel panel = VacanciList[0].CreatePanelVacancy(VacanciesToView[key].ID, VacanciesToView[key].Name, VacanciesToView[key].Details, VacanciesToView[key].Salary);
          tableLayoutPanel1.Controls.Add(panel);
          ++key;
        }
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      tableLayoutPanel1.Controls.Clear();

      if (key <= 5 )
      {
        int key2 = key;
        key = 0;
        while (key < key2 && key >= 0 && key < VacanciesToView.Count)
        {
          Panel panel = VacanciList[0].CreatePanelVacancy(VacanciesToView[key].ID, VacanciesToView[key].Name, VacanciesToView[key].Details, VacanciesToView[key].Salary);
          tableLayoutPanel1.Controls.Add(panel);
          ++key;
        }
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
        while (key < key2 && key >= 0 && key < VacanciesToView.Count)
        {
          Panel panel = VacanciList[0].CreatePanelVacancy(VacanciesToView[key].ID, VacanciesToView[key].Name, VacanciesToView[key].Details, VacanciesToView[key].Salary);
          tableLayoutPanel1.Controls.Add(panel);
          ++key;
        }
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
          while (key < 5 && key >= 0 && key < VacanciesToView.Count)
          {
            Panel panel = VacanciList[0].CreatePanelVacancy(VacanciesToView[key].ID, VacanciesToView[key].Name, VacanciesToView[key].Details, VacanciesToView[key].Salary);
            tableLayoutPanel1.Controls.Add(panel);
            ++key;
          }
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
  }
}