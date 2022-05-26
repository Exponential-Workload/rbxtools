namespace MultiRBX
{
  partial class Form1
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
      this.components = new System.ComponentModel.Container();
      System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.materialLabel2 = new MaterialWinforms.Controls.MaterialLabel();
      this.materialRaisedButton1 = new Zeroit.Framework.MaterialWinforms.Controls.MaterialRaisedButton();
      this.materialLabel3 = new MaterialWinforms.Controls.MaterialLabel();
      this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
      this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
      this.siticoneDragControl3 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
      this.SuspendLayout();
      // 
      // materialLabel2
      // 
      this.materialLabel2.Depth = 0;
      this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.materialLabel2.Location = new System.Drawing.Point(0, 0);
      this.materialLabel2.MouseState = MaterialWinforms.MouseState.HOVER;
      this.materialLabel2.Name = "materialLabel2";
      this.materialLabel2.Size = new System.Drawing.Size(345, 177);
      this.materialLabel2.TabIndex = 1;
      this.materialLabel2.Text = "\r\nMultiRBX is now active.\r\n\r\nPlease make sure you started\r\nMultiRBX before Roblox" +
    ".";
      this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // materialRaisedButton1
      // 
      this.materialRaisedButton1.Depth = 0;
      this.materialRaisedButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.materialRaisedButton1.Elevation = 5;
      this.materialRaisedButton1.Location = new System.Drawing.Point(0, 131);
      this.materialRaisedButton1.MouseState = Zeroit.Framework.MaterialWinforms.MouseState.HOVER;
      this.materialRaisedButton1.Name = "materialRaisedButton1";
      this.materialRaisedButton1.Primary = true;
      graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
      this.materialRaisedButton1.ShadowBorder = graphicsPath1;
      this.materialRaisedButton1.Size = new System.Drawing.Size(345, 46);
      this.materialRaisedButton1.TabIndex = 2;
      this.materialRaisedButton1.Text = "Close";
      this.materialRaisedButton1.UseVisualStyleBackColor = true;
      this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
      // 
      // materialLabel3
      // 
      this.materialLabel3.Depth = 0;
      this.materialLabel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.materialLabel3.Location = new System.Drawing.Point(0, 105);
      this.materialLabel3.MouseState = MaterialWinforms.MouseState.HOVER;
      this.materialLabel3.Name = "materialLabel3";
      this.materialLabel3.Size = new System.Drawing.Size(345, 26);
      this.materialLabel3.TabIndex = 3;
      this.materialLabel3.Text = "Made with <3 by Yielding#3961";
      this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // siticoneDragControl1
      // 
      this.siticoneDragControl1.TargetControl = this;
      // 
      // siticoneDragControl2
      // 
      this.siticoneDragControl2.TargetControl = this.materialLabel2;
      // 
      // siticoneDragControl3
      // 
      this.siticoneDragControl3.TargetControl = this.materialLabel3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
      this.ClientSize = new System.Drawing.Size(345, 177);
      this.Controls.Add(this.materialLabel3);
      this.Controls.Add(this.materialRaisedButton1);
      this.Controls.Add(this.materialLabel2);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "MultiRBX";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion
    private MaterialWinforms.Controls.MaterialLabel materialLabel2;
    private Zeroit.Framework.MaterialWinforms.Controls.MaterialRaisedButton materialRaisedButton1;
    private MaterialWinforms.Controls.MaterialLabel materialLabel3;
    private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
    private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
    private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl3;
  }
}

