using Newtonsoft.Json;
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

namespace WorkLink
{
  public partial class Form5 : Form
  {
    private List<Vacancy> AcceptedVacancies;
    private int key = 0;
    public Form5()
    {
      string JsonResumeFileName = "Resume.json";
      Resume Resume = JsonConvert.DeserializeObject<Resume>(File.ReadAllText(JsonResumeFileName));

      AcceptedVacancies = Resume.AcceptedVacancies;
      InitializeComponent();
    }

    private void Form5_Load(object sender, EventArgs e)
    {

    }

    private void CreateVacancy()
    {
      while (key < 5 && key >= 0 && key < AcceptedVacancies.Count)
      {
        Panel Panel = CreatePanel(key);
        tableLayoutPanel1.Controls.Add(Panel);
        ++key;
      }
    }

    private void CreateVacancy(int key2)
    {
      while (key < key2 && key >= 0 && key < AcceptedVacancies.Count)
      {
        Panel Panel = CreatePanel(key);
        tableLayoutPanel1.Controls.Add(Panel);
        ++key;
      }
    }

    private Panel CreatePanel(int key)
    {
      Button WatchButton = new Button();
      WatchButton.Text = "Назначить собеседование";
      WatchButton.Dock = DockStyle.Right;
      WatchButton.BackColor = Color.CadetBlue;
      WatchButton.Click += SeeVacancy;

      Button RemoveButton = new Button();
      RemoveButton.Text = "Удалить";
      RemoveButton.Dock = DockStyle.Right;
      RemoveButton.BackColor = Color.Red;
      RemoveButton.Click += RemoveVacancy;

      void SeeVacancy(object sender, EventArgs e)
      {
        Form6 WatchVacancyForm = new Form6(AcceptedVacancies[key].ID);
        WatchVacancyForm.Show();
        this.Hide();
      }

      void RemoveVacancy(object sender, EventArgs e)
      {
        AcceptedVacancies.Remove(AcceptedVacancies[key]);

        string JsonResumeFileName = "Resume.json";
        Resume Resume = JsonConvert.DeserializeObject<Resume>(File.ReadAllText(JsonResumeFileName));
        Resume.AcceptedVacancies = AcceptedVacancies;

        JsonSerializer Serializer = new JsonSerializer();
        using (StreamWriter Writer = new StreamWriter("Resume.json"))
        {
          JsonTextWriter JsonWriter = new JsonTextWriter(Writer) { CloseOutput = false };
          Serializer.Serialize(JsonWriter, Resume);
        }
        this.Hide();
        Form5 NewForm = new Form5();
        NewForm.Show();
      }

      Label name = new Label();
      name.Text = AcceptedVacancies[key].Name;
      name.Dock = DockStyle.Top;

      Label sod = new Label();
      sod.Text = AcceptedVacancies[key].Details;
      sod.Location = new Point(0, 30);

      Label salary = new Label();
      salary.Text = "Зарплата: " + AcceptedVacancies[key].Salary;
      salary.Dock = DockStyle.Bottom;

      name.Height = 30;
      sod.Height = 30;
      sod.Width = 500;
      WatchButton.Height = 30;
      WatchButton.Width = 100;
      RemoveButton.Height = 30;
      RemoveButton.Width = 100;
      salary.Height = 30;

      Panel panel = new Panel();
      panel.Controls.Add(name);
      panel.Controls.Add(sod);
      panel.Controls.Add(salary);
      panel.Controls.Add(WatchButton);
      panel.Controls.Add(RemoveButton);
      panel.Width = 845;
      panel.BackColor = Color.Azure;

      return panel;
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {
      CreateVacancy();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      tableLayoutPanel1.Controls.Clear();
      if (key >= AcceptedVacancies.Count)
      {
        int key2 = key;
        if (key % 5 != 0)
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

    private void button2_Click(object sender, EventArgs e)
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
        if (AcceptedVacancies.Count < 10)
        {
          key -= AcceptedVacancies.Count;
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

    private void button3_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form1 Form = new Form1();
      Form.Show();
    }
  }
}