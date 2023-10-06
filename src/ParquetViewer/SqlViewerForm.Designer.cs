namespace ParquetViewer;

partial class SqlViewerForm
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
        textBox1 = new System.Windows.Forms.TextBox();
        panel1 = new System.Windows.Forms.Panel();
        buttonCopy = new System.Windows.Forms.Button();
        buttonClose = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        textBox1.Location = new System.Drawing.Point(0, 0);
        textBox1.MaxLength = 65535;
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        textBox1.Size = new System.Drawing.Size(858, 534);
        textBox1.TabIndex = 0;
        textBox1.WordWrap = false;
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonCopy);
        panel1.Controls.Add(buttonClose);
        panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel1.Location = new System.Drawing.Point(0, 534);
        panel1.Name = "panel1";
        panel1.Padding = new System.Windows.Forms.Padding(16, 4, 16, 4);
        panel1.Size = new System.Drawing.Size(858, 34);
        panel1.TabIndex = 1;
        // 
        // buttonCopy
        // 
        buttonCopy.Dock = System.Windows.Forms.DockStyle.Left;
        buttonCopy.Location = new System.Drawing.Point(16, 4);
        buttonCopy.Name = "buttonCopy";
        buttonCopy.Size = new System.Drawing.Size(75, 26);
        buttonCopy.TabIndex = 1;
        buttonCopy.Text = "Copy";
        buttonCopy.UseVisualStyleBackColor = true;
        buttonCopy.Click += buttonCopy_Click;
        // 
        // buttonClose
        // 
        buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
        buttonClose.Location = new System.Drawing.Point(763, 4);
        buttonClose.Name = "buttonClose";
        buttonClose.Size = new System.Drawing.Size(79, 26);
        buttonClose.TabIndex = 0;
        buttonClose.Text = "Cancel";
        buttonClose.UseVisualStyleBackColor = true;
        buttonClose.Click += buttonClose_Click;
        // 
        // SqlViewerForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        CancelButton = buttonClose;
        ClientSize = new System.Drawing.Size(858, 568);
        Controls.Add(textBox1);
        Controls.Add(panel1);
        MinimumSize = new System.Drawing.Size(320, 240);
        Name = "SqlViewerForm";
        Text = "Sql Viewer";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button buttonCopy;
    private System.Windows.Forms.Button buttonClose;
}