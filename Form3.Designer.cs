
namespace WorkLink
{
  partial class Form3
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button2 = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(76, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Vacancy Type";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(7, 7);
      this.label2.MaximumSize = new System.Drawing.Size(430, 145);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(296, 36);
      this.label2.TabIndex = 1;
      this.label2.Text = "Название вакансии";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(27, 194);
      this.label4.MaximumSize = new System.Drawing.Size(450, 100);
      this.label4.MinimumSize = new System.Drawing.Size(450, 100);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(450, 100);
      this.label4.TabIndex = 3;
      this.label4.Text = "Требуемые навыки:\r\n";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(24, 307);
      this.label5.MaximumSize = new System.Drawing.Size(650, 200);
      this.label5.MinimumSize = new System.Drawing.Size(650, 200);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(650, 200);
      this.label5.TabIndex = 4;
      this.label5.Text = "Описание:\r\n";
      this.label5.Click += new System.EventHandler(this.label5_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(14, 16);
      this.label6.MaximumSize = new System.Drawing.Size(155, 0);
      this.label6.MinimumSize = new System.Drawing.Size(155, 80);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(155, 80);
      this.label6.TabIndex = 5;
      this.label6.Text = "Компания";
      this.label6.Click += new System.EventHandler(this.label6_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(15, 110);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(137, 17);
      this.label7.TabIndex = 6;
      this.label7.Text = "Рейтинг компании: ";
      this.label7.Click += new System.EventHandler(this.label7_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(698, 516);
      this.panel1.TabIndex = 7;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.button2.Location = new System.Drawing.Point(495, 25);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(98, 46);
      this.button2.TabIndex = 10;
      this.button2.Text = "Откликнуться";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.panel3.Controls.Add(this.label2);
      this.panel3.Location = new System.Drawing.Point(28, 25);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(449, 161);
      this.panel3.TabIndex = 9;
      this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.DarkSalmon;
      this.button1.Location = new System.Drawing.Point(600, 25);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(74, 46);
      this.button1.TabIndex = 8;
      this.button1.Text = "Закрыть";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.panel2.Controls.Add(this.label6);
      this.panel2.Controls.Add(this.label7);
      this.panel2.Location = new System.Drawing.Point(495, 149);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(179, 145);
      this.panel2.TabIndex = 7;
      // 
      // Form3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(698, 516);
      this.Controls.Add(this.panel1);
      this.Name = "Form3";
      this.Text = "Form3";
      this.Load += new System.EventHandler(this.Form3_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
  }
}