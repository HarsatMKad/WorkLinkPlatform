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
  public partial class Form2 : Form
  {
    Resume Resume;
    Invoker invoker;
    public Form2()
    {
      invoker = new Invoker();
      Receiver receiver = new Receiver();
      ConcreteCommand command = new ConcreteCommand(receiver);
      invoker.SetCommand(command);
      Resume = invoker.Undo();

      InitializeComponent();
      EditResume(Resume);
    }

    private void EditResume(Resume Resume)
    {
      label1.Text = Resume.LastNameFirstName;
      label3.Text = Resume.Address;
      label4.Text = Resume.Sex;
      label5.Text = Resume.DateBirth;
      label6.Text = Resume.Citizenship;
      label8.Text = Resume.PhoneNumber.ToString();
      label9.Text = Resume.EducationInfo;
      label10.Text = Resume.Mail;
      label11.Text = Resume.DesiredSalary.ToString();
      label13.Text = Resume.AdditionalInfo;
      label12.Text = Resume.Skills;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form1 Form = new Form1();
      Form.Show();
    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void label10_Click(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void label8_Click(object sender, EventArgs e)
    {

    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void label13_Click(object sender, EventArgs e)
    {

    }

    private void label12_Click(object sender, EventArgs e)
    {

    }

    private void label9_Click(object sender, EventArgs e)
    {

    }

    private void label11_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label14_Click(object sender, EventArgs e)
    {

    }

    private void label15_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      if(textBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "" && dateTimePicker1.Text != "" && comboBox1.Text != "" && textBox7.Text != "" && maskedTextBox1.Text != "" && textBox2.Text != "" && numericUpDown3.Value.ToString() != "" && textBox9.Text != "" && textBox8.Text != "")
      {
        Resume = invoker.Run(textBox1.Text, textBox4.Text, textBox5.Text, dateTimePicker1.Text, comboBox1.Text, textBox7.Text, maskedTextBox1.Text, textBox2.Text, Convert.ToInt64(numericUpDown3.Value), textBox9.Text, textBox8.Text);
        EditResume(Resume);
      }
      else
      {
        MessageBox.Show("Заполните все поля");
      }
    }

    private void textBox1_TextChanged_1(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {

    }

    private void textBox7_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox9_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox8_TextChanged(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
      Resume = invoker.Undo();
      EditResume(Resume);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (textBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "" && dateTimePicker1.Text != "" && comboBox1.Text != "" && textBox7.Text != "" && maskedTextBox1.Text != "" && textBox2.Text != "" && numericUpDown3.Value.ToString() != "" && textBox9.Text != "" && textBox8.Text != "")
      {
        Resume = invoker.Accept();
        EditResume(Resume);
      }
      else
      {
        MessageBox.Show("Заполните все поля");
      }
    }

    private void label36_Click(object sender, EventArgs e)
    {

    }

    private void label35_Click(object sender, EventArgs e)
    {

    }

    private void label28_Click(object sender, EventArgs e)
    {

    }

    private void label26_Click(object sender, EventArgs e)
    {

    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {

    }

    private void numericUpDown3_ValueChanged(object sender, EventArgs e)
    {

    }

    private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void Form2_Load(object sender, EventArgs e)
    {

    }
  }
}
