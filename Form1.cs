using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkLink
{
  public partial class Form1 : Form
  {
    Vacancy v = new VacancyProgrammer();
    public int key = 0;
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form2 ewrg = new Form2();
      ewrg.Show();
    }

    private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
    {
      while (key < 5)
      {
        v.ShowVacancy(key, tableLayoutPanel1);
        ++key;
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      tableLayoutPanel1.Controls.Clear();

      if(key >= 20)
      {
        int key2 = key;
        key -= 5;
        while (key < key2)
        {
          v.ShowVacancy(key, tableLayoutPanel1);
          ++key;
        }
        MessageBox.Show("конец списка");
      }
      else
      {
        int key2 = key + 5;
        while (key < key2)
        {
          v.ShowVacancy(key, tableLayoutPanel1);
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
        key -= 5;
        while (key < key2)
        {
          v.ShowVacancy(key, tableLayoutPanel1);
          ++key;
        }
        MessageBox.Show("конец списка");
      }
      else
      {
        key -= 10;
        int key2 = key + 5;
        while (key < key2)
        {
          v.ShowVacancy(key, tableLayoutPanel1);
          ++key;
        }
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {

    }
  }
}
