// Decompiled with JetBrains decompiler
// Type: TelegramTools.LoginForm
// Assembly: TelegramTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6847F506-A877-426C-8902-8E31C2680FE9
// Assembly location: C:\Users\Androide\Desktop\telegra,\TelegramTools.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TeleSharp.TL;

namespace TelegramTools
{
  public class LoginForm : Form
  {
    private string hash;
    private IContainer components;
    private Button button1;
    private TextBox textBox1;
    private Label label1;
    private Label label2;
    private TextBox textBox2;
    private Button button2;

    public LoginForm()
    {
      this.InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.textBox1.Text))
        return;
      try
      {
        int num = await Program.client.ConnectAsync(false) ? 1 : 0;
        LoginForm loginForm = this;
        string hash = loginForm.hash;
        string str = await Program.client.SendCodeRequestAsync(this.textBox1.Text);
        loginForm.hash = str;
        loginForm = (LoginForm) null;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(string.Format("Something went wrong. Exception: {0}", (object) ex.ToString()), "Error");
      }
    }

    private async void button2_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.textBox2.Text) || string.IsNullOrEmpty(this.textBox2.Text))
        return;
      if (string.IsNullOrEmpty(this.hash))
        return;
      try
      {
        TLUser tlUser = await Program.client.MakeAuthAsync(this.textBox1.Text, this.hash, this.textBox2.Text);
        this.Hide();
        MainForm mainForm = new MainForm();
        FormClosedEventHandler closedEventHandler = (FormClosedEventHandler) ((s, args) => this.Close());
        mainForm.FormClosed += closedEventHandler;
        int num = (int) mainForm.ShowDialog();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(string.Format("Something went wrong. Exception: {0}", (object) ex.ToString()), "Error");
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LoginForm));
      this.button1 = new Button();
      this.textBox1 = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.textBox2 = new TextBox();
      this.button2 = new Button();
      this.SuspendLayout();
      this.button1.Location = new Point(351, 37);
      this.button1.Name = "button1";
      this.button1.Size = new Size(159, 49);
      this.button1.TabIndex = 0;
      this.button1.Text = "Send Code";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.textBox1.Font = new Font("Microsoft Sans Serif", 13.875f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.textBox1.Location = new Point(12, 37);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(318, 49);
      this.textBox1.TabIndex = 1;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(7, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(155, 25);
      this.label1.TabIndex = 2;
      this.label1.Text = "Phone Number";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(12, 99);
      this.label2.Name = "label2";
      this.label2.Size = new Size(63, 25);
      this.label2.TabIndex = 3;
      this.label2.Text = "Code";
      this.textBox2.Font = new Font("Microsoft Sans Serif", 13.875f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.textBox2.Location = new Point(12, (int) sbyte.MaxValue);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(318, 49);
      this.textBox2.TabIndex = 4;
      this.button2.Location = new Point(351, (int) sbyte.MaxValue);
      this.button2.Name = "button2";
      this.button2.Size = new Size(159, 49);
      this.button2.TabIndex = 5;
      this.button2.Text = "Login";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.AutoScaleDimensions = new SizeF(12f, 25f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(523, 200);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "LoginForm";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "TelegramTools";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
