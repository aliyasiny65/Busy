using Busy.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Busy
{
  [DesignerGenerated]
  public class room : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("odabasligi")]
    private Label _odabasligi;
    [AccessedThroughProperty("chat")]
    private RichTextBox _chat;
    [AccessedThroughProperty("RichTextBox2")]
    private RichTextBox _RichTextBox2;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("Timer1")]
    private System.Windows.Forms.Timer _Timer1;
    [AccessedThroughProperty("Button3")]
    private Button _Button3;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Button4")]
    private Button _Button4;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Button6")]
    private Button _Button6;
    [AccessedThroughProperty("Button5")]
    private Button _Button5;
    [AccessedThroughProperty("Button7")]
    private Button _Button7;
    private string ftpadres1;
    private string ftpadres2;
    private string ftppass;
    private string ftpname;
    private string msgsgs;
    private object cnt;
    private object oc;

    [DebuggerNonUserCode]
    static room()
    {
    }

    [DebuggerNonUserCode]
    public room()
    {
      this.Load += new EventHandler(this.room_Load);
      room.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (room.__ENCList)
      {
        if (room.__ENCList.Count == room.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (room.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (room.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                room.__ENCList[index1] = room.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          room.__ENCList.RemoveRange(index1, checked (room.__ENCList.Count - index1));
          room.__ENCList.Capacity = room.__ENCList.Count;
        }
        room.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (room));
      this.odabasligi = new Label();
      this.chat = new RichTextBox();
      this.RichTextBox2 = new RichTextBox();
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.Timer1 = new System.Windows.Forms.Timer(this.components);
      this.Button3 = new Button();
      this.Panel1 = new Panel();
      this.Button7 = new Button();
      this.Button4 = new Button();
      this.TextBox1 = new TextBox();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.Panel2 = new Panel();
      this.Label3 = new Label();
      this.Button6 = new Button();
      this.Button5 = new Button();
      this.Panel1.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.SuspendLayout();
      this.odabasligi.AutoSize = true;
      this.odabasligi.Dock = DockStyle.Bottom;
      this.odabasligi.FlatStyle = FlatStyle.Flat;
      this.odabasligi.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.odabasligi.ForeColor = Color.Gray;
      Label odabasligi1 = this.odabasligi;
      Point point1 = new Point(0, 505);
      Point point2 = point1;
      odabasligi1.Location = point2;
      this.odabasligi.Name = "odabasligi";
      this.odabasligi.RightToLeft = RightToLeft.No;
      Label odabasligi2 = this.odabasligi;
      Size size1 = new Size(97, 19);
      Size size2 = size1;
      odabasligi2.Size = size2;
      this.odabasligi.TabIndex = 0;
      this.odabasligi.Text = "oda_basligi";
      this.chat.BackColor = SystemColors.Menu;
      this.chat.BorderStyle = BorderStyle.None;
      this.chat.Dock = DockStyle.Fill;
      this.chat.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      RichTextBox chat1 = this.chat;
      point1 = new Point(0, 0);
      Point point3 = point1;
      chat1.Location = point3;
      this.chat.Name = "chat";
      this.chat.ReadOnly = true;
      RichTextBox chat2 = this.chat;
      size1 = new Size(744, 551);
      Size size3 = size1;
      chat2.Size = size3;
      this.chat.TabIndex = 1;
      this.chat.Text = "";
      this.RichTextBox2.BackColor = Color.White;
      this.RichTextBox2.BorderStyle = BorderStyle.None;
      this.RichTextBox2.Dock = DockStyle.Bottom;
      this.RichTextBox2.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      RichTextBox richTextBox2_1 = this.RichTextBox2;
      point1 = new Point(0, 524);
      Point point4 = point1;
      richTextBox2_1.Location = point4;
      this.RichTextBox2.Name = "RichTextBox2";
      RichTextBox richTextBox2_2 = this.RichTextBox2;
      size1 = new Size(744, 27);
      Size size4 = size1;
      richTextBox2_2.Size = size4;
      this.RichTextBox2.TabIndex = 2;
      this.RichTextBox2.Text = "";
      this.Button1.Dock = DockStyle.Right;
      this.Button1.FlatStyle = FlatStyle.Flat;
      this.Button1.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.Button1.ForeColor = Color.Maroon;
      Button button1_1 = this.Button1;
      point1 = new Point(669, 0);
      Point point5 = point1;
      button1_1.Location = point5;
      Button button1_2 = this.Button1;
      size1 = new Size(75, 27);
      Size size5 = size1;
      button1_2.MaximumSize = size5;
      Button button1_3 = this.Button1;
      size1 = new Size(75, 27);
      Size size6 = size1;
      button1_3.MinimumSize = size6;
      this.Button1.Name = "Button1";
      Button button1_4 = this.Button1;
      size1 = new Size(75, 27);
      Size size7 = size1;
      button1_4.Size = size7;
      this.Button1.TabIndex = 3;
      this.Button1.Text = "Ayrıl";
      this.Button1.UseVisualStyleBackColor = true;
      this.Button2.FlatStyle = FlatStyle.Flat;
      this.Button2.ForeColor = Color.Gray;
      Button button2_1 = this.Button2;
      point1 = new Point(669, 524);
      Point point6 = point1;
      button2_1.Location = point6;
      Button button2_2 = this.Button2;
      size1 = new Size(75, 27);
      Size size8 = size1;
      button2_2.MaximumSize = size8;
      Button button2_3 = this.Button2;
      size1 = new Size(75, 27);
      Size size9 = size1;
      button2_3.MinimumSize = size9;
      this.Button2.Name = "Button2";
      Button button2_4 = this.Button2;
      size1 = new Size(75, 27);
      Size size10 = size1;
      button2_4.Size = size10;
      this.Button2.TabIndex = 4;
      this.Button2.Text = "Gönder";
      this.Button2.UseVisualStyleBackColor = true;
      this.Button3.Dock = DockStyle.Right;
      this.Button3.FlatStyle = FlatStyle.Flat;
      this.Button3.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.Button3.ForeColor = Color.Gray;
      Button button3_1 = this.Button3;
      point1 = new Point(594, 0);
      Point point7 = point1;
      button3_1.Location = point7;
      Button button3_2 = this.Button3;
      size1 = new Size(75, 27);
      Size size11 = size1;
      button3_2.MaximumSize = size11;
      Button button3_3 = this.Button3;
      size1 = new Size(75, 27);
      Size size12 = size1;
      button3_3.MinimumSize = size12;
      this.Button3.Name = "Button3";
      Button button3_4 = this.Button3;
      size1 = new Size(75, 27);
      Size size13 = size1;
      button3_4.Size = size13;
      this.Button3.TabIndex = 5;
      this.Button3.Text = "Oda";
      this.Button3.UseVisualStyleBackColor = true;
      this.Panel1.Controls.Add((Control) this.Button7);
      this.Panel1.Controls.Add((Control) this.Button4);
      this.Panel1.Controls.Add((Control) this.TextBox1);
      this.Panel1.Controls.Add((Control) this.Label2);
      this.Panel1.Controls.Add((Control) this.Label1);
      Panel panel1_1 = this.Panel1;
      point1 = new Point(389, 26);
      Point point8 = point1;
      panel1_1.Location = point8;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(280, 114);
      Size size14 = size1;
      panel1_2.Size = size14;
      this.Panel1.TabIndex = 6;
      this.Panel1.Visible = false;
      this.Button7.FlatStyle = FlatStyle.Flat;
      this.Button7.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      Button button7_1 = this.Button7;
      point1 = new Point(22, 82);
      Point point9 = point1;
      button7_1.Location = point9;
      this.Button7.Name = "Button7";
      Button button7_2 = this.Button7;
      size1 = new Size(75, 27);
      Size size15 = size1;
      button7_2.Size = size15;
      this.Button7.TabIndex = 4;
      this.Button7.Text = "Sil";
      this.Button7.UseVisualStyleBackColor = true;
      this.Button4.FlatStyle = FlatStyle.Flat;
      this.Button4.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      Button button4_1 = this.Button4;
      point1 = new Point(190, 83);
      Point point10 = point1;
      button4_1.Location = point10;
      this.Button4.Name = "Button4";
      Button button4_2 = this.Button4;
      size1 = new Size(75, 27);
      Size size16 = size1;
      button4_2.Size = size16;
      this.Button4.TabIndex = 3;
      this.Button4.Text = "Kaydet";
      this.Button4.UseVisualStyleBackColor = true;
      this.TextBox1.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox1.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      TextBox textBox1_1 = this.TextBox1;
      point1 = new Point(73, 50);
      Point point11 = point1;
      textBox1_1.Location = point11;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      size1 = new Size(165, 21);
      Size size17 = size1;
      textBox1_2.Size = size17;
      this.TextBox1.TabIndex = 2;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      Label label2_1 = this.Label2;
      point1 = new Point(19, 50);
      Point point12 = point1;
      label2_1.Location = point12;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(48, 16);
      Size size18 = size1;
      label2_2.Size = size18;
      this.Label2.TabIndex = 1;
      this.Label2.Text = "Başlık:";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      Label label1_1 = this.Label1;
      point1 = new Point(19, 18);
      Point point13 = point1;
      label1_1.Location = point13;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(120, 17);
      Size size19 = size1;
      label1_2.Size = size19;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Oda Seçenekleri:";
      this.Panel2.Controls.Add((Control) this.Label3);
      this.Panel2.Controls.Add((Control) this.Button6);
      this.Panel2.Controls.Add((Control) this.Button5);
      Panel panel2_1 = this.Panel2;
      point1 = new Point(544, 27);
      Point point14 = point1;
      panel2_1.Location = point14;
      this.Panel2.Name = "Panel2";
      Panel panel2_2 = this.Panel2;
      size1 = new Size(200, 100);
      Size size20 = size1;
      panel2_2.Size = size20;
      this.Panel2.TabIndex = 7;
      this.Panel2.Visible = false;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      Label label3_1 = this.Label3;
      point1 = new Point(10, 11);
      Point point15 = point1;
      label3_1.Location = point15;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(164, 34);
      Size size21 = size1;
      label3_2.Size = size21;
      this.Label3.TabIndex = 2;
      this.Label3.Text = "Odadan Ayrılmak İstiyor \r\nMusunuz?\r\n";
      this.Button6.FlatStyle = FlatStyle.Flat;
      this.Button6.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.Button6.ForeColor = Color.Green;
      Button button6_1 = this.Button6;
      point1 = new Point(109, 59);
      Point point16 = point1;
      button6_1.Location = point16;
      this.Button6.Name = "Button6";
      Button button6_2 = this.Button6;
      size1 = new Size(76, 29);
      Size size22 = size1;
      button6_2.Size = size22;
      this.Button6.TabIndex = 1;
      this.Button6.Text = "Hayır";
      this.Button6.UseVisualStyleBackColor = true;
      this.Button5.FlatStyle = FlatStyle.Flat;
      this.Button5.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.Button5.ForeColor = Color.Maroon;
      Button button5_1 = this.Button5;
      point1 = new Point(13, 59);
      Point point17 = point1;
      button5_1.Location = point17;
      this.Button5.Name = "Button5";
      Button button5_2 = this.Button5;
      size1 = new Size(77, 29);
      Size size23 = size1;
      button5_2.Size = size23;
      this.Button5.TabIndex = 0;
      this.Button5.Text = "Evet";
      this.Button5.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      size1 = new Size(744, 551);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Panel2);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.Button3);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.odabasligi);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.RichTextBox2);
      this.Controls.Add((Control) this.chat);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      size1 = new Size(760, 590);
      this.MaximumSize = size1;
      size1 = new Size(760, 590);
      this.MinimumSize = size1;
      this.Name = nameof (room);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (room);
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.Panel2.ResumeLayout(false);
      this.Panel2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label odabasligi
    {
      [DebuggerNonUserCode] get => this._odabasligi;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._odabasligi = value;
    }

    internal virtual RichTextBox chat
    {
      [DebuggerNonUserCode] get => this._chat;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chat_TextChanged);
        if (this._chat != null)
          this._chat.TextChanged -= eventHandler;
        this._chat = value;
        if (this._chat == null)
          return;
        this._chat.TextChanged += eventHandler;
      }
    }

    internal virtual RichTextBox RichTextBox2
    {
      [DebuggerNonUserCode] get => this._RichTextBox2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RichTextBox2_TextChanged);
        if (this._RichTextBox2 != null)
          this._RichTextBox2.TextChanged -= eventHandler;
        this._RichTextBox2 = value;
        if (this._RichTextBox2 == null)
          return;
        this._RichTextBox2.TextChanged += eventHandler;
      }
    }

    internal virtual Button Button1
    {
      [DebuggerNonUserCode] get => this._Button1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._Button1 != null)
          this._Button1.Click -= eventHandler;
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += eventHandler;
      }
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

    internal virtual System.Windows.Forms.Timer Timer1
    {
      [DebuggerNonUserCode] get => this._Timer1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
        if (this._Timer1 != null)
          this._Timer1.Tick -= eventHandler;
        this._Timer1 = value;
        if (this._Timer1 == null)
          return;
        this._Timer1.Tick += eventHandler;
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

    internal virtual Panel Panel1
    {
      [DebuggerNonUserCode] get => this._Panel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel1 = value;
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Label1_Click);
        if (this._Label1 != null)
          this._Label1.Click -= eventHandler;
        this._Label1 = value;
        if (this._Label1 == null)
          return;
        this._Label1.Click += eventHandler;
      }
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

    internal virtual TextBox TextBox1
    {
      [DebuggerNonUserCode] get => this._TextBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox1 = value;
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal virtual Panel Panel2
    {
      [DebuggerNonUserCode] get => this._Panel2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel2 = value;
    }

    internal virtual Label Label3
    {
      [DebuggerNonUserCode] get => this._Label3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal virtual Button Button6
    {
      [DebuggerNonUserCode] get => this._Button6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button6_Click);
        if (this._Button6 != null)
          this._Button6.Click -= eventHandler;
        this._Button6 = value;
        if (this._Button6 == null)
          return;
        this._Button6.Click += eventHandler;
      }
    }

    internal virtual Button Button5
    {
      [DebuggerNonUserCode] get => this._Button5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button5_Click);
        if (this._Button5 != null)
          this._Button5.Click -= eventHandler;
        this._Button5 = value;
        if (this._Button5 == null)
          return;
        this._Button5.Click += eventHandler;
      }
    }

    internal virtual Button Button7
    {
      [DebuggerNonUserCode] get => this._Button7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button7_Click);
        if (this._Button7 != null)
          this._Button7.Click -= eventHandler;
        this._Button7 = value;
        if (this._Button7 == null)
          return;
        this._Button7.Click += eventHandler;
      }
    }

    private void room_Load(object sender, EventArgs e)
    {
      this.Visible = false;
      this.oc = (object) 0;
      try
      {
        WebClient webClient = new WebClient();
        this.msgsgs = this.chat.Text;
        webClient.Credentials = (ICredentials) new NetworkCredential(this.ftpname, this.ftppass);
        webClient.UploadString(this.ftpadres1, this.chat.Text + MySettingsProperty.Settings.busyusername.ToString() + " odaya katıldı.\r\n");
        MyProject.Forms.mainform.Show();
        this.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MyProject.Forms.mainform.statusbar.Text = "Bağlantı hatası.";
        ProjectData.ClearProjectError();
      }
      this.Timer1.Start();
      this.Name = MySettingsProperty.Settings.busyusername;
      this.ftpadres1 = MySettingsProperty.Settings.ftpadres;
      this.ftpadres2 = MySettingsProperty.Settings.ftpadres2;
      this.ftppass = MySettingsProperty.Settings.ftppasswd;
      this.ftpname = MySettingsProperty.Settings.ftpusername;
      try
      {
        WebClient webClient = new WebClient();
        this.msgsgs = this.chat.Text;
        webClient.Credentials = (ICredentials) new NetworkCredential(this.ftpname, this.ftppass);
        this.odabasligi.Text = webClient.DownloadString(this.ftpadres2);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MyProject.Forms.mainform.statusbar.Text = "Bağlantı hatası.";
        ProjectData.ClearProjectError();
      }
      try
      {
        WebClient webClient = new WebClient();
        this.msgsgs = this.chat.Text;
        webClient.Credentials = (ICredentials) new NetworkCredential(this.ftpname, this.ftppass);
        this.chat.Text = webClient.DownloadString(this.ftpadres1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MyProject.Forms.mainform.statusbar.Text = "Bağlantı hatası.";
        ProjectData.ClearProjectError();
      }
      this.Text = this.odabasligi.Text;
      int num = (int) Interaction.MsgBox((object) ("Oda ismi: \r\n" + this.odabasligi.Text + "\r\nDevam etmek için 'Tamam'a tıklayın."));
      this.Visible = true;
    }

    private void RichTextBox2_TextChanged(object sender, EventArgs e)
    {
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.Panel2.Visible = true;
      this.Panel1.Visible = false;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      try
      {
        WebClient webClient = new WebClient();
        this.msgsgs = this.chat.Text;
        webClient.Credentials = (ICredentials) new NetworkCredential(this.ftpname, this.ftppass);
        webClient.UploadString(this.ftpadres1, this.chat.Text + "[" + this.Name + "]: " + this.RichTextBox2.Text + "\r\n");
        this.RichTextBox2.Clear();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MyProject.Forms.mainform.statusbar.Text = "Bağlantı hatası.";
        ProjectData.ClearProjectError();
      }
      try
      {
        WebClient webClient = new WebClient();
        this.msgsgs = this.chat.Text;
        webClient.Credentials = (ICredentials) new NetworkCredential(this.ftpname, this.ftppass);
        this.chat.Text = webClient.DownloadString(this.ftpadres1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MyProject.Forms.mainform.statusbar.Text = "Bağlantı hatası.";
        ProjectData.ClearProjectError();
      }
      try
      {
        WebClient webClient = new WebClient();
        this.msgsgs = this.chat.Text;
        webClient.Credentials = (ICredentials) new NetworkCredential(this.ftpname, this.ftppass);
        this.odabasligi.Text = webClient.DownloadString(this.ftpadres2);
        this.Text = this.odabasligi.Text;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MyProject.Forms.mainform.statusbar.Text = "Bağlantı hatası.";
        ProjectData.ClearProjectError();
      }
    }

    private void chat_TextChanged(object sender, EventArgs e)
    {
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      if (Operators.CompareString(MySettingsProperty.Settings.ftpsync, "Hızlı", false) == 0)
      {
        if (Operators.ConditionalCompareObjectGreater(this.cnt, (object) 50, false))
        {
          try
          {
            WebClient webClient = new WebClient();
            this.msgsgs = this.chat.Text;
            webClient.Credentials = (ICredentials) new NetworkCredential(this.ftpname, this.ftppass);
            this.chat.Text = webClient.DownloadString(this.ftpadres1);
            if (Operators.CompareString(this.msgsgs, this.chat.Text, false) == 0)
              this.msgsgs = this.chat.Text;
            else
              MyProject.Computer.Audio.Play((Stream) Busy.My.Resources.Resources.effect, AudioPlayMode.Background);
            this.cnt = (object) 0;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            MyProject.Forms.mainform.statusbar.Text = "Bağlantı hatası.";
            this.cnt = (object) 0;
            ProjectData.ClearProjectError();
          }
        }
      }
      if (Operators.CompareString(MySettingsProperty.Settings.ftpsync, "Ortalama", false) == 0)
      {
        if (Operators.ConditionalCompareObjectGreater(this.cnt, (object) 150, false))
        {
          try
          {
            WebClient webClient = new WebClient();
            this.msgsgs = this.chat.Text;
            webClient.Credentials = (ICredentials) new NetworkCredential(this.ftpname, this.ftppass);
            this.chat.Text = webClient.DownloadString(this.ftpadres1);
            if (Operators.CompareString(this.msgsgs, this.chat.Text, false) == 0)
              this.msgsgs = this.chat.Text;
            else
              MyProject.Computer.Audio.Play((Stream) Busy.My.Resources.Resources.effect, AudioPlayMode.Background);
            this.cnt = (object) 0;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            MyProject.Forms.mainform.statusbar.Text = "Bağlantı hatası.";
            this.cnt = (object) 0;
            ProjectData.ClearProjectError();
          }
        }
      }
      if (Operators.CompareString(MySettingsProperty.Settings.ftpsync, "Yavaş", false) == 0)
      {
        if (Operators.ConditionalCompareObjectGreater(this.cnt, (object) 250, false))
        {
          try
          {
            WebClient webClient = new WebClient();
            this.msgsgs = this.chat.Text;
            webClient.Credentials = (ICredentials) new NetworkCredential(this.ftpname, this.ftppass);
            this.chat.Text = webClient.DownloadString(this.ftpadres1);
            if (Operators.CompareString(this.msgsgs, this.chat.Text, false) == 0)
              this.msgsgs = this.chat.Text;
            else
              MyProject.Computer.Audio.Play((Stream) Busy.My.Resources.Resources.effect, AudioPlayMode.Background);
            this.cnt = (object) 0;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            MyProject.Forms.mainform.statusbar.Text = "Bağlantı hatası.";
            this.cnt = (object) 0;
            ProjectData.ClearProjectError();
          }
        }
      }
      this.cnt = Operators.AddObject(this.cnt, (object) 1);
    }

    private void Label1_Click(object sender, EventArgs e)
    {
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      this.TextBox1.Text = this.odabasligi.Text;
      this.Panel2.Visible = false;
      if (Operators.ConditionalCompareObjectEqual(this.oc, (object) 0, false))
      {
        this.Panel1.Visible = true;
        this.oc = (object) 1;
      }
      else
      {
        this.Panel1.Visible = false;
        this.oc = (object) 0;
      }
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      try
      {
        WebClient webClient = new WebClient();
        this.msgsgs = this.chat.Text;
        webClient.Credentials = (ICredentials) new NetworkCredential(this.ftpname, this.ftppass);
        webClient.UploadString(this.ftpadres2, this.TextBox1.Text);
        int num = (int) Interaction.MsgBox((object) "Ayarlarınız uygulandı.", MsgBoxStyle.Information);
        this.odabasligi.Text = this.TextBox1.Text;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MyProject.Forms.mainform.statusbar.Text = "Bağlantı hatası.";
        ProjectData.ClearProjectError();
      }
    }

    private void Button5_Click(object sender, EventArgs e)
    {
      try
      {
        WebClient webClient = new WebClient();
        this.msgsgs = this.chat.Text;
        webClient.Credentials = (ICredentials) new NetworkCredential(this.ftpname, this.ftppass);
        webClient.UploadString(this.ftpadres1, this.chat.Text + MySettingsProperty.Settings.busyusername + " odadan ayrıldı.\r\n");
        MyProject.Forms.mainform.Show();
        this.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MyProject.Forms.mainform.statusbar.Text = "Bağlantı hatası.";
        ProjectData.ClearProjectError();
      }
      MyProject.Forms.mainform.Show();
      this.Close();
    }

    private void Button6_Click(object sender, EventArgs e) => this.Panel2.Visible = false;

    private void Button7_Click(object sender, EventArgs e)
    {
      if (!Operators.ConditionalCompareObjectEqual((object) Interaction.MsgBox((object) "Sohbet silinsin mi?", MsgBoxStyle.YesNo | MsgBoxStyle.Question), (object) MsgBoxResult.Yes, false))
        return;
      if (Operators.ConditionalCompareObjectEqual((object) Interaction.MsgBox((object) "Emin misiniz?", MsgBoxStyle.YesNo | MsgBoxStyle.Question), (object) MsgBoxResult.Yes, false))
      {
        try
        {
          WebClient webClient = new WebClient();
          this.msgsgs = this.chat.Text;
          webClient.Credentials = (ICredentials) new NetworkCredential(this.ftpname, this.ftppass);
          webClient.UploadString(this.ftpadres1, "");
          int num = (int) Interaction.MsgBox((object) "Ayarlarınız uygulandı.", MsgBoxStyle.Information);
          this.Panel1.Visible = false;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          MyProject.Forms.mainform.statusbar.Text = "Bağlantı hatası.";
          ProjectData.ClearProjectError();
        }
      }
    }
  }
}
