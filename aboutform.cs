using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Busy
{
  [DesignerGenerated]
  public class aboutform : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("aboutimage")]
    private PictureBox _aboutimage;
    [AccessedThroughProperty("label1")]
    private Label _label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;

    [DebuggerNonUserCode]
    static aboutform()
    {
    }

    [DebuggerNonUserCode]
    public aboutform()
    {
      aboutform.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (aboutform.__ENCList)
      {
        if (aboutform.__ENCList.Count == aboutform.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (aboutform.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (aboutform.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                aboutform.__ENCList[index1] = aboutform.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          aboutform.__ENCList.RemoveRange(index1, checked (aboutform.__ENCList.Count - index1));
          aboutform.__ENCList.Capacity = aboutform.__ENCList.Count;
        }
        aboutform.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (aboutform));
      this.Button1 = new Button();
      this.label1 = new Label();
      this.Label2 = new Label();
      this.aboutimage = new PictureBox();
      this.PictureBox1 = new PictureBox();
      ((ISupportInitialize) this.aboutimage).BeginInit();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.Button1.FlatStyle = FlatStyle.Flat;
      this.Button1.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.Button1.ForeColor = Color.FromArgb(0, 192, 0);
      Button button1_1 = this.Button1;
      Point point1 = new Point(202, 215);
      Point point2 = point1;
      button1_1.Location = point2;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      Size size1 = new Size(70, 34);
      Size size2 = size1;
      button1_2.Size = size2;
      this.Button1.TabIndex = 0;
      this.Button1.Text = "Tamam";
      this.Button1.UseVisualStyleBackColor = true;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      Label label1_1 = this.label1;
      point1 = new Point(12, 116);
      Point point3 = point1;
      label1_1.Location = point3;
      this.label1.Name = "label1";
      Label label1_2 = this.label1;
      size1 = new Size(78, 24);
      Size size3 = size1;
      label1_2.Size = size3;
      this.label1.TabIndex = 2;
      this.label1.Text = "LS Busy";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      Label label2_1 = this.Label2;
      point1 = new Point(12, 153);
      Point point4 = point1;
      label2_1.Location = point4;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(137, 54);
      Size size4 = size1;
      label2_2.Size = size4;
      this.Label2.TabIndex = 3;
      this.Label2.Text = "Busy Sürüm S-1.0 \r\n22.12.2020\r\n\r\n";
      this.aboutimage.Image = (Image) Busy.My.Resources.Resources.busylogo1;
      PictureBox aboutimage1 = this.aboutimage;
      point1 = new Point(87, 12);
      Point point5 = point1;
      aboutimage1.Location = point5;
      this.aboutimage.Name = "aboutimage";
      PictureBox aboutimage2 = this.aboutimage;
      size1 = new Size(100, 100);
      Size size5 = size1;
      aboutimage2.Size = size5;
      this.aboutimage.SizeMode = PictureBoxSizeMode.StretchImage;
      this.aboutimage.TabIndex = 1;
      this.aboutimage.TabStop = false;
      this.PictureBox1.Image = (Image) Busy.My.Resources.Resources.LSlogo;
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(-8, 207);
      Point point6 = point1;
      pictureBox1_1.Location = point6;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(64, 61);
      Size size6 = size1;
      pictureBox1_2.Size = size6;
      this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.PictureBox1.TabIndex = 4;
      this.PictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(284, 261);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.aboutimage);
      this.Controls.Add((Control) this.Button1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      size1 = new Size(300, 300);
      this.MaximumSize = size1;
      size1 = new Size(300, 300);
      this.MinimumSize = size1;
      this.Name = nameof (aboutform);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Hakkında";
      ((ISupportInitialize) this.aboutimage).EndInit();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
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

    internal virtual PictureBox aboutimage
    {
      [DebuggerNonUserCode] get => this._aboutimage;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._aboutimage = value;
    }

    internal virtual Label label1
    {
      [DebuggerNonUserCode] get => this._label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._label1 = value;
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Label2_Click);
        if (this._Label2 != null)
          this._Label2.Click -= eventHandler;
        this._Label2 = value;
        if (this._Label2 == null)
          return;
        this._Label2.Click += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox1
    {
      [DebuggerNonUserCode] get => this._PictureBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox1 = value;
    }

    private void Label2_Click(object sender, EventArgs e)
    {
    }

    private void Button1_Click(object sender, EventArgs e) => this.Close();
  }
}
