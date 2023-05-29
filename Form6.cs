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
  public partial class Form6 : Form
  {
    Vacancy Vacancy;
    public Form6(int Item)
    {
      string JsonFileName = "vacancies.json";
      List<Vacancy> VacanciList = JsonConvert.DeserializeObject<List<Vacancy>>(File.ReadAllText(JsonFileName));
      Vacancy = VacanciList[Item];
      InitializeComponent();
      label2.Text = Vacancy.Name + "\n" + "Зарплата: " + Vacancy.Salary.ToString();
      label5.Text += Vacancy.Details;
      label6.Text = Vacancy.Company;
      label7.Text += Vacancy.CompanyRating.ToString();
      label4.Text += Vacancy.RequiredSkills;
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
      
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form5 PreviousForm = new Form5();
      PreviousForm.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Interview Interview = new Interview();
      Interview.Vacancy = Vacancy;
      Interview.Date = dateTimePicker1.Text;
      Interview.Time = maskedTextBox1.Text;

      string JsonResumeFileName = "Resume.json";
      Resume Resume = JsonConvert.DeserializeObject<Resume>(File.ReadAllText(JsonResumeFileName));
      Resume.Interviews.Add(Interview);

      JsonSerializer Serializer = new JsonSerializer();
      using (StreamWriter Writer = new StreamWriter(JsonResumeFileName))
      {
        JsonTextWriter JsonWriter = new JsonTextWriter(Writer) { CloseOutput = false };
        Serializer.Serialize(JsonWriter, Resume);
      }

      this.Hide();
      Form5 PreviousForm = new Form5();
      PreviousForm.Show();
    }
  }
}
