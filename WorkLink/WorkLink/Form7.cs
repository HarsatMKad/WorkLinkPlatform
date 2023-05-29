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
  public partial class Form7 : Form
  {
    List<Interview> InterviewsList;
    Resume Resume;
    private int key = 0;
    public Form7()
    {
      string JsonResumeFileName = "Resume.json";
      Resume = JsonConvert.DeserializeObject<Resume>(File.ReadAllText(JsonResumeFileName));
      InterviewsList = Resume.Interviews;
      InitializeComponent();
    }

    private void CreateVacancy(int key2)
    {
      while (key < key2 && key >= 0 && key < InterviewsList.Count)
      {
        Panel Panel = CreatePanel(key);
        tableLayoutPanel1.Controls.Add(Panel);
        ++key;
      }
    }

    private Panel CreatePanel(int key)
    {
      Button Button = new Button();
      Button.Text = "Отменить интервью";
      Button.Dock = DockStyle.Right;
      Button.BackColor = Color.BurlyWood;
      Button.Click += DeleteInterview;

      void DeleteInterview(object sender, EventArgs e)
      {
        InterviewsList.Remove(InterviewsList[key]);
        Resume.Interviews = InterviewsList;

        JsonSerializer Serializer = new JsonSerializer();
        using (StreamWriter Writer = new StreamWriter("Resume.json"))
        {
          JsonTextWriter JsonWriter = new JsonTextWriter(Writer) { CloseOutput = false };
          Serializer.Serialize(JsonWriter, Resume);
        }

        this.Hide();
        Form7 ReForm = new Form7();
        ReForm.Show();
      }

      Label name = new Label();
      name.Text = InterviewsList[key].Vacancy.Name;
      name.Dock = DockStyle.Top;

      Label sod = new Label();
      sod.Text = InterviewsList[key].Vacancy.Details;
      sod.Location = new Point(0, 30);

      Label salary = new Label();
      salary.Text = "Зарплата: " + InterviewsList[key].Vacancy.Salary;
      salary.Dock = DockStyle.Bottom;

      Label Date = new Label();
      Date.Text = InterviewsList[key].Date + "\n" + InterviewsList[key].Time;
      Date.Dock = DockStyle.Right;
      Date.BackColor = Color.Bisque;

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
      panel.Controls.Add(Date);
      panel.Controls.Add(Button);
      panel.Width = 845;
      panel.BackColor = Color.Azure;

      return panel;
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {
      while (key < 5 && key >= 0 && key < InterviewsList.Count)
      {
        Panel Panel = CreatePanel(key);
        tableLayoutPanel1.Controls.Add(Panel);
        ++key;
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form1 Form = new Form1();
      Form.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      tableLayoutPanel1.Controls.Clear();
      if (key >= InterviewsList.Count)
      {
        int key2 = key;
        if (key % 5 != 0)
        {
          key -= key % 5;
        }
        CreateVacancy(key2);
        MessageBox.Show("конец списка");
      }
      else
      {
        int key2 = key + 5;
        CreateVacancy(key2);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      tableLayoutPanel1.Controls.Clear();
      if (key <= 5)
      {
        int key2 = key;
        key = 0;
        CreateVacancy(key2);
        MessageBox.Show("конец списка");
      }
      else
      {
        if (InterviewsList.Count < 10)
        {
          key -= InterviewsList.Count;
        }
        else
        {
          if (key % 5 != 0)
          {
            key = key - 5 - (key % 5);
          }
          else
          {
            key -= 10;
          }
        }
        int key2 = key + 5;
        CreateVacancy(key2);
      }
    }
  }
}
