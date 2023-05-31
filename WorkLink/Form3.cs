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
  public partial class Form3 : Form
  {
    int VacancyItem;
    Vacancy Vacancy;
    public Form3(int Item)
    {
      VacancyItem = Item;
      string JsonFileName = "vacancies.json";
      List<Vacancy> VacanciList = JsonConvert.DeserializeObject<List<Vacancy>>(File.ReadAllText(JsonFileName));
      Vacancy = VacanciList[VacancyItem];
      InitializeComponent();
      label1.Text = Vacancy.VacancyType;
      label2.Text = Vacancy.Name + "\n" + "Зарплата: " + Vacancy.Salary.ToString();
      label5.Text += Vacancy.Details;
      label6.Text = Vacancy.Company;
      label7.Text += Vacancy.CompanyRating.ToString();
      label4.Text += Vacancy.RequiredSkills;
    }

    private void Form3_Load(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form1 MainForm = new Form1();
      MainForm.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      string JsonFileName = "Resume.json";
      Resume Resume = JsonConvert.DeserializeObject<Resume>(File.ReadAllText(JsonFileName));
      Resume.AcceptedVacancies.Add(Vacancy);

      JsonSerializer Serializer = new JsonSerializer();
      using (StreamWriter Writer = new StreamWriter("Resume.json"))
      {
        JsonTextWriter JsonWriter = new JsonTextWriter(Writer) { CloseOutput = false };
        Serializer.Serialize(JsonWriter, Resume);
      }

      this.Hide();
      Form1 MainForm = new Form1();
      MainForm.Show();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}
