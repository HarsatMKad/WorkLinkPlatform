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
  public partial class Form4 : Form
  {
    Vacancy Vacancy;
    public Form4()
    {
      InitializeComponent();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if(comboBox1 != null)
      {
        panel1.Visible = true;
        CreatorVacancy Creator;

        switch (comboBox1.Text)
        {
          case "Бухгалтер":
            Creator = new CreatorAccountantVacancy();
            Vacancy = Creator.FactoryMethod();
            Vacancy.VacancyType = "AccountantVacancy";
            break;

          case "Официант":
            Creator = new CreatorWaiterVacancy();
            Vacancy = Creator.FactoryMethod();
            Vacancy.VacancyType = "WaiterVacancy";
            break;

          case "Программист":
            Creator = new CreatorProgrammerVacancy();
            Vacancy = Creator.FactoryMethod();
            Vacancy.VacancyType = "ProgrammerVacancy";
            break;

          case "Учитель":
            Creator = new CreatorTeacherVacancy();
            Vacancy = Creator.FactoryMethod();
            Vacancy.VacancyType = "TeacherVacancy";
            break;

          case "Врач":
            Creator = new CreatorDoctorVacancy();
            Vacancy = Creator.FactoryMethod();
            Vacancy.VacancyType = "DoctorVacancy";
            break;

          case "Механик":
            Creator = new CreatorMechanicVacancy();
            Vacancy = Creator.FactoryMethod();
            Vacancy.VacancyType = "MechanicVacancy";
            break;

          case "Прочее":
            Creator = new CreatorOtherVacancy();
            Vacancy = Creator.FactoryMethod();
            Vacancy.VacancyType = "OtherVacancy";
            break;
        }
        comboBox1.Visible = false;
        label1.Text = "Вакансия типа: " + Vacancy.VacancyType;
      }
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form1 Form = new Form1();
      Form.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if(textBox1.Text != "" && numericUpDown1.Value.ToString() != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
      {
        string JsonFileName = "vacancies.json";
        List<Vacancy>  VacanciList = JsonConvert.DeserializeObject<List<Vacancy>>(File.ReadAllText(JsonFileName));
        Vacancy.ID = VacanciList.Count;
        Vacancy.Company = textBox5.Text;
        Vacancy.CompanyRating = 0.0;
        Vacancy.Name = textBox1.Text;
        Vacancy.Salary = Convert.ToInt64(numericUpDown1.Value);
        Vacancy.RequiredSkills = textBox3.Text;
        Vacancy.Details = textBox4.Text;
        VacanciList.Add(Vacancy);

        JsonSerializer Serializer = new JsonSerializer();
        using (StreamWriter Writer = new StreamWriter("Vacancies.json"))
        {
          JsonTextWriter JsonWriter = new JsonTextWriter(Writer) { CloseOutput = false };
          Serializer.Serialize(JsonWriter, VacanciList);
        }
        this.Hide();
        Resume Resume = new Resume();
        Resume.AddObserver(Vacancy);

        Form1 MainForm = new Form1(Resume);
        MainForm.Show();
      } else
      {
        MessageBox.Show("Заполните все поля");
      }
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
