// Decompiled with JetBrains decompiler
// Type: TelegramTools.MainForm
// Assembly: TelegramTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6847F506-A877-426C-8902-8E31C2680FE9
// Assembly location: C:\Users\Androide\Desktop\telegra,\TelegramTools.exe

using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using TeleSharp.TL;
using TeleSharp.TL.Contacts;

namespace TelegramTools
{
  public class MainForm : Form
  {
    private IContainer components;
    private TextBox textBox1;
    private Label label1;
    private Label label2;
    private TextBox textBox2;
    private Button button1;
    private ProgressBar progressBar1;
    private LinkLabel linkLabel1;
    private LinkLabel linkLabel2;
    private LinkLabel linkLabel3;

    public MainForm()
    {
      this.InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.textBox1.Text))
        return;
      if (string.IsNullOrEmpty(this.textBox2.Text))
        return;
      try
      {
        int num1 = await Program.client.ConnectAsync(false) ? 1 : 0;
        IEnumerable<string> source = ((IEnumerable<string>) this.textBox1.Text.Split(',')).Select<string, string>((Func<string, string>) (x => x.Trim()));
        if (source.Count<string>() > 3)
        {
          int num2 = (int) MessageBox.Show("In FREE version you can send only to 3 users at once. Get FULL version to remove the restriction.", "Full Version needed");
        }
        else
        {
          TLRequestImportContacts requestImportContacts = new TLRequestImportContacts();
          requestImportContacts.contacts = new TLVector<TLInputPhoneContact>();
          int num3 = 0;
          this.progressBar1.Minimum = 0;
          this.progressBar1.Maximum = source.Count<string>();
          this.progressBar1.Step = 1;
          this.progressBar1.Enabled = true;
          foreach (string str in source)
          {
            requestImportContacts.contacts.lists.Add(new TLInputPhoneContact()
            {
              phone = str,
              first_name = num3.ToString(),
              last_name = num3.ToString()
            });
            ++num3;
          }
          foreach (object list in (await Program.client.SendRequestAsync<TLImportedContacts>((TLMethod) requestImportContacts)).users.lists)
          {
            // ISSUE: reference to a compiler-generated field
            if (MainForm.\u003C\u003Eo__1.\u003C\u003Ep__3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              MainForm.\u003C\u003Eo__1.\u003C\u003Ep__3 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof (MainForm), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, bool> target1 = MainForm.\u003C\u003Eo__1.\u003C\u003Ep__3.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, bool>> p3 = MainForm.\u003C\u003Eo__1.\u003C\u003Ep__3;
            // ISSUE: reference to a compiler-generated field
            if (MainForm.\u003C\u003Eo__1.\u003C\u003Ep__2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              MainForm.\u003C\u003Eo__1.\u003C\u003Ep__2 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof (MainForm), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, object, object> target2 = MainForm.\u003C\u003Eo__1.\u003C\u003Ep__2.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, object, object>> p2 = MainForm.\u003C\u003Eo__1.\u003C\u003Ep__2;
            // ISSUE: reference to a compiler-generated field
            if (MainForm.\u003C\u003Eo__1.\u003C\u003Ep__1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              MainForm.\u003C\u003Eo__1.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetProperty", (IEnumerable<Type>) null, typeof (MainForm), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, string, object> target3 = MainForm.\u003C\u003Eo__1.\u003C\u003Ep__1.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, string, object>> p1 = MainForm.\u003C\u003Eo__1.\u003C\u003Ep__1;
            // ISSUE: reference to a compiler-generated field
            if (MainForm.\u003C\u003Eo__1.\u003C\u003Ep__0 == null)
            {
              // ISSUE: reference to a compiler-generated field
              MainForm.\u003C\u003Eo__1.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetType", (IEnumerable<Type>) null, typeof (MainForm), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj1 = MainForm.\u003C\u003Eo__1.\u003C\u003Ep__0.Target((CallSite) MainForm.\u003C\u003Eo__1.\u003C\u003Ep__0, list);
            string str = "id";
            object obj2 = target3((CallSite) p1, obj1, str);
            // ISSUE: variable of the null type
            __Null local = null;
            object obj3 = target2((CallSite) p2, obj2, (object) local);
            if (!target1((CallSite) p3, obj3))
            {
              TLInputPeerUser tlInputPeerUser1 = new TLInputPeerUser();
              TLInputPeerUser tlInputPeerUser2 = tlInputPeerUser1;
              // ISSUE: reference to a compiler-generated field
              if (MainForm.\u003C\u003Eo__1.\u003C\u003Ep__5 == null)
              {
                // ISSUE: reference to a compiler-generated field
                MainForm.\u003C\u003Eo__1.\u003C\u003Ep__5 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (int), typeof (MainForm)));
              }
              // ISSUE: reference to a compiler-generated field
              Func<CallSite, object, int> target4 = MainForm.\u003C\u003Eo__1.\u003C\u003Ep__5.Target;
              // ISSUE: reference to a compiler-generated field
              CallSite<Func<CallSite, object, int>> p5 = MainForm.\u003C\u003Eo__1.\u003C\u003Ep__5;
              // ISSUE: reference to a compiler-generated field
              if (MainForm.\u003C\u003Eo__1.\u003C\u003Ep__4 == null)
              {
                // ISSUE: reference to a compiler-generated field
                MainForm.\u003C\u003Eo__1.\u003C\u003Ep__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof (MainForm), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
                }));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              object obj4 = MainForm.\u003C\u003Eo__1.\u003C\u003Ep__4.Target((CallSite) MainForm.\u003C\u003Eo__1.\u003C\u003Ep__4, list);
              int num4 = target4((CallSite) p5, obj4);
              tlInputPeerUser2.user_id = num4;
              TLAbsUpdates tlAbsUpdates = await Program.client.SendMessageAsync((TLAbsInputPeer) tlInputPeerUser1, this.textBox2.Text);
              this.progressBar1.PerformStep();
              Thread.Sleep(2000);
            }
          }
          List<TLAbsUser>.Enumerator enumerator = new List<TLAbsUser>.Enumerator();
          this.progressBar1.Enabled = false;
          this.progressBar1.Value = 0;
          int num5 = (int) MessageBox.Show("Sent!", "Success");
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(string.Format("Something went wrong. Exception: {0}", (object) ex.ToString()), "Error");
      }
    }

    private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("http://sochix.ru");
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("https://github.com/sochix/telegram-tools#different-version");
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("https://github.com/sochix/telegram-tools");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MainForm));
      this.textBox1 = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.textBox2 = new TextBox();
      this.button1 = new Button();
      this.progressBar1 = new ProgressBar();
      this.linkLabel1 = new LinkLabel();
      this.linkLabel2 = new LinkLabel();
      this.linkLabel3 = new LinkLabel();
      this.SuspendLayout();
      this.textBox1.Location = new Point(10, 60);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = ScrollBars.Horizontal;
      this.textBox1.Size = new Size(470, 600);
      this.textBox1.TabIndex = 0;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(10, 10);
      this.label1.Name = "label1";
      this.label1.Size = new Size(470, 25);
      this.label1.TabIndex = 1;
      this.label1.Text = "User Phone Numbers, separated with comma (,)";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(530, 10);
      this.label2.Name = "label2";
      this.label2.Size = new Size(131, 25);
      this.label2.TabIndex = 2;
      this.label2.Text = "Text to send";
      this.textBox2.Location = new Point(530, 60);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.ScrollBars = ScrollBars.Horizontal;
      this.textBox2.Size = new Size(470, 600);
      this.textBox2.TabIndex = 3;
      this.button1.ImageAlign = ContentAlignment.MiddleLeft;
      this.button1.Location = new Point(400, 727);
      this.button1.Name = "button1";
      this.button1.Size = new Size(208, 64);
      this.button1.TabIndex = 4;
      this.button1.Text = "Send";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.progressBar1.Enabled = false;
      this.progressBar1.Location = new Point(10, 678);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new Size(990, 36);
      this.progressBar1.TabIndex = 5;
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Location = new Point(5, 731);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new Size(214, 25);
      this.linkLabel1.TabIndex = 6;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Have any questions?";
      this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.Location = new Point(5, 762);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new Size(159, 25);
      this.linkLabel2.TabIndex = 7;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "Buy full version";
      this.linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
      this.linkLabel3.AutoSize = true;
      this.linkLabel3.Location = new Point(696, 762);
      this.linkLabel3.Name = "linkLabel3";
      this.linkLabel3.Size = new Size(304, 25);
      this.linkLabel3.TabIndex = 8;
      this.linkLabel3.TabStop = true;
      this.linkLabel3.Text = "Developed by Sochix (C) 2017";
      this.linkLabel3.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
      this.AutoScaleDimensions = new SizeF(192f, 192f);
      this.AutoScaleMode = AutoScaleMode.Dpi;
      this.ClientSize = new Size(1009, 803);
      this.Controls.Add((Control) this.linkLabel3);
      this.Controls.Add((Control) this.linkLabel2);
      this.Controls.Add((Control) this.linkLabel1);
      this.Controls.Add((Control) this.progressBar1);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.textBox1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "TelegramTools";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
