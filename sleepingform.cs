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
  public class sleeping : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;

    [DebuggerNonUserCode]
    static sleeping()
    {
    }

    [DebuggerNonUserCode]
    public sleeping()
    {
      sleeping.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (sleeping.__ENCList)
      {
        if (sleeping.__ENCList.Count == sleeping.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (sleeping.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (sleeping.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                sleeping.__ENCList[index1] = sleeping.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          sleeping.__ENCList.RemoveRange(index1, checked (sleeping.__ENCList.Count - index1));
          sleeping.__ENCList.Capacity = sleeping.__ENCList.Count;
        }
        sleeping.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      this.TextBox1 = new TextBox();
      this.Label1 = new Label();
      this.PictureBox1 = new PictureBox();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      TextBox textBox1_1 = this.TextBox1;
      Point point1 = new Point(9, 12);
      Point point2 = point1;
      textBox1_1.Location = point2;
      this.TextBox1.Multiline = true;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      Size size1 = new Size(236, 129);
      Size size2 = size1;
      textBox1_2.Size = size2;
      this.TextBox1.TabIndex = 0;
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(12, 144);
      Point point3 = point1;
      label1_1.Location = point3;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(32, 13);
      Size size3 = size1;
      label1_2.Size = size3;
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Idling";
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(145, 147);
      Point point4 = point1;
      pictureBox1_1.Location = point4;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(100, 26);
      Size size4 = size1;
      pictureBox1_2.Size = size4;
      this.PictureBox1.TabIndex = 2;
      this.PictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(257, 185);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.TextBox1);
      this.Name = nameof (sleeping);
      this.Text = nameof (sleeping);
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TextBox TextBox1
    {
      [DebuggerNonUserCode] get => this._TextBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox1 = value;
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual PictureBox PictureBox1
    {
      [DebuggerNonUserCode] get => this._PictureBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox1 = value;
    }
  }
}
