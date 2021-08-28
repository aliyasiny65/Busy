using Busy.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Busy
{
  [DesignerGenerated]
  public class mainform : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Logolbl")]
    private Label _Logolbl;
    [AccessedThroughProperty("main")]
    private TabControl _main;
    [AccessedThroughProperty("startpage")]
    private TabPage _startpage;
    [AccessedThroughProperty("chatpage")]
    private TabPage _chatpage;
    [AccessedThroughProperty("statusbar")]
    private Label _statusbar;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("welcomelbl2")]
    private Label _welcomelbl2;
    [AccessedThroughProperty("welcomelbl1")]
    private Label _welcomelbl1;
    [AccessedThroughProperty("welcomelogo")]
    private PictureBox _welcomelogo;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("TextBox2")]
    private TextBox _TextBox2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("TextBox4")]
    private TextBox _TextBox4;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("ComboBox1")]
    private ComboBox _ComboBox1;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("Button4")]
    private Button _Button4;
    [AccessedThroughProperty("Button3")]
    private Button _Button3;
    [AccessedThroughProperty("TextBox3")]
    private TextBox _TextBox3;
    [AccessedThroughProperty("TextBox5")]
    private TextBox _TextBox5;
    private object evar;

    [DebuggerNonUserCode]
    static mainform()
    {
    }

    public mainform()
    {
      this.Load += new EventHandler(this.Form1_Load);
      mainform.__ENCAddToList((object) this);
      this.evar = (object) 0;
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (mainform.__ENCList)
      {
        if (mainform.__ENCList.Count == mainform.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (mainform.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (mainform.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                mainform.__ENCList[index1] = mainform.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          mainform.__ENCList.RemoveRange(index1, checked (mainform.__ENCList.Count - index1));
          mainform.__ENCList.Capacity = mainform.__ENCList.Count;
        }
        mainform.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (mainform));
      this.Panel1 = new Panel();
      this.Button2 = new Button();
      this.Label1 = new Label();
      this.Logolbl = new Label();
      this.PictureBox1 = new PictureBox();
      this.main = new TabControl();
      this.startpage = new TabPage();
      this.Button1 = new Button();
      this.welcomelbl2 = new Label();
      this.welcomelbl1 = new Label();
      this.welcomelogo = new PictureBox();
      this.chatpage = new TabPage();
      this.TextBox5 = new TextBox();
      this.ComboBox1 = new ComboBox();
      this.Label10 = new Label();
      this.Button4 = new Button();
      this.Button3 = new Button();
      this.TextBox4 = new TextBox();
      this.Label7 = new Label();
      this.Label6 = new Label();
      this.Label5 = new Label();
      this.TextBox3 = new TextBox();
      this.Label4 = new Label();
      this.TextBox2 = new TextBox();
      this.Label3 = new Label();
      this.TextBox1 = new TextBox();
      this.Label2 = new Label();
      this.statusbar = new Label();
      this.Panel1.SuspendLayout();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.main.SuspendLayout();
      this.startpage.SuspendLayout();
      ((ISupportInitialize) this.welcomelogo).BeginInit();
      this.chatpage.SuspendLayout();
      this.SuspendLayout();
      this.Panel1.Controls.Add((Control) this.Button2);
      this.Panel1.Controls.Add((Control) this.Label1);
      this.Panel1.Controls.Add((Control) this.Logolbl);
      this.Panel1.Controls.Add((Control) this.PictureBox1);
      Panel panel1_1 = this.Panel1;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      panel1_1.Location = point2;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      Size size1 = new Size(604, 61);
      Size size2 = size1;
      panel1_2.Size = size2;
      this.Panel1.TabIndex = 1;
      this.Button2.FlatStyle = FlatStyle.Flat;
      this.Button2.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.Button2.ForeColor = Color.FromArgb(0, 192, 0);
      Button button2_1 = this.Button2;
      point1 = new Point(503, 9);
      Point point3 = point1;
      button2_1.Location = point3;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(87, 41);
      Size size3 = size1;
      button2_2.Size = size3;
      this.Button2.TabIndex = 3;
      this.Button2.Text = "Bağlan";
      this.Button2.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(90, 37);
      Point point4 = point1;
      label1_1.Location = point4;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(84, 13);
      Size size4 = size1;
      label1_2.Size = size4;
      this.Label1.TabIndex = 2;
      this.Label1.Text = "Version 0.1 Test";
      this.Logolbl.AutoSize = true;
      this.Logolbl.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      Label logolbl1 = this.Logolbl;
      point1 = new Point(89, 9);
      Point point5 = point1;
      logolbl1.Location = point5;
      this.Logolbl.Name = "Logolbl";
      Label logolbl2 = this.Logolbl;
      size1 = new Size(58, 22);
      Size size5 = size1;
      logolbl2.Size = size5;
      this.Logolbl.TabIndex = 1;
      this.Logolbl.Text = "Busy";
      this.PictureBox1.Image = (Image) Busy.My.Resources.Resources.busylogo;
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(0, 0);
      Point point6 = point1;
      pictureBox1_1.Location = point6;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(83, 61);
      Size size6 = size1;
      pictureBox1_2.Size = size6;
      this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.PictureBox1.TabIndex = 0;
      this.PictureBox1.TabStop = false;
      this.main.Controls.Add((Control) this.startpage);
      this.main.Controls.Add((Control) this.chatpage);
      this.main.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      TabControl main1 = this.main;
      point1 = new Point(0, 62);
      Point point7 = point1;
      main1.Location = point7;
      this.main.Name = "main";
      this.main.SelectedIndex = 0;
      TabControl main2 = this.main;
      size1 = new Size(604, 393);
      Size size7 = size1;
      main2.Size = size7;
      this.main.TabIndex = 2;
      this.startpage.Controls.Add((Control) this.Button1);
      this.startpage.Controls.Add((Control) this.welcomelbl2);
      this.startpage.Controls.Add((Control) this.welcomelbl1);
      this.startpage.Controls.Add((Control) this.welcomelogo);
      TabPage startpage1 = this.startpage;
      point1 = new Point(4, 25);
      Point point8 = point1;
      startpage1.Location = point8;
      this.startpage.Name = "startpage";
      TabPage startpage2 = this.startpage;
      Padding padding1 = new Padding(3);
      Padding padding2 = padding1;
      startpage2.Padding = padding2;
      TabPage startpage3 = this.startpage;
      size1 = new Size(596, 364);
      Size size8 = size1;
      startpage3.Size = size8;
      this.startpage.TabIndex = 0;
      this.startpage.Text = "Karşılama Ekranı";
      this.startpage.UseVisualStyleBackColor = true;
      this.Button1.FlatStyle = FlatStyle.Flat;
      this.Button1.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.Button1.ForeColor = Color.DodgerBlue;
      Button button1_1 = this.Button1;
      point1 = new Point(499, 321);
      Point point9 = point1;
      button1_1.Location = point9;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(87, 40);
      Size size9 = size1;
      button1_2.Size = size9;
      this.Button1.TabIndex = 6;
      this.Button1.Text = "Hakkında";
      this.Button1.UseVisualStyleBackColor = true;
      this.welcomelbl2.AutoSize = true;
      this.welcomelbl2.Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      Label welcomelbl2_1 = this.welcomelbl2;
      point1 = new Point(22, 172);
      Point point10 = point1;
      welcomelbl2_1.Location = point10;
      this.welcomelbl2.Name = "welcomelbl2";
      Label welcomelbl2_2 = this.welcomelbl2;
      size1 = new Size(509, 126);
      Size size10 = size1;
      welcomelbl2_2.Size = size10;
      this.welcomelbl2.TabIndex = 2;
      this.welcomelbl2.Text = componentResourceManager.GetString("welcomelbl2.Text");
      this.welcomelbl1.AutoSize = true;
      this.welcomelbl1.Font = new Font("Arial", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      Label welcomelbl1_1 = this.welcomelbl1;
      point1 = new Point(21, 135);
      Point point11 = point1;
      welcomelbl1_1.Location = point11;
      this.welcomelbl1.Name = "welcomelbl1";
      Label welcomelbl1_2 = this.welcomelbl1;
      size1 = new Size(216, 24);
      Size size11 = size1;
      welcomelbl1_2.Size = size11;
      this.welcomelbl1.TabIndex = 1;
      this.welcomelbl1.Text = "Busy'e Hoş Geldiniz!";
      this.welcomelogo.Image = (Image) Busy.My.Resources.Resources.busylogo;
      PictureBox welcomelogo1 = this.welcomelogo;
      point1 = new Point(215, 3);
      Point point12 = point1;
      welcomelogo1.Location = point12;
      this.welcomelogo.Name = "welcomelogo";
      PictureBox welcomelogo2 = this.welcomelogo;
      size1 = new Size(165, 129);
      Size size12 = size1;
      welcomelogo2.Size = size12;
      this.welcomelogo.SizeMode = PictureBoxSizeMode.Zoom;
      this.welcomelogo.TabIndex = 0;
      this.welcomelogo.TabStop = false;
      this.chatpage.Controls.Add((Control) this.TextBox5);
      this.chatpage.Controls.Add((Control) this.ComboBox1);
      this.chatpage.Controls.Add((Control) this.Label10);
      this.chatpage.Controls.Add((Control) this.Button4);
      this.chatpage.Controls.Add((Control) this.Button3);
      this.chatpage.Controls.Add((Control) this.TextBox4);
      this.chatpage.Controls.Add((Control) this.Label7);
      this.chatpage.Controls.Add((Control) this.Label6);
      this.chatpage.Controls.Add((Control) this.Label5);
      this.chatpage.Controls.Add((Control) this.TextBox3);
      this.chatpage.Controls.Add((Control) this.Label4);
      this.chatpage.Controls.Add((Control) this.TextBox2);
      this.chatpage.Controls.Add((Control) this.Label3);
      this.chatpage.Controls.Add((Control) this.TextBox1);
      this.chatpage.Controls.Add((Control) this.Label2);
      this.chatpage.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      TabPage chatpage1 = this.chatpage;
      point1 = new Point(4, 25);
      Point point13 = point1;
      chatpage1.Location = point13;
      this.chatpage.Name = "chatpage";
      TabPage chatpage2 = this.chatpage;
      padding1 = new Padding(3);
      Padding padding3 = padding1;
      chatpage2.Padding = padding3;
      TabPage chatpage3 = this.chatpage;
      size1 = new Size(596, 364);
      Size size13 = size1;
      chatpage3.Size = size13;
      this.chatpage.TabIndex = 1;
      this.chatpage.Text = "Ayarlar";
      this.chatpage.UseVisualStyleBackColor = true;
      this.TextBox5.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.TextBox5.ForeColor = Color.Gray;
      TextBox textBox5_1 = this.TextBox5;
      point1 = new Point(338, 54);
      Point point14 = point1;
      textBox5_1.Location = point14;
      this.TextBox5.Name = "TextBox5";
      TextBox textBox5_2 = this.TextBox5;
      size1 = new Size(195, 25);
      Size size14 = size1;
      textBox5_2.Size = size14;
      this.TextBox5.TabIndex = 19;
      this.ComboBox1.FormattingEnabled = true;
      this.ComboBox1.Items.AddRange(new object[3]
      {
        (object) "Hızlı",
        (object) "Ortalama",
        (object) "Yavaş"
      });
      ComboBox comboBox1_1 = this.ComboBox1;
      point1 = new Point(137, 147);
      Point point15 = point1;
      comboBox1_1.Location = point15;
      this.ComboBox1.Name = "ComboBox1";
      ComboBox comboBox1_2 = this.ComboBox1;
      size1 = new Size(195, 24);
      Size size15 = size1;
      comboBox1_2.Size = size15;
      this.ComboBox1.TabIndex = 18;
      this.ComboBox1.Text = "Ortalama";
      this.Label10.AutoSize = true;
      this.Label10.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      Label label10_1 = this.Label10;
      point1 = new Point(18, 155);
      Point point16 = point1;
      label10_1.Location = point16;
      this.Label10.Name = "Label10";
      Label label10_2 = this.Label10;
      size1 = new Size(106, 16);
      Size size16 = size1;
      label10_2.Size = size16;
      this.Label10.TabIndex = 17;
      this.Label10.Text = "Tazeleme Sıklığı:";
      this.Button4.FlatStyle = FlatStyle.Flat;
      this.Button4.ForeColor = Color.Red;
      Button button4_1 = this.Button4;
      point1 = new Point(446, 322);
      Point point17 = point1;
      button4_1.Location = point17;
      this.Button4.Name = "Button4";
      Button button4_2 = this.Button4;
      size1 = new Size(67, 36);
      Size size17 = size1;
      button4_2.Size = size17;
      this.Button4.TabIndex = 13;
      this.Button4.Text = "İptal";
      this.Button4.UseVisualStyleBackColor = true;
      this.Button3.FlatStyle = FlatStyle.Flat;
      this.Button3.ForeColor = Color.FromArgb(0, 192, 0);
      Button button3_1 = this.Button3;
      point1 = new Point(519, 322);
      Point point18 = point1;
      button3_1.Location = point18;
      this.Button3.Name = "Button3";
      Button button3_2 = this.Button3;
      size1 = new Size(67, 36);
      Size size18 = size1;
      button3_2.Size = size18;
      this.Button3.TabIndex = 12;
      this.Button3.Text = "Kaydet";
      this.Button3.UseVisualStyleBackColor = true;
      this.TextBox4.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.TextBox4.ForeColor = Color.Gray;
      TextBox textBox4_1 = this.TextBox4;
      point1 = new Point(107, 263);
      Point point19 = point1;
      textBox4_1.Location = point19;
      this.TextBox4.Name = "TextBox4";
      TextBox textBox4_2 = this.TextBox4;
      size1 = new Size(195, 25);
      Size size19 = size1;
      textBox4_2.Size = size19;
      this.TextBox4.TabIndex = 11;
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      Label label7_1 = this.Label7;
      point1 = new Point(22, 268);
      Point point20 = point1;
      label7_1.Location = point20;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(83, 16);
      Size size20 = size1;
      label7_2.Size = size20;
      this.Label7.TabIndex = 10;
      this.Label7.Text = "Kullanıcı Adı:";
      this.Label6.AutoSize = true;
      this.Label6.FlatStyle = FlatStyle.Flat;
      this.Label6.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      Label label6_1 = this.Label6;
      point1 = new Point(19, 231);
      Point point21 = point1;
      label6_1.Location = point21;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(105, 18);
      Size size21 = size1;
      label6_2.Size = size21;
      this.Label6.TabIndex = 9;
      this.Label6.Text = "Genel Ayarlar:";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      Label label5_1 = this.Label5;
      point1 = new Point(18, 89);
      Point point22 = point1;
      label5_1.Location = point22;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(82, 16);
      Size size22 = size1;
      label5_2.Size = size22;
      this.Label5.TabIndex = 8;
      this.Label5.Text = "Kullanıcı adı:";
      this.TextBox3.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.TextBox3.ForeColor = Color.Gray;
      TextBox textBox3_1 = this.TextBox3;
      point1 = new Point(137, 116);
      Point point23 = point1;
      textBox3_1.Location = point23;
      this.TextBox3.Name = "TextBox3";
      TextBox textBox3_2 = this.TextBox3;
      size1 = new Size(195, 25);
      Size size23 = size1;
      textBox3_2.Size = size23;
      this.TextBox3.TabIndex = 7;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      Label label4_1 = this.Label4;
      point1 = new Point(18, 120);
      Point point24 = point1;
      label4_1.Location = point24;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(49, 16);
      Size size24 = size1;
      label4_2.Size = size24;
      this.Label4.TabIndex = 6;
      this.Label4.Text = "Parola:";
      this.TextBox2.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.TextBox2.ForeColor = Color.Gray;
      TextBox textBox2_1 = this.TextBox2;
      point1 = new Point(137, 85);
      Point point25 = point1;
      textBox2_1.Location = point25;
      this.TextBox2.Name = "TextBox2";
      TextBox textBox2_2 = this.TextBox2;
      size1 = new Size(195, 25);
      Size size25 = size1;
      textBox2_2.Size = size25;
      this.TextBox2.TabIndex = 5;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      Label label3_1 = this.Label3;
      point1 = new Point(18, 58);
      Point point26 = point1;
      label3_1.Location = point26;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(113, 16);
      Size size26 = size1;
      label3_2.Size = size26;
      this.Label3.TabIndex = 4;
      this.Label3.Text = "Adresler (cht - ttl):";
      this.TextBox1.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.TextBox1.ForeColor = Color.Gray;
      TextBox textBox1_1 = this.TextBox1;
      point1 = new Point(137, 54);
      Point point27 = point1;
      textBox1_1.Location = point27;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      size1 = new Size(195, 25);
      Size size27 = size1;
      textBox1_2.Size = size27;
      this.TextBox1.TabIndex = 3;
      this.Label2.AutoSize = true;
      this.Label2.FlatStyle = FlatStyle.Flat;
      this.Label2.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      Label label2_1 = this.Label2;
      point1 = new Point(18, 25);
      Point point28 = point1;
      label2_1.Location = point28;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(157, 18);
      Size size28 = size1;
      label2_2.Size = size28;
      this.Label2.TabIndex = 2;
      this.Label2.Text = "FTP Bağlantı Ayarları:";
      this.statusbar.AutoSize = true;
      this.statusbar.ForeColor = Color.Gray;
      Label statusbar1 = this.statusbar;
      point1 = new Point(7, 454);
      Point point29 = point1;
      statusbar1.Location = point29;
      this.statusbar.Name = "statusbar";
      Label statusbar2 = this.statusbar;
      size1 = new Size(69, 13);
      Size size29 = size1;
      statusbar2.Size = size29;
      this.statusbar.TabIndex = 4;
      this.statusbar.Text = "Hoş Geldiniz!";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      size1 = new Size(602, 470);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.statusbar);
      this.Controls.Add((Control) this.main);
      this.Controls.Add((Control) this.Panel1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      size1 = new Size(618, 509);
      this.MaximumSize = size1;
      this.MinimizeBox = false;
      size1 = new Size(618, 509);
      this.MinimumSize = size1;
      this.Name = nameof (mainform);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Busy";
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.main.ResumeLayout(false);
      this.startpage.ResumeLayout(false);
      this.startpage.PerformLayout();
      ((ISupportInitialize) this.welcomelogo).EndInit();
      this.chatpage.ResumeLayout(false);
      this.chatpage.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual PictureBox PictureBox1
    {
      [DebuggerNonUserCode] get => this._PictureBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox1 = value;
    }

    internal virtual Panel Panel1
    {
      [DebuggerNonUserCode] get => this._Panel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel1 = value;
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual Label Logolbl
    {
      [DebuggerNonUserCode] get => this._Logolbl;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Logolbl = value;
    }

    internal virtual TabControl main
    {
      [DebuggerNonUserCode] get => this._main;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._main = value;
    }

    internal virtual TabPage startpage
    {
      [DebuggerNonUserCode] get => this._startpage;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.startpage_Click);
        if (this._startpage != null)
          this._startpage.Click -= eventHandler;
        this._startpage = value;
        if (this._startpage == null)
          return;
        this._startpage.Click += eventHandler;
      }
    }

    internal virtual TabPage chatpage
    {
      [DebuggerNonUserCode] get => this._chatpage;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chatpage_Click);
        if (this._chatpage != null)
          this._chatpage.Click -= eventHandler;
        this._chatpage = value;
        if (this._chatpage == null)
          return;
        this._chatpage.Click += eventHandler;
      }
    }

    internal virtual Label statusbar
    {
      [DebuggerNonUserCode] get => this._statusbar;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._statusbar = value;
    }

    internal virtual Button Button1
    {
      [DebuggerNonUserCode] get => this._Button1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click_1);
        if (this._Button1 != null)
          this._Button1.Click -= eventHandler;
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += eventHandler;
      }
    }

    internal virtual Label welcomelbl2
    {
      [DebuggerNonUserCode] get => this._welcomelbl2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._welcomelbl2 = value;
    }

    internal virtual Label welcomelbl1
    {
      [DebuggerNonUserCode] get => this._welcomelbl1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._welcomelbl1 = value;
    }

    internal virtual PictureBox welcomelogo
    {
      [DebuggerNonUserCode] get => this._welcomelogo;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._welcomelogo = value;
    }

    internal virtual Button Button2
    {
      [DebuggerNonUserCode] get => this._Button2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        if (this._Button2 != null)
          this._Button2.Click -= eventHandler;
        this._Button2 = value;
        if (this._Button2 == null)
          return;
        this._Button2.Click += eventHandler;
      }
    }

    internal virtual Label Label5
    {
      [DebuggerNonUserCode] get => this._Label5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
    }

    internal virtual Label Label4
    {
      [DebuggerNonUserCode] get => this._Label4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
    }

    internal virtual TextBox TextBox2
    {
      [DebuggerNonUserCode] get => this._TextBox2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBox2_Click);
        if (this._TextBox2 != null)
          this._TextBox2.Click -= eventHandler;
        this._TextBox2 = value;
        if (this._TextBox2 == null)
          return;
        this._TextBox2.Click += eventHandler;
      }
    }

    internal virtual Label Label3
    {
      [DebuggerNonUserCode] get => this._Label3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal virtual TextBox TextBox1
    {
      [DebuggerNonUserCode] get => this._TextBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.TextBox1_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.TextBox1_Click);
        if (this._TextBox1 != null)
        {
          this._TextBox1.TextChanged -= eventHandler1;
          this._TextBox1.Click -= eventHandler2;
        }
        this._TextBox1 = value;
        if (this._TextBox1 == null)
          return;
        this._TextBox1.TextChanged += eventHandler1;
        this._TextBox1.Click += eventHandler2;
      }
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal virtual TextBox TextBox4
    {
      [DebuggerNonUserCode] get => this._TextBox4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBox4_Click);
        if (this._TextBox4 != null)
          this._TextBox4.Click -= eventHandler;
        this._TextBox4 = value;
        if (this._TextBox4 == null)
          return;
        this._TextBox4.Click += eventHandler;
      }
    }

    internal virtual Label Label7
    {
      [DebuggerNonUserCode] get => this._Label7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
    }

    internal virtual Label Label6
    {
      [DebuggerNonUserCode] get => this._Label6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
    }

    internal virtual ComboBox ComboBox1
    {
      [DebuggerNonUserCode] get => this._ComboBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ComboBox1_Click);
        if (this._ComboBox1 != null)
          this._ComboBox1.Click -= eventHandler;
        this._ComboBox1 = value;
        if (this._ComboBox1 == null)
          return;
        this._ComboBox1.Click += eventHandler;
      }
    }

    internal virtual Label Label10
    {
      [DebuggerNonUserCode] get => this._Label10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
    }

    internal virtual Button Button4
    {
      [DebuggerNonUserCode] get => this._Button4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        if (this._Button4 != null)
          this._Button4.Click -= eventHandler;
        this._Button4 = value;
        if (this._Button4 == null)
          return;
        this._Button4.Click += eventHandler;
      }
    }

    internal virtual Button Button3
    {
      [DebuggerNonUserCode] get => this._Button3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        if (this._Button3 != null)
          this._Button3.Click -= eventHandler;
        this._Button3 = value;
        if (this._Button3 == null)
          return;
        this._Button3.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox3
    {
      [DebuggerNonUserCode] get => this._TextBox3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBox3_Click);
        if (this._TextBox3 != null)
          this._TextBox3.Click -= eventHandler;
        this._TextBox3 = value;
        if (this._TextBox3 == null)
          return;
        this._TextBox3.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox5
    {
      [DebuggerNonUserCode] get => this._TextBox5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox5 = value;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
    }

    private void Button1_Click_1(object sender, EventArgs e)
    {
      MyProject.Forms.aboutform.Show();
      this.statusbar.Text = "Hakkında";
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.TextBox1.Text = MySettingsProperty.Settings.ftpadres;
      this.TextBox2.Text = MySettingsProperty.Settings.ftpusername;
      this.TextBox3.Text = MySettingsProperty.Settings.ftppasswd;
      this.ComboBox1.Text = MySettingsProperty.Settings.ftpsync;
      this.TextBox4.Text = MySettingsProperty.Settings.busyusername;
      this.TextBox5.Text = MySettingsProperty.Settings.ftpadres2;
    }

    private void chatpage_Click(object sender, EventArgs e) => this.statusbar.Text = "Ayarlar";

    private void startpage_Click(object sender, EventArgs e) => this.statusbar.Text = "Hoş Geldiniz!";

    private void TextBox1_Click(object sender, EventArgs e) => this.statusbar.Text = "FTP Sunucu Adresiniz";

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void TextBox2_Click(object sender, EventArgs e) => this.statusbar.Text = "FTP Sunucu Kullanıcı Adınız";

    private void TextBox3_Click(object sender, EventArgs e) => this.statusbar.Text = "FTP Sunucu Parolanız";

    private void TextBox4_Click(object sender, EventArgs e) => this.statusbar.Text = "Kullanıcı Adınız";

    private void TextBox5_Click(object sender, EventArgs e) => this.statusbar.Text = "Oda Başlığı";

    private void ComboBox1_Click(object sender, EventArgs e) => this.statusbar.Text = "FTP Sunucudan Oda Verilerinin Alınma Sıklığı";

    private void Button2_Click(object sender, EventArgs e)
    {
      this.statusbar.Text = "Bağlan!";
      this.statusbar.Text = "Ayarlar kontrol ediliyor...";
      if (Operators.CompareString(this.TextBox1.Text, "", false) == 0)
      {
        this.statusbar.Text = "Hata: 'FTP Adresi' kısmı boş bırakılamaz.";
        int num = (int) Interaction.MsgBox((object) "Hata: FTP Adresi kısmı boş bırakılamaz.", MsgBoxStyle.Critical);
        this.evar = (object) 1;
      }
      else
      {
        MySettingsProperty.Settings.ftpadres = this.TextBox1.Text;
        this.statusbar.Text = "Kaydedildi: FTP Adress.";
        this.evar = (object) 0;
      }
      if (Operators.CompareString(this.TextBox2.Text, "", false) == 0)
      {
        this.statusbar.Text = "Hata: 'Kullanıcı Adı' kısmı boş bırakılamaz.";
        int num = (int) Interaction.MsgBox((object) "Hata: 'Kullanıcı Adı' kısmı boş bırakılamaz.", MsgBoxStyle.Critical);
        this.evar = (object) 1;
      }
      else
      {
        MySettingsProperty.Settings.ftpusername = this.TextBox2.Text;
        this.statusbar.Text = "Kaydedildi: FTP Username.";
        this.evar = (object) 0;
      }
      if (Operators.CompareString(this.TextBox3.Text, "", false) == 0)
      {
        this.statusbar.Text = "Hata: 'Parola' kısmı boş bırakılamaz.";
        int num = (int) Interaction.MsgBox((object) "Hata: 'Parola' kısmı boş bırakılamaz.", MsgBoxStyle.Critical);
        this.evar = (object) 1;
      }
      else
      {
        MySettingsProperty.Settings.ftppasswd = this.TextBox3.Text;
        this.statusbar.Text = "Kaydedildi: FTP Password.";
        MySettingsProperty.Settings.busyusername = this.TextBox4.Text;
        MySettingsProperty.Settings.ftpadres2 = this.TextBox5.Text;
        MySettingsProperty.Settings.ftpsync = this.ComboBox1.Text;
        this.statusbar.Text = "Ayarlarınız kaydedildi.";
        this.evar = (object) 0;
      }
      if (Operators.ConditionalCompareObjectEqual(this.evar, (object) 0, false))
      {
        this.statusbar.Text = "Bağlan...";
        try
        {
          object obj = (object) new WebClient()
          {
            Credentials = ((ICredentials) new NetworkCredential(MySettingsProperty.Settings.ftpusername, MySettingsProperty.Settings.ftppasswd))
          }.DownloadString(MySettingsProperty.Settings.ftpadres2);
          MyProject.Forms.room.Show();
          this.Close();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          this.statusbar.Text = "Bağlantı hatası.";
          int num = (int) Interaction.MsgBox((object) "Bağlantı sağlanamadı. Lütfen ayarlarınızı kontrol edin ve yeniden deneyin.", MsgBoxStyle.Information);
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        int num1 = (int) Interaction.MsgBox((object) "Bağlantı kurulmadı, ayarlarınızı tekrardan gözden geçirin ve yeniden deneyin.", MsgBoxStyle.Information);
      }
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      this.statusbar.Text = "Ayarlar kontrol ediliyor...";
      if (Operators.CompareString(this.TextBox1.Text, "", false) == 0)
      {
        this.statusbar.Text = "Hata: 'FTP Adresi' kısmı boş bırakılamaz.";
        int num = (int) Interaction.MsgBox((object) "Hata: FTP Adresi kısmı boş bırakılamaz.", MsgBoxStyle.Critical);
        this.evar = (object) 1;
      }
      else
      {
        MySettingsProperty.Settings.ftpadres = this.TextBox1.Text;
        this.statusbar.Text = "Kaydedildi: FTP Adress.";
        this.evar = (object) 0;
      }
      if (Operators.CompareString(this.TextBox2.Text, "", false) == 0)
      {
        this.statusbar.Text = "Hata: 'Kullanıcı Adı' kısmı boş bırakılamaz.";
        int num = (int) Interaction.MsgBox((object) "Hata: 'Kullanıcı Adı' kısmı boş bırakılamaz.", MsgBoxStyle.Critical);
        this.evar = (object) 1;
      }
      else
      {
        MySettingsProperty.Settings.ftpusername = this.TextBox2.Text;
        this.statusbar.Text = "Kaydedildi: FTP Username.";
        this.evar = (object) 0;
      }
      if (Operators.CompareString(this.TextBox5.Text, "", false) == 0)
      {
        this.statusbar.Text = "Hata: 'Parola' kısmı boş bırakılamaz.";
        int num = (int) Interaction.MsgBox((object) "Hata: Lütfen Tüm Bölümleri Doldurduğunuzdan Emin Olun!", MsgBoxStyle.Critical);
        this.evar = (object) 1;
      }
      if (Operators.CompareString(this.TextBox3.Text, "", false) == 0)
      {
        this.statusbar.Text = "Hata: 'Parola' kısmı boş bırakılamaz.";
        int num = (int) Interaction.MsgBox((object) "Hata: 'Parola' kısmı boş bırakılamaz.", MsgBoxStyle.Critical);
        this.evar = (object) 1;
      }
      else
      {
        MySettingsProperty.Settings.ftppasswd = this.TextBox3.Text;
        this.statusbar.Text = "Kaydedildi: FTP Password.";
        MySettingsProperty.Settings.busyusername = this.TextBox4.Text;
        MySettingsProperty.Settings.ftpadres2 = this.TextBox5.Text;
        MySettingsProperty.Settings.ftpsync = this.ComboBox1.Text;
        this.statusbar.Text = "Ayarlarınız kaydedildi.";
        this.evar = (object) 0;
      }
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      this.TextBox1.Text = MySettingsProperty.Settings.ftpadres;
      this.TextBox2.Text = MySettingsProperty.Settings.ftpusername;
      this.TextBox3.Text = MySettingsProperty.Settings.ftppasswd;
      this.ComboBox1.Text = MySettingsProperty.Settings.ftpsync;
      this.TextBox4.Text = MySettingsProperty.Settings.busyusername;
    }
  }
}
