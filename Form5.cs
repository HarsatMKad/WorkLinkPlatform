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

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {
        while (key < 5 && key >= 0 && key < AcceptedVacancies.Count)
        {
          Panel panel = AcceptedVacancies[0].CreatePanelVacancy(AcceptedVacancies[key].ID, AcceptedVacancies[key].Name, AcceptedVacancies[key].Details, AcceptedVacancies[key].Salary);
          tableLayoutPanel1.Controls.Add(panel);
          ++key;
        }
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

        while (key < key2 && key >= 0 && key < AcceptedVacancies.Count)
        {
          Panel panel = AcceptedVacancies[0].CreatePanelVacancy(AcceptedVacancies[key].ID, AcceptedVacancies[key].Name, AcceptedVacancies[key].Details, AcceptedVacancies[key].Salary);
          tableLayoutPanel1.Controls.Add(panel);
          ++key;
        }
        MessageBox.Show("конец списка");
      }
      else
      {
        int key2 = key + 5;
        while (key < key2 && key >= 0 && key < AcceptedVacancies.Count)
        {
          Panel panel = AcceptedVacancies[0].CreatePanelVacancy(AcceptedVacancies[key].ID, AcceptedVacancies[key].Name, AcceptedVacancies[key].Details, AcceptedVacancies[key].Salary);
          tableLayoutPanel1.Controls.Add(panel);
          ++key;
        }
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      tableLayoutPanel1.Controls.Clear();

      if (key <= 5)
      {
        int key2 = key;
        key = 0;
        while (key < key2 && key >= 0 && key < AcceptedVacancies.Count)
        {
          Panel panel = AcceptedVacancies[0].CreatePanelVacancy(AcceptedVacancies[key].ID, AcceptedVacancies[key].Name, AcceptedVacancies[key].Details, AcceptedVacancies[key].Salary);
          tableLayoutPanel1.Controls.Add(panel);
          ++key;
        }
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
        while (key < key2 && key >= 0 && key < AcceptedVacancies.Count)
        {
          Panel panel = AcceptedVacancies[0].CreatePanelVacancy(AcceptedVacancies[key].ID, AcceptedVacancies[key].Name, AcceptedVacancies[key].Details, AcceptedVacancies[key].Salary);
          tableLayoutPanel1.Controls.Add(panel);
          ++key;
        }
      }
    }
  }
}
